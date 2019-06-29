using System;
using System.Web;
using BussinessObject;
using BussinessLogic;
using System.Data;

namespace ciforum
{
    public partial class login : System.Web.UI.Page
    {
        ClassBO bo = new ClassBO();
        ClassBL bl = new ClassBL();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpContext.Current.Session["uid"] = "";
            HttpContext.Current.Session["un"] = "";
            HttpContext.Current.Session["ut"] = "";
        }

        public int loginclick(string username, string password)
        {
            dt = new DataTable();
            int ret = 0;
            string test = "";
            dt = bl.loginclick(username, password);
            if (dt.Rows.Count > 0)
            {
                test = dt.Rows[0][bo.user_id].ToString();
                HttpContext.Current.Session["uid"] = dt.Rows[0][bo.user_id].ToString();
                HttpContext.Current.Session["un"] = dt.Rows[0][bo.name].ToString();
                HttpContext.Current.Session["ut"] = dt.Rows[0][bo.user_type].ToString();
                ret = 1;
            }

            return ret;
        }

        [System.Web.Services.WebMethod]
        public static int webloginclick(string code)
        {
            string[] login = code.Split(',');
            login cl = new login();
            return cl.loginclick(login[0], login[1]);
        }

        [System.Web.Services.WebMethod]
        public static string webgetuser(string code)
        {
            master cl = new master();
            return cl.getuser();
        }

    }
}