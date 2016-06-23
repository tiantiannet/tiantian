using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using System.Data;
using DBUtility;
using Model;

namespace MysqlDAL
{
    /// <summary>
    /// 数据提取类
    /// </summary>
    public class Edit_user_info :IEdit_user_info
    {
        /// <summary>
        /// POJO类初始化SQL语句,此处仅针对Mysql
        /// </summary>
        private const String SQL_SELECT_Edit_user_info = "select * from corp where username =  ";

        private const String SQL_UPDATE_Edit_user_info = @"UPDATE corp set username = {0} and userrealyname = {1} 
            and usersex = {2} and userskill = {3} and workWanterStatus = {4} and userWorkprov ={5}";
        /// <summary>
        /// POJO类 
        /// </summary>
        private Edit_user_infoInfo edit_user_infoInfo = null;

        /// <summary>
        /// 初始化数据类实体，填充POJO类
        /// </summary>
        /// <param name="username">初始化索引</param>
        public void Make(String username)
        {
        }

        public void InsertUserInfo(String username, String userrealyname, String userage, String usersex, String userskill, String workWanterStatus, String userWorkprov)
        {
            MySqlDBCore.Execute(String.Format(SQL_UPDATE_Edit_user_info, username, userage,userrealyname, usersex, userskill, workWanterStatus, userWorkprov));
        }

        /// <summary>
        /// 获取用户id
        /// </summary>
        /// <returns>用户id</returns>
        public String getUsername()
        {
            return this.edit_user_infoInfo.Username;
        }

        /// <summary>
        /// 获取用户真实姓名
        /// </summary>
        /// <returns>用户真实姓名</returns>
        public String getUserrealyname()
        {
            return this.edit_user_infoInfo.Userrealyname;
        }

        /// <summary>
        /// 获取用户年龄
        /// </summary>
        /// <returns>用户年龄</returns>
        public String getUserage()
        {
            return this.edit_user_infoInfo.Userage;
        }

        /// <summary>
        /// 获取用户性别
        /// </summary>
        /// <returns>用户性别</returns>
        public String getUsersex()
        {
            return this.edit_user_infoInfo.Usersex;
        }

        /// <summary>
        /// 获取用户技能
        /// </summary>
        /// <returns>用户技能</returns>
        public String getUserskill()
        {
            return this.edit_user_infoInfo.Userskill;
        }

        /// <summary>
        /// 获取用户求职状态
        /// </summary>
        /// <returns>用户求职状态</returns>
        public String getWorkWanterStatus()
        {
            return this.edit_user_infoInfo.WorkWanterStatus;
        }

        /// <summary>
        /// 获取用户工作省份
        /// </summary>
        /// <returns>用户工作省份</returns>
        public String getUserWorkprov()
        {
            return this.edit_user_infoInfo.UserWorkprov;
        }
    }
}
