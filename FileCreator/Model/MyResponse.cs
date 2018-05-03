using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCreator.Model
{
    public class MyResponse
    {
        public bool isSuccess;//是否执行成功
        public string message;//提示信息
        public MyResponse(bool isSuccess,string message)
        {
            this.isSuccess = isSuccess;
            this.message = message;
        }
    }
}
