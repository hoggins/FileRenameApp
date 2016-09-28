using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace FileRenameApp
{
  public class Logger
  {
    public List<string> LogMessages = new List<string>();

    [StringFormatMethod("format")]
    public void Error(string format, params object[] args)
    {
      Error(string.Format(format, args));
    }

    public void Error(string str)
    {
      //todo: implement something
      LogMessages.Add(str);
    }

    [StringFormatMethod("format")]
    public void Info(string format, params object[] args)
    {
      Info(string.Format(format, args));
    }

    public void Info(string str)
    {
      LogMessages.Add(str);
    }

    public List<string> GetMessages(int rev)
    {
      if (LogMessages.Count <= rev)
        return null;

      return LogMessages.Skip(rev).ToList();
    }
  }
}
