using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepNaiWorkshop_6001.Model
{
    public class ResourceMoviesJson
    {
        public long updateTime;//主要是为了同步内存和文件中哪个最新
        public List<ResourceModule> resourceList;
    }
}
