using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class New_Recruit_1 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void new_challenge_btn_1_Click(object sender, EventArgs e)
        {
            String type = RadioButtonList1.SelectedValue;
            String select = "1";
            String not_select = "0";
            String Camera = not_select;
            if (is_camera.Checked)
                Camera = select;
            String Public = not_select;
            if (is_public.Checked)
                Public = select;
        }
    }
}