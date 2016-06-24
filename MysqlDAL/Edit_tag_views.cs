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
    public class Edit_tag_views : IEdit_tag_views
    {
        /// <summary>
        /// POJO类初始化SQL语句,此处仅针对Mysql
        /// </summary>
        private const String SQL_SELECT_Edit_tag_views = "select * from corp where username =  ";

        private const String SQL_UPDATE_Edit_tag_views = @"UPDATE corp set username = {0} and corp_cont = {1}";
        /// <summary>
        /// POJO类 
        /// </summary>
        private Edit_tag_viewsInfo edit_tag_viewsInfo = null;

        /// <summary>
        /// 初始化数据类实体，填充POJO类
        /// </summary>
        /// <param name="corpname">初始化索引</param>
        public void Make(String username)
        {
        }

        public void InsertCorpCont(String username, String corp_cont)
        {
            MySqlDBCore.Execute(String.Format(SQL_UPDATE_Edit_tag_views, username, corp_cont));
        }
        /// <summary>
        /// 获取公司id
        /// </summary>
        /// <returns>公司id</returns>
        public String getUsername()
        {
            return this.edit_tag_viewsInfo.Username;
        }

        /// <summary>
        /// 获取公司标签
        /// </summary>
        /// <returns>公司标签</returns>
        public String getCorp_cont()
        {
            return this.edit_tag_viewsInfo.Corp_cont;
        }
    }
}
