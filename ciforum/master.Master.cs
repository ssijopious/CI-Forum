using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ciforum
{
    public partial class master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string getuser()
        {
            try
            {
                if (HttpContext.Current.Session["uid"] != null)
                    return HttpContext.Current.Session["un"].ToString();
                else
                    return "No Data";
            }
            catch (Exception ex)
            {
                return "No Data";
            }
        }


    }
}