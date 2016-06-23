using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Web
{
    public partial class Edit_tag_view : System.Web.UI.Page
    {
            /// <summary>
            /// 业务类
            /// </summary>
            BLL.Edit_tag_views edit_tag;

            /// <summary>
            /// 页面加载
            /// </summary>
            /// <param name="sender">系统传参</param>
            /// <param name="e">系统传参</param>
            protected void Page_Load(object sender, EventArgs e)
            {
              //在此构造一个BLL业务类
              this.edit_tag = new BLL.Edit_tag_views();
            }       

            /// <summary>
            /// 增加公司标签事件
            /// </summary>
            /// <param name="sender">系统传参</param>
            /// <param name="e">系统传参</param>
            protected void save_Next_Click(object sender, EventArgs e)
            {
                String corp_cont1;
                String corp_cont2;
                String corp_cont3;
                corp_cont1 = corp_btn1.Text;
                corp_cont2 = corp_btn2.Text;
                corp_cont3 = corp_btn3.Text;
                String username = Session["username"].ToString();
                edit_tag.edit_tag_view(username, corp_cont1, corp_cont2, corp_cont3);
            }   
    }
}