using System;

// define the 'LogLevel' enum
enum LogLevel 
{
    Trace=1,
    Debug=2,
    Info=4,   
    Warning=5,       
    Error=6,
    Fatal=42,
    Unknown=0,
      
}

static class LogLine
{
    public static LogLevel ParseLogLevel(string logLine)
    {
 
 string message = logLine.Substring(1,3);
    switch (message) 
        {
            case "TRC":
                return LogLevel.Trace;
                break;
            case "DBG":
                return LogLevel.Debug;
                break;
            case "INF":
                return LogLevel.Info;
                break;
            case "WRN":
                return LogLevel.Warning;
                break;
            case "ERR":
                return LogLevel.Error;
                break;
            case "FTL":
                return LogLevel.Fatal;
                break;
            default:return LogLevel.Unknown;

        } 
    }

    public static string OutputForShortLog(LogLevel logLevel, string message)
    {
        return $"{(int)logLevel}:{message}";
    }
}
