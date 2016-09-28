using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileRenameApp
{
  public partial class MainForm : Form
  {
    private RenameProcessor _renameProc;
    private int KnownConsoleMessage;

    public MainForm()
    {
      InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      _nameFormatTb.MouseHover += (o, args) => ShowFormatTooltip(); 
    }

    private void ShowFormatTooltip()
    {
      _formatTooltip.Show(@"#n - autoincrement item id
#d - day passed from the first object", _nameFormatTb);
    }


    private void UpdateStatus(RenameProcessorStatus status)
    {
      Print(status.ToString());

    }

    private void RunBtn_Click(object sender, EventArgs args)
    {
      try
      {
        _renameProc = new RenameProcessor(_destFolderTb.Text, _nameFormatTb.Text);
        _renameProc.OnStatusChanged += s => this.SafeInvoke(() => UpdateStatus(s));
        _renameProc.Start();
      }
      catch (Exception e)
      {
        var str = e.ToString();
        Print(str);
      }
    }

    private void Print(string str)
    {
      _outputListBox.Items.Add(str);
    }

    private void Print(List<string> str)
    {
      _outputListBox.Items.AddRange(str.Select(s=>(object)s).ToArray());
    }

    private void BrowseBtn_Click(object sender, EventArgs e)
    {
      var dialog = new FolderBrowserDialog();
      var result = dialog.ShowDialog();
      if (result != DialogResult.OK)
        return;

      _destFolderTb.Text = dialog.SelectedPath;
    }

    private void ConsoleTimer_Tick(object sender, EventArgs e)
    {
      var newMsgs = Program.Log.GetMessages(KnownConsoleMessage);
      if (newMsgs == null)
        return;
      KnownConsoleMessage += newMsgs.Count; // todo proper revisions
      Print(newMsgs);
    }
  }

  public static class UiExt
  {
    /// <summary>
    /// Execute a method on the control's owning thread.
    /// </summary>
    /// <param name="uiElement">The control that is being updated.</param>
    /// <param name="updater">The method that updates uiElement.</param>
    /// <param name="forceSynchronous">True to force synchronous execution of 
    /// updater.  False to allow asynchronous execution if the call is marshalled
    /// from a non-GUI thread.  If the method is called on the GUI thread,
    /// execution is always synchronous.</param>
    public static void SafeInvoke(this Control uiElement, Action updater, bool forceSynchronous = false)
    {
      if (uiElement == null)
      {
        throw new ArgumentNullException("uiElement");
      }

      if (uiElement.InvokeRequired)
      {
        if (forceSynchronous)
        {
          uiElement.Invoke((Action)delegate { SafeInvoke(uiElement, updater, forceSynchronous); });
        }
        else
        {
          uiElement.BeginInvoke((Action)delegate { SafeInvoke(uiElement, updater, forceSynchronous); });
        }
      }
      else
      {
        if (!uiElement.IsHandleCreated)
        {
          // Do nothing if the handle isn't created already.  The user's responsible
          // for ensuring that the handle they give us exists.
          return;
        }

        if (uiElement.IsDisposed)
        {
          throw new ObjectDisposedException("Control is already disposed.");
        }

        updater();
      }
    }
  }
}
