using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepNaiWorkshop_6001.MyTool
{
    class YiYouCode
    {
        private static Dictionary<String, String> errCodeList;

        static YiYouCode()
        {
            errCodeList = new Dictionary<string, string>();
            errCodeList.Add("1", "成功!");
            errCodeList.Add("-1", "网络链接失败");
            errCodeList.Add("-2", "请填写程序密钥");
            errCodeList.Add("-3", "数据异常");
            errCodeList.Add("-4", "数据异常");
            errCodeList.Add("-5", "错误的参数,请检查参数是否正确.");
            errCodeList.Add("-6", "还未登录");
            errCodeList.Add("-7", "私人服务器,没有权限进行登录.");
            errCodeList.Add("-8", "账户余额不足.");
            errCodeList.Add("-9", "注册用户达到上限.");
            errCodeList.Add("-10", "VIP 插件,非 VIP 无法使用.");
            errCodeList.Add("-11", "开启自动状态检测失败,还未登陆!");
            errCodeList.Add("-12", "开启自动状态检测失败!");
            errCodeList.Add("-13", "动态算法只支持独立服务器调用.");
            errCodeList.Add("-14", "错误的调用.");
            errCodeList.Add("-15", "频繁调用,请等待10分钟后再做尝试.");
            errCodeList.Add("-16", "接口未开启.");
            errCodeList.Add("-17", "错误的调用方式,请确认后台接口的调用方式.");
            errCodeList.Add("-18", "服务器内部错误,请联系管理员解决.");
            errCodeList.Add("-19", "接口调用失败,调用次数不足.");
            errCodeList.Add("-20", "变量数据不存在.");
            errCodeList.Add("-21", "机器码一样,无需转绑.");
            errCodeList.Add("-23", "此接口开启了强制算法,但是没使用.");
            errCodeList.Add("-101", "用户名填写错误,必须以字母开头6-16位字母或数字!");
            errCodeList.Add("-102", "用户不存在.");
            errCodeList.Add("-103", "请先登陆再调用此方法.");
            errCodeList.Add("-104", "密码填写错误,请输入6-16位密码！.");
            errCodeList.Add("-105", "邮箱填写错误,请正确输入邮箱！.");
            errCodeList.Add("-106", "用户名重复.");
            errCodeList.Add("-107", "邮箱重复.");
            errCodeList.Add("-108", "新密码输入错误.");
            errCodeList.Add("-109", "用户名或密码错误");
            errCodeList.Add("-110", "用户使用时间已到期");
            errCodeList.Add("-111", "用户未在绑定的电脑上登陆.");
            errCodeList.Add("-112", "用户在别的地方登陆.");
            errCodeList.Add("-113", "过期时间有误.");
            errCodeList.Add("-114", "登录数据不存在");
            errCodeList.Add("-115", "用户已被禁用.");
            errCodeList.Add("-116", "密码修改申请过于频繁.");
            errCodeList.Add("-117", "未输入机器码.");
            errCodeList.Add("-118", "重绑次数超过限制.");
            errCodeList.Add("-119", "使用天数不足,重绑失败.");
            errCodeList.Add("-120", "注册失败,注册次数超过限制.");
            errCodeList.Add("-121", "用户机器码不能超过32位.");
            errCodeList.Add("-122", "用户已经被删除");
            errCodeList.Add("-123", "用户密码输入错误");
            errCodeList.Add("-124", "用户登录数达到最大");
            errCodeList.Add("-125", "错误的用户操作类别");
            errCodeList.Add("-126", "过期时间变更记录创建失败");
            errCodeList.Add("-127", "用户充值失败");
            errCodeList.Add("-128", "用户数据超过最大限制");
            errCodeList.Add("-129", "用户被开发者禁止使用,请咨询开发者是否被拉到黑名单");
            errCodeList.Add("-131", "用户使用次数不足");
            errCodeList.Add("-132", "用户使用点数不足");
            errCodeList.Add("-201", "程序不存在");
            errCodeList.Add("-202", "程序密钥输入错误");
            errCodeList.Add("-203", "程序版本号错误");
            errCodeList.Add("-204", "程序版本不存在");
            errCodeList.Add("-205", "用户未申请使用程序");
            errCodeList.Add("-206", "程序版本需要更新");
            errCodeList.Add("-207", "程序版本已停用");
            errCodeList.Add("-208", "程序未开启后台接口功能.(可在“程序”的“修改”界面开启后台接口功能)");
            errCodeList.Add("-209", "程序接口密码错误");
            errCodeList.Add("-210", "程序停止新用户注册");
            errCodeList.Add("-211", "程序不允许用户机器码转绑");
            errCodeList.Add("-301", "卡密输入错误");
            errCodeList.Add("-302", "卡密不存在");
            errCodeList.Add("-303", "卡密已经使用");
            errCodeList.Add("-304", "卡密已经过期");
            errCodeList.Add("-305", "卡密已经冻结");
            errCodeList.Add("-306", "卡密已经退换");
            errCodeList.Add("-308", "卡密已经换卡");
            errCodeList.Add("-401", "单码卡密错误");
            errCodeList.Add("-402", "单码卡密机器码错误");
            errCodeList.Add("-403", "单码卡密IP错误");
            errCodeList.Add("-404", "单码卡密类型错误");
            errCodeList.Add("-405", "单码卡密被禁用");
            errCodeList.Add("-406", "单码卡密不存在");
            errCodeList.Add("-407", "单码卡密未激活");
            errCodeList.Add("-408", "单码卡密已经使用");
            errCodeList.Add("-409", "单码充值卡密错误");
            errCodeList.Add("-410", "单码卡密过期");
            errCodeList.Add("-420", "单码卡密在别的电脑上登录");
            errCodeList.Add("-421", "单码卡密超过最大登录数,如果确定已经下线,请等60分钟后重试");
            errCodeList.Add("-422", "单码IP一样,无需转绑");
            errCodeList.Add("-501", "单码管理信息错误");
            errCodeList.Add("-502", "单码机器码转绑次数超过限制");
            errCodeList.Add("-503", "单码机器码转绑后将过期");
            errCodeList.Add("-504", "单码IP转绑次数超过限制");
            errCodeList.Add("-505", "单码IP转绑后将过期");
            errCodeList.Add("-506", "单码未开启机器码验证,无需转绑.");
            errCodeList.Add("-507", "单码未开启IP地址验证,无需转绑");
            errCodeList.Add("101", "充值成功!填写的推荐人不存在");
            errCodeList.Add("102", "充值成功!填写推荐人获赠时间失败");
            errCodeList.Add("103", "充值成功!添加推荐信息失败");
            errCodeList.Add("104", "充值成功!推荐人获赠时间失败");
            errCodeList.Add("105", "充值成功!充值的卡密类别不支持推荐人功能");
            errCodeList.Add("106", "充值成功!充值的卡密类别推荐功能已关闭");
            errCodeList.Add("107", "充值成功!成功使用推荐功能");
            errCodeList.Add("108", "充值成功!但是填写的推荐人无效");


        }

        public static String getValue(String key)
        {
            try
            {
                String u = errCodeList[key];
                return u;
            }
            catch (KeyNotFoundException ke)
            {
                return null;
            }
        }
    }
}
