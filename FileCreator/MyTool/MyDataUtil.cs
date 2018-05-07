using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileCreator.Model;

namespace FileCreator.MyTool
{
    class MyDataUtil
    {
        public static List<ResourceInfoForCombox> deepCopy(List<ResourceInfoForCombox> list)
        {
            List<ResourceInfoForCombox> copyList = new List<ResourceInfoForCombox>();
            foreach(ResourceInfoForCombox resourceInfoForCombox in list)
            {
                copyList.Add(new ResourceInfoForCombox { index = resourceInfoForCombox.index,moduleName = resourceInfoForCombox.moduleName });
            }

            return copyList;
        }
    }
}
