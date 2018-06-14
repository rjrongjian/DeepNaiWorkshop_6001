using DeepNaiWorkshop_6001.View;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeepNaiWorkshop_6001.MyTool
{
    class MyWinformUtil
    {
        public static void ShowProcessing(string msg, Form owner, ParameterizedThreadStart work, object workArg = null)
        {
            FrmProcessing processingForm = new FrmProcessing(msg);
            dynamic expObj = new ExpandoObject();
            expObj.Form = processingForm;
            expObj.WorkArg = workArg;
            processingForm.SetWorkAction(work, expObj);
            processingForm.ShowDialog(owner);
            if (processingForm.WorkException != null)
            {
                throw processingForm.WorkException;
            }
        }
    }
}
