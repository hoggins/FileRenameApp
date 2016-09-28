using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FileRenameApp
{
  public enum RenameProcessorStatus
  {
    Ready,
    Starting,
    Working,
  }

  public class RenameProcessor
  {
    public RenameProcessorStatus Status { get { return (RenameProcessorStatus) _status; }}
    public event Action<RenameProcessorStatus> OnStatusChanged =  delegate {};

    private string _folder;
    private string _format;
    private int _status;
    private Thread _renameThread;

    public RenameProcessor(string folder, string format)
    {
      _folder = folder;
      _format = format;
    }

    public void Start()
    {
      if (!Directory.Exists(_folder))
      {
        Program.Log.Info("Failed to start. directory not found: " + _folder);
        return;
      }

      if (!TrySetStatus(from: RenameProcessorStatus.Ready, to: RenameProcessorStatus.Starting))
      {
        Program.Log.Info("Failed to start. Renameing is in progress.");
        return;
      }

      _renameThread = new Thread(RenameProc);
      _renameThread.Start();
    }

    public void Stop()
    {
      if (_renameThread != null)
        _renameThread.Abort();

      SetStatus(RenameProcessorStatus.Ready);
    }

    private bool TrySetStatus(RenameProcessorStatus from, RenameProcessorStatus to)
    {
      if ((int)from != Interlocked.CompareExchange(ref _status, (int)to, (int)from))
        return false;
      
      OnStatusChanged.Invoke(to);
      return true;
    }

    private void SetStatus(RenameProcessorStatus status)
    {
      _status = (int) status;
      OnStatusChanged.Invoke(status);
    }

    private void RenameProc()
    {
      try
      {
        if (!TrySetStatus(from: RenameProcessorStatus.Starting, to: RenameProcessorStatus.Working))
          return;

        var files = new DirectoryInfo(_folder).GetFiles();
        for (var i = 0; i < files.Length; i++)
        {
          var file = files[i];
          var newName = GenerateName(i, file);
          Program.Log.Info("{0} -> {1}", file.Name, newName);

          // todo: actual rename
        }

        Program.Log.Info("----------");
        Program.Log.Info("All done");
        
        SetStatus(RenameProcessorStatus.Ready);
      }
      catch (ThreadAbortException)
      {
      }
    }

    private string GenerateName(int idx, FileInfo file)
    {
      if (_format.Contains("#n"))
        return _format.Replace("#n", idx.ToString()) + file.Extension;
      return _format + idx + file.Extension;
    }

  }
}
