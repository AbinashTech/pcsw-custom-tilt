using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Tilt_Switch_System.Usecase;
using System.Windows.Forms;
using Tilt_Switch_System.Views;

namespace Tilt_Switch_System.Utility
{
    public delegate void MyDelegate();
    class Globals
    {

        public static string ErrorLog = Application.StartupPath + "\\Logs";

        public static string CommPort;
        public static int BaudRate = 0;
        public static string Header1;
        public static string HeaderLogo;
        public static string HeaderLogoImage ;//= System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);

        //Communication Status
        public static bool FlagCommStatus = false;
        public static bool XRawAdc = false;
        public static bool YRawAdc = false;
        public static bool ZRawAdc = false;
        public static bool LowRangeSelect = false;
        public static bool HighRAngeSelect = false;
        
        public static bool ModbusSelect = false;
        public static bool Rs232Select = false;
        public static bool Iscomtrue = false;
        public static bool IsSetLimit = false;
        public static bool IsRbHigh = false;
        public static bool IsRbLow = false;
        public static SettingScreen objSetting = new SettingScreen();

        public static void InitiateApplication()
        {
            DataTable dt = new DataTable();
            UsecaseLogin usecaseLogin = new UsecaseLogin();
            dt = usecaseLogin.GetPortDetails();
            Globals.Header1 = dt.Rows[0]["header1"].ToString();
            Globals. HeaderLogo = dt.Rows[0]["header2"].ToString();
            Globals.HeaderLogoImage =dt.Rows[0]["header2"].ToString();
            Globals.CommPort = dt.Rows[0]["Comport_id"].ToString();
            Globals.BaudRate = int.Parse(dt.Rows[0]["baudrate"].ToString());

        }
    }

}
