﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web
{
    public class BasePage : System.Web.UI.Page
    {
        public BasePage()
        {
            this.Load += new EventHandler(BasePage_Load);
        }

        void BasePage_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] == null)
            {
                Response.Redirect("LoginWeb.aspx");
            }
        }
    }

}