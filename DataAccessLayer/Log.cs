using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;


namespace DataAccessLayer
{
    public static class Log
    {
        private static readonly string _sourceName = "DVLD";
        private static readonly string _logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.txt"); // in the debug folder
        
        
        public static void LogEvent(EventLogEntryType entryType, string message, string stackTrace = "", [CallerMemberName] string callerName = "")
        {
            LogToFile(entryType, $"Calling Method: {callerName} - {message}", stackTrace);
            LogToEventViewer(entryType, $"Calling Method: {callerName} - {message}", stackTrace);
        }

        private static void LogToFile(EventLogEntryType entryType, string message, string stackTrace = "")
        {
            try
            {
                string formattedMessage = FormattedErrorMessage(entryType, message, stackTrace);
                File.AppendAllText(_logFilePath, formattedMessage + Environment.NewLine);
            }
            catch (Exception e)
            {
                // to avoid exceptions when no admin permission rights
                //throw new Exception($"Writing to Log File Error: {e.Message}");
            }
        }

        private static void LogToEventViewer(EventLogEntryType entryType, string message, string stackTrace = "")
        {
            try
            {
                string formattedMessage = FormattedErrorMessage(entryType, message, stackTrace);
                // added manifest file for adminstrator permission
                EventLog.WriteEntry(_sourceName, formattedMessage, entryType);
            }
            catch (Exception e)
            {
                // to avoid exceptions when no admin permission rights
                //throw new Exception($"Writing to Event Viewer error: {e.Message}");
            }
        }
        
        
        private static string FormattedErrorMessage(EventLogEntryType entryType, string message, string stackTrace = "")
        {
            
            if (entryType == EventLogEntryType.Error)
                return $"[{DateTime.Now}][{entryType}][{message}][Trace: {stackTrace}]";
            else
                return $"[{DateTime.Now}][{entryType}][{message}]";
        }
        
     
    }
}
