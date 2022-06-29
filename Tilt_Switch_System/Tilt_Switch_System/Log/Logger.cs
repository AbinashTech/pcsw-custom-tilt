using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Threading;
using Tilt_Switch_System.Utility;
using System.IO;

namespace Tilt_Switch_System.Log
{
    public static class Logger
    {
        private static readonly object _SyncLock = new object();

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static string GetMethodName()
        {
            var st = new StackTrace(new StackFrame(1));
            return st.GetFrame(0).GetMethod().Name + "()";
        }

        public static void WriteLogFile(string fileName, string methodName, string message)
        {
            try
            {
                Monitor.Enter(_SyncLock);
                string year = DateTime.Now.Year.ToString();
                string month = DateTime.Now.ToString("MMM");
                string folderExists = Globals.ErrorLog;
                string folderyearExists = folderExists + @"/" + year;
                string foldermonthExists = folderyearExists + @"/" + month;
                if (!Directory.Exists(folderExists))
                    Directory.CreateDirectory(folderExists);
                if (!Directory.Exists(folderyearExists))
                    Directory.CreateDirectory(folderyearExists);
                if (!Directory.Exists(foldermonthExists))
                    Directory.CreateDirectory(foldermonthExists);
                if (!string.IsNullOrEmpty(message))
                {
                    using (FileStream file = new FileStream(foldermonthExists + @"/" + DateTime.Now.ToString("dd MM yyyy") + ".txt", FileMode.Append, FileAccess.Write))
                    {
                        StreamWriter streamWriter = new StreamWriter(file);
                        streamWriter.WriteLine((((System.DateTime.Now + "-") + fileName + " - ") + methodName + "-") + message + "\r");
                        //streamWriter.WriteLine("\n");
                        streamWriter.Close();
                    }
                }
            }
            catch (Exception)
            {
                // MessageBox.Show("Error occured during the DATA LOGGING process..!");
            }
            finally { Monitor.Exit(_SyncLock); }
        }
        //public static void WriteSessionLogFile(string fileName, string methodName, string message)
        //{
        //    try
        //    {
        //        Monitor.Enter(_SyncLock);
        //        string year = DateTime.Now.Year.ToString();
        //        string month = DateTime.Now.ToString("MMM");
        //        string folderExists = Globals.SessionLog;
        //        string folderyearExists = folderExists + @"/" + year;
        //        string foldermonthExists = folderyearExists + @"/" + month;
        //        if (!Directory.Exists(folderExists))
        //            Directory.CreateDirectory(folderExists);
        //        if (!Directory.Exists(folderyearExists))
        //            Directory.CreateDirectory(folderyearExists);
        //        if (!Directory.Exists(foldermonthExists))
        //            Directory.CreateDirectory(foldermonthExists);
        //        if (!string.IsNullOrEmpty(message))
        //        {
        //            using (FileStream file = new FileStream(foldermonthExists + @"/" + DateTime.Now.ToString("dd MM yyyy") + ".txt", FileMode.Append, FileAccess.Write))
        //            {
        //                StreamWriter streamWriter = new StreamWriter(file);
        //                streamWriter.WriteLine((((System.DateTime.Now + " - ") + fileName + " - ") + methodName + " - ") + message + "\r");
        //                streamWriter.WriteLine("\n");
        //                streamWriter.Close();
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error occured during the DATA LOGGING process..!");
        //    }
        //    finally { Monitor.Exit(_SyncLock); }
        //}
    }
}
