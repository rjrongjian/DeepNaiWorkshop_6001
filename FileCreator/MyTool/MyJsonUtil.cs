using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCreator.MyTool
{
    class MyJsonUtil<T>
    {

        /// <summary>
        /// 将josn字符串转化成json对象
        /// </summary>
        /// <param name="jsonStr"></param>
        /// <returns></returns>
        public T parseJsonStr(string jsonStr)
        {
            return JsonConvert.DeserializeObject<T>(jsonStr);
        }
        /// <summary>
        /// 将json对象转换成json字符串
        /// </summary>
        /// <param name="jsonObj"></param>
        /// <returns></returns>
        public string parseJsonObj(T jsonObj)
        {
            return JsonConvert.SerializeObject(jsonObj, Formatting.Indented);
        }

    }
}
