using DeepNaiWorkshop_6001.Model;
using DeepNaiWorkshop_6001.MyTool;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepNaiWorkshop_6001.Service
{
    class MemberService
    {
        private Member member;
        public Member ReLoad()
        {
            //存在文件，就去解析会员信息
            if (MyFileUtil.IsExistInRootDir(SystemConfig.memberFile))
            {
                string memberContent = File.ReadAllText(SystemConfig.memberFile);
                //解密数据
                memberContent = MyVal.DecodeForMemberFile(memberContent);
                //转化数据
                member = JsonConvert.DeserializeObject<Member>(memberContent);
            }
            else //不存在，当前登陆的账号信息
            {
                member = Member.GetTemporaryMember();
            }

            return member;
        }

        
        public Member GetCurrentLoadMember()
        {
            return member;
        }
        /// <summary>
        /// 判断当前会员是否有效
        /// </summary>
        /// <returns></returns>
        public bool CanUseMember(SystemConfigJson systemConfigJson)
        {
            if (member.MemberType == 2)//充值会员
            {
                //判断充值用户是否有效
                if (member.MemberJson.ExpiredDays > 0)
                {
                    if(member.MemberJson.Permissions!=null&& member.MemberJson.Permissions.Count > 0)
                    {
                        if (member.MemberJson.ExpireTime == 0)//说明此会员还未来的及更新他的超时时间，所以认为是有效的
                        {
                            return true;
                        }
                        else
                        {
                            long currentServerTime = MySystemUtil.GetServerTime(systemConfigJson.isUseOtherServerTime,systemConfigJson.serverTimeFromUrlResponseHeaderDate);
                            if(currentServerTime> member.MemberJson.ExpireTime)
                            {
                                return false;
                            }
                            else
                            {
                                return true;
                            }
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else if(member.MemberType == 1)//临时会员
            {
                //判断注册表中指定字段的数据是否存在
                int time = MySystemUtil.GetRegistryMemberUsedData();
                if (time > SystemConfig.durationOfTemporaryMembers)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                throw new Exception("不能识别的会员类别："+ member.MemberType);
            }

        }
    }
}
