using DeepNaiWorkshop_6001.Model;
using DeepNaiWorkshop_6001.MyTool;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCreator.MyTool
{
    class MemberCodeUtil
    {
        private static char[] chr = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G',
                'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};

        /// <summary>
        /// 
        /// </summary>
        /// <param name="codeDirFromServer">服务器上存储的会员码导到本地的目录</param>
        /// <param name="createdMemberCodeCount">此次要生成的会员数量</param>
        /// <returns></returns>
        public static List<string> CreateUsableCode(string codeDirFromServer, int createdMemberCodeCount)
        {
            List<string> createdCodes = new List<string>();
            //遍历codeDirFromServer包含子目录所有已经使用的码
            String allCode = getAllCode(codeDirFromServer);//获取此文件夹下所有文件标题，组成字符串
            while (true)
            {
                if(createdCodes.Count>= createdMemberCodeCount)//已经达到个数
                {
                    break;
                }
                string code = CreateRandomCode(8);
                if (allCode.Contains(code))//此码目前已被使用
                {
                    continue;
                }
                else
                {
                    createdCodes.Add(code);
                    allCode += "|" + code + SystemConfig.memberCodeFileSuffix;
                }
            }

            return createdCodes;
        }

        private static string getAllCode(string codeDirFromServer)
        {
            StringBuilder sb = new StringBuilder();
            List<string> list = new MyFileUtil().GetAllFiles(new DirectoryInfo(codeDirFromServer));
            foreach(string code in list)
            {
                sb.Append("|"+code);
            }
            
            return sb.ToString();
        }


        private static string CreateRandomCode(int length)
        {
            
            StringBuilder buffer = new StringBuilder();
            //必须用此方式，要不由于c#是伪随机，由于时间太短，结果会相同
            long tick = DateTime.Now.Ticks;
            Random ran = new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));


            for (int i = 0; i < length; i++)
            {
                buffer.Append(chr[ran.Next(0,36)]);
            }

            Console.Write("生成的随机码："+ buffer.ToString());
            return buffer.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="codeDirFromServer">服务器上存储的会员码导到本地的目录</param>
        /// <param name="expiredDays">会员超时时间</param>
        /// <param name="memberLevel">会员等级</param>
        /// <returns></returns>
        public static string GetCodeListFilePath(string codeDirFromServer, int expiredDays, int memberLevel)
        {
            string dir = codeDirFromServer + "new\\";
            //目录不存在就创建
            MyFileUtil.CreateDir(dir);
            string path = dir+"memberLevel_" + memberLevel + "_expiredDays_" + expiredDays + ".txt";
            return path;
        }

        public static string GetMemberFilePath(string codeDirFromServer, int expiredDays, int memberLevel,string code)
        {
            string dir = codeDirFromServer + "new\\memberLevel_" + memberLevel + "_expiredDays_" + expiredDays + "\\";
            //目录不存在就创建
            MyFileUtil.CreateDir(dir);
            string path = dir + code + SystemConfig.memberCodeFileSuffix;
            return path;
        }
    }
}
