using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepNaiWorkshop_6001.Model
{
    class Member
    {

        public int MemberType //1 临时会员 2 充值账号
        {
            set;
            get;
        } 

        public string MemberCode //会员码就是json的名字，临时账号此值为空
        {
            set;
            get;
        }


        public MemberJson MemberJson //临时账号此值为空
        {
            set;
            get;
        }

        public static  Member GetTemporaryMember()
        {
            Member member = new Member();
            member.MemberType = 1;
            member.MemberCode = null;
            member.MemberJson = null;
            return member;
        }
    }
}
