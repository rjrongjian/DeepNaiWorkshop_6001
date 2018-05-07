using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCreator.Model
{
    class ResourceInfoForCombox
    {
        public int index { set; get; } //实体类必须加set；get combobox才能显示正常
        public string moduleName { set; get; }
    }
}
