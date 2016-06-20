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
    public class Cooper_verify : ICooper_verify
    {
        /// <summary>
        /// POJO类初始化SQL语句,此处仅针对Mysql
        /// </summary>
        private const String SQL_SELECT_Cooper_verify = "select * from corp where username =  ";

        private const String SQL_UPDATE_Cooper_verify = @"UPDATE corp set username = {0} and corpname = {1} 
            and idphone = {2} and corptelephone = {3} and corpweixin = {4} and selectprov ={5} and selectindustry = {6}";
        /// <summary>
        /// POJO类 
        /// </summary>
        private Cooper_verifyInfo cooper_verifyInfo = null;

        /// <summary>
        /// 初始化数据类实体，填充POJO类
        /// </summary>
        /// <param name="corpname">初始化索引</param>
        public void Make(String username)
        {
        }

        public void InsertCorp(String username,String corpname, String idphone, 
            String corptelephone, String corpweixin, String selectprov, String selectindustry)
        {
            MySqlDBCore.Execute(String.Format(SQL_UPDATE_Cooper_verify, username, corpname, corptelephone, idphone,corpweixin, selectprov, selectindustry)); 
        }
        /// <summary>
        /// 获取公司id
        /// </summary>
        /// <returns>公司id</returns>
        public String getUsername()
        {
            return this.cooper_verifyInfo.Username;
        }

        /// <summary>
        /// 获取公司名
        /// </summary>
        /// <returns>公司名</returns>
        public String getCorpname()
        {
            return this.cooper_verifyInfo.Corpname;
        }

        /// <summary>
        /// 获取招聘人员手机号
        /// </summary>
        /// <returns>公司id</returns>
        public String getIdphone()
        {
            return this.cooper_verifyInfo.Idphone;
        }

        /// <summary>
        /// 获取公司电话
        /// </summary>
        /// <returns>公司电话</returns>
        public String getCorptelephone()
        {
            return this.cooper_verifyInfo.Corptelephone;
        }

        /// <summary>
        /// 获取公司微信
        /// </summary>
        /// <returns>公司微信</returns>
        public String getCorpweixin()
        {
            return this.cooper_verifyInfo.Corpweixin;
        }

        /// <summary>
        /// 获取公司所在省份
        /// </summary>
        /// <returns>公司所在省份</returns>
        public String getSelectprov()
        {
            return this.cooper_verifyInfo.Selectprov;
        }

        /// <summary>
        /// 获取公司行业
        /// </summary>
        /// <returns>公司行业</returns>
        public String getSelectindustry()
        {
            return this.cooper_verifyInfo.Selectindustry;
        }
    }
}
