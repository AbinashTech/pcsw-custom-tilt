using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tilt_Switch_System.Usecase;

namespace Tilt_Switch_System.Controller
{
    public class ControllerSetting
    {
        Usecasesetting ObjUscSetting = new Usecasesetting();
        public int updateCommValue(string commVal, int baudRate)
        {
            return ObjUscSetting.UpdateCommValue(commVal, baudRate);
        }
        public int updateHeaderVal(string h1, string h2)
        {
            return ObjUscSetting.UpdateHeaderValue(h1, h2);
        }
    }
}
