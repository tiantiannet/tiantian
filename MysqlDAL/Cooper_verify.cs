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
            //查询结果容器
            DataSet record = new DataSet();
            //从索引中补全语句
            MySqlDBCore.Execute(SQL_SELECT_Cooper_verify + "'" + username + "'", ref record);

            //若记录存在，填充POJO
            if (record.Tables.Count != 0 && record.Tables[0].Rows.Count != 0)
            {
                //生成POJO类
                this.cooper_verifyInfo = new Cooper_verifyInfo(username, record.Tables[0].Rows[0]["corpname"].ToString(), record.Tables[0].Rows[0]["idphone"].ToString(), record.Tables[0].Rows[0]["corptelephone"].ToString(), record.Tables[0].Rows[0]["corpweixin"].ToString(), record.Tables[0].Rows[0]["selectprov"].ToString(), record.Tables[0].Rows[0]["selectindustry"].ToString());
            }
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
