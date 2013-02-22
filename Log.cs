/*
 * Author:      Dave Manley
 * Date:        01/14/2013
 * Description: Log - Library for managing a log file
 * Dependencies: ErrorMsg
*/

using System;
using System.IO;

namespace TCPAsync
{
    public static class Log
    {
        private static String logName = "TCPAsync.log";
        public static bool fetcherror = true, firsterror = false;

        public static void Write(string lineToWrite)
        {
            if(!firsterror)
            {
                fetcherror = false;
                try
                {
                    if (!File.Exists(logName))
                        File.Create(logName).Close();
                    using (StreamWriter outfile = File.AppendText(logName))
                    {
                        outfile.WriteLine(DateTime.Now.ToString() + ": " + lineToWrite);
                    }
                }
                catch (Exception ex)
                {
                    if (!firsterror)
                    {
                        firsterror = true;
                        fetcherror = true;
                        ErrorMsg.ThrowError("Could not write to log file. Make sure the file is not open.", "TCPAsync Log File Error", ErrorMsg.MsgLevel.critical, ex);
                    }
                }
            }
        }
    }
}
