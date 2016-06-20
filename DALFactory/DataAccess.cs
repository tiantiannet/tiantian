using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using MysqlDAL;

namespace DALFactory
{
    /// <summary>
    /// 工厂类
    /// </summary>
    public class DataAccess
    {
        /// <summary>
        /// 获取数据类实体的工厂方法
        /// 完成后请前往IDAL完成数据类实体接口
        /// </summary>
        /// <returns></returns>
        public static IOne GetOne()
        {
            IOne ione = new MysqlDAL.One();
            return ione;
        }

        /// <summary>
        /// 获取一个登录类
        /// </summary>
        /// <returns></returns>
        public static ILogin GetLogin()
        {
            ILogin ilogin = new MysqlDAL.Login();
            return ilogin;
        }
    }
}
