/*
 * Author:      Dave Manley
 * Date:        01/14/2013
 * Description: ErrorMsg - Library for managing popup errors
 * Dependencies: Log
*/

using System;
using System.Windows.Forms;

namespace TCPAsync
{
    public abstract class ErrorMsg
    {
        public static bool debug = false;
        public enum MsgLevel { debug, warning, critical, msg, alert, decisionyes, decisionmotor};
        public static bool ThrowError(String msg, String Title,MsgLevel el, Exception ex)
        {
            switch (el)
            {
                case MsgLevel.critical:
                    if (!debug)
                    {
                        MessageBox.Show("CRITICAL ERROR: " + msg, Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (ex != null)
                                Log.Write("CRITICAL ERROR: " + Title + ":" + msg + ":" + ex.Message);
                        else
                            if (!Log.fetcherror)
                                Log.Write("CRITICAL ERROR: " + Title + ":" + msg);
                    }
                    else
                        if (ex != null)
                            MessageBox.Show("CRITICAL ERROR: " + msg + Environment.NewLine + "Details: " + ex.Message, Title);
                        else
                            MessageBox.Show("CRITICAL ERROR: " + msg, Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case MsgLevel.debug:
                    if (debug)
                        if(ex!=null)
                            MessageBox.Show("Debug: " + msg + Environment.NewLine + "Details: " + ex.Message, Title);
                        else
                            MessageBox.Show("Debug: " + msg + Environment.NewLine , Title);
                    break;
                case MsgLevel.msg:
                        MessageBox.Show(msg, Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Log.Write("Message: " + Title + ":" + msg);
                    break;
                case MsgLevel.alert:
                        MessageBox.Show("Alert: " + msg, Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Log.Write("Alert: " + Title + ":" + msg);
                    break;
                case MsgLevel.decisionyes:
                        bool val=(MessageBox.Show(msg,Title,MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.Yes);
                        Log.Write("Decision: " + Title + ":" + msg +":"+val.ToString());
                        return val;
                    //break;
                case MsgLevel.decisionmotor:
                        bool val1=(MessageBox.Show("Motor Warning: " + msg, Title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes);
                        Log.Write("Motor Warning: " + Title + ":" + msg+":"+val1.ToString());
                        return val1;
                    //break;
                default:
                    if (!debug)
                    {
                        MessageBox.Show("Warning: " + msg, Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (ex != null)
                            Log.Write("Warning: " + Title + ":" + msg + ":" + ex.Message);
                        else
                            Log.Write("Warning: " + Title + ":" + msg);
                    }
                    else
                        if (ex == null)
                            MessageBox.Show("Warning: " + msg, Title);
                        else
                            MessageBox.Show("Warning: " + msg + Environment.NewLine + "Details: " + Environment.NewLine + ex.Message.ToString() + Environment.NewLine + "Stack: " + Environment.NewLine + ex.StackTrace.ToString(), Title); 
                    break;
            }
            return false;
        }
     }
}
