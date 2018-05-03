using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCreator.Model
{
    class MyResponse
    {
        public bool isSuccess;
        public string content;

        public MyResponse(bool isSuccess,string content)
        {
            this.isSuccess = isSuccess;
            this.content = content;
        }
    }
}
