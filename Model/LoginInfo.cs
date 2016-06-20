using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 登录数据POJO
    /// </summary>
    public class LoginInfo
    {
        /// <summary>
        /// 用户名
        /// </summary>
        private String username;

        /// <summary>
        /// 用户密码
        /// </summary>
        private String password;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="password">用户密码</param>
        public LoginInfo(String username, String password)
        {
            this.username = username;
            this.password = password;
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
        /// password构造器
        /// </summary>
        public String Password
        {
            get { return password; }
            set { password = value; }
        }

    }
}
