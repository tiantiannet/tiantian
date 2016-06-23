using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 公司标签数据POJO
    /// </summary>
    public class Edit_tag_viewsInfo
    {
        /// <summary>
        /// 公司id
        /// </summary>
        private String username;

        /// <summary>
        /// 公司标签1
        /// </summary>
        private String corp_cont1;
        /// <summary>
        /// 公司标签2
        /// </summary>
        private String corp_cont2;

        /// <summary>
        /// 公司标签3
        /// </summary>
        private String corp_cont3;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="username">公司id</param>
        /// <param name="corpname">公司名</param>
        /// <param name="idphone">招聘人员手机号</param>
        /// <param name="corptelephone">公司电话</param>
        public Edit_tag_viewsInfo(String username, String corp_cont1, String corp_cont2, String corp_cont3)
        {
            this.username = username;
            this.corp_cont1 = corp_cont1;
            this.corp_cont2 = corp_cont2;
            this.corp_cont3 = corp_cont3;
        }

        /// <summary>
        /// username构造器
        /// </summary>
        public String Username
        {
            get { return username; }
            set { username = value; }            
        }
        /// <summary>
        /// corp_cont1构造器
        /// </summary>
        public String Corp_cont1
        {
            get { return corp_cont1; }
            set { corp_cont1 = value; }
        }

        /// <summary>
        /// corp_cont2构造器
        /// </summary>
        public String Corp_cont2
        {
            get { return corp_cont2; }
            set { corp_cont2 = value; }
        }

        /// <summary>
        /// corp_cont3构造器
        /// </summary>
        public String Corp_cont3
        {
            get { return corp_cont3; }
            set { corp_cont3 = value; }
        }
    }
}
