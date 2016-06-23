using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALFactory;
using IDAL;

namespace BLL
{
    public class Edit_tag_views
    {
        //获取数据类
        IEdit_tag_views dal = DALFactory.DataAccess.GetEdit_tag_views();

        /// <summary>
        /// 构造函数
        /// </summary>
        public Edit_tag_views()
        {
        }

        /// <summary>
        /// 增加公司标签类
        /// </summary>
        /// <param name="username">公司id</param>
        /// <param name="corp_cont1">公司标签1</param>
        /// <param name="corp_cont2">公司标签2</param>
        /// <param name="corp_cont3">公司标签3</param>
        /// <returns></returns>
        public String edit_tag_view(String username,String corp_cont1, String corp_cont2, String corp_cont3)
        {
            dal.InsertCorpCont(username,corp_cont1, corp_cont2, corp_cont3);
            if (dal.getUsername() == username && dal.getCorp_cont1() == corp_cont1 && dal.getCorp_cont2() == corp_cont2 && dal.getCorp_cont2() == corp_cont3)
            {
                return "success";
            }
            else return "fail";
        
        }
    }
}
