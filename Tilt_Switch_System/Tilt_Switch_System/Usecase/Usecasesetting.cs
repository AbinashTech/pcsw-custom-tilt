using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Tilt_Switch_System.Dal;

namespace Tilt_Switch_System.Usecase
{
   public class Usecasesetting
    {

        DataTable ResDt = new DataTable();
        DataAccessHelper helpr = new DataAccessHelper();
       string qry = string.Empty;
       public int UpdateCommValue(string comValue, int baudRate)
       {
           qry = string.Empty;
           qry = "update f_info  set [comport_id]=@comport,BaudRate=@baudrate where [id]=1";
           string[] InpParam = { "@comport", "@baudrate" };
           Object[] outputParam = { comValue, baudRate };
           return helpr.ExecuteNonQuery(qry, InpParam, outputParam);
       }
       public int UpdateHeaderValue(string h1, string h2)
       {
           qry = string.Empty;
           qry = "update f_info  set header1=@header1,header2=@header2 where [id]=1";
           string[] InpParam = { "@header1", "@header2" };
           Object[] outputParam = { h1, h2 };
           return helpr.ExecuteNonQuery(qry, InpParam, outputParam);
       }
    }
}
