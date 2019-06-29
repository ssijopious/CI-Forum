using System;
using BussinessObject;
using BussinessLogic;
using System.Web;
using System.IO;

namespace ciforum
{
    public partial class create_topic : System.Web.UI.Page
    {
        ClassBO bo = new ClassBO();
        ClassBL bl = new ClassBL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public int savenewpost(newpostlist list)
        {
            if (HttpContext.Current.Session["uid"] != null)
            {
                list.user_id = HttpContext.Current.Session["uid"].ToString();
                return bl.savenewpost(list);
            }
            else
                return 0;
        }

        [System.Web.Services.WebMethod]
        public static int websavenewpost(newpostlist list)
        {
            create_topic cl = new create_topic();
            return cl.savenewpost(list);
        }

    }
}