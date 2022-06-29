using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Tilt_Switch_System.Dal;

namespace Tilt_Switch_System.Usecase
{
    class UsecaseLogin
    {
        DataTable ResDt = new DataTable();
        DataAccessHelper helpr = new DataAccessHelper();
        string qry = string.Empty;
        public DataTable GetPortDetails()
        {
            qry = "Select * from f_info where id=1";
            ResDt = helpr.GetDatatable(qry);
            return ResDt;
        }
    }
}
