﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Web
{
    public partial class Edit_user_info : System.Web.UI.Page
    {
        /// <summary>
        /// 业务类
        /// </summary>
        BLL.Edit_user_info edit_user_info;

        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender">系统传参</param>
        /// <param name="e">系统传参</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            //在此构造一个BLL业务类
            this.edit_user_info = new BLL.Edit_user_info();
        }

        /// <summary>
        /// 增加公司标签事件
        /// </summary>
        /// <param name="sender">系统传参</param>
        /// <param name="e">系统传参</param>
        protected void sub_btn_id_Click(object sender, EventArgs e)
        {
            /*
            String userrealyname;
            String userage;
            String usersex;
            String userskill = "";
            String workWanterStatus;
            String userWorkprov;
            if (Java.Checked == true)
            {
                if (!userskill.Equals(""))
                    userskill += ",";
                userskill += "Java";
            }
            if (Android.Checked == true)
            {
                if (!userskill.Equals(""))
                    userskill += ",";
                userskill += "Android";
            }
            if (iOS.Checked == true)
            {
                if (!userskill.Equals(""))
                    userskill += ",";
                userskill += "iOS";
            }
            if (C.Checked == true)
            {
                if (!userskill.Equals(""))
                    userskill += ",";
                userskill += "C";
            }
            if (Cjiajia.Checked == true)
            {
                if (!userskill.Equals(""))
                    userskill += ",";
                userskill += "C++";
            }
            if (php.Checked == true)
            {
                if (!userskill.Equals(""))
                    userskill += ",";
                userskill += "php";
            }
            if (Python.Checked == true)
            {
                if (!userskill.Equals(""))
                    userskill += ",";
                userskill += "Python";
            }
            userrealyname = corp_name.Text;
            userage = corp_sname.Text;
            usersex = select_sex.Value;
            workWanterStatus = Want_job.Text;
            userWorkprov = select_prov.Value;
            String username = Session["username"].ToString();
            edit_user_info.edit_user_info(username, userrealyname, userage, usersex, userskill, workWanterStatus, userWorkprov);*/
        }

        protected void sub_btn_id_Click1(object sender, EventArgs e)
        {
            Console.Write("asd");
        }
    }
}