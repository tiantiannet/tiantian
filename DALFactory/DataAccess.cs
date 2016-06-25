using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using MysqlDAL;

namespace DALFactory
{
    /// <summary>
    /// 工厂类
    /// </summary>
    public class DataAccess
    {
        /// <summary>
        /// 获取数据类实体的工厂方法
        /// 完成后请前往IDAL完成数据类实体接口
        /// </summary>
        /// <returns></returns>
        public static IOne GetOne()
        {
            IOne ione = new MysqlDAL.One();
            return ione;
        }

        public static IRegister GetRegister()
        {
            IRegister iRegister = new MysqlDAL.Register();
            return iRegister;
        }
        /// <summary>
        /// 获取一个登录类
        /// </summary>
        /// <returns></returns>
        public static ILogin GetLogin()
        {
            ILogin ilogin = new MysqlDAL.Login();
            return ilogin;
        }

        /// <summary>
        /// 获取一个公司验证信息类
        /// </summary>
        /// <returns></returns>
        public static ICooper_verify GetCooper_verify()
        {
            ICooper_verify iCooper_verify = new MysqlDAL.Cooper_verify();
            return iCooper_verify;
        }

        /// <summary>
        /// 获取一个公司标签类
        /// </summary>
        /// <returns></returns>
        public static IEdit_tag_views GetEdit_tag_views()
        {
            IEdit_tag_views Iedit_tag_views = new MysqlDAL.Edit_tag_views();
            return Iedit_tag_views;
        }

        /// <summary>
        /// 获取一个添加个人信息类
        /// </summary>
        /// <returns></returns>
        public static IEdit_user_info GetEdit_user_info()
        {
            IEdit_user_info Iedit_user_info = new MysqlDAL.Edit_user_info();
            return Iedit_user_info;
        }

        /// <summary>
        /// 获取一个正在进行的挑战类
        /// </summary>
        /// <returns></returns>
        public static IContest GetContest()
        {
            IContest ite = new MysqlDAL.Contest();
            return ite;
        }

    }
}
