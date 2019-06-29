using System;
using System.Web;
using BussinessObject;
using BussinessLogic;


namespace ciforum
{
    public partial class signup : System.Web.UI.Page
    {
        ClassBO bo = new ClassBO();
        ClassBL bl = new ClassBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpContext.Current.Session["uid"] = "";
            HttpContext.Current.Session["un"] = "";
            HttpContext.Current.Session["ut"] = "";
        }

        public string savesignup(signupList list)
        {
            int uid = 0;
            string retval = "";
            try
            {

                bl = new ClassBL();
                usersList usersList = new usersList();
                usersList.user_id = list.userid.Trim().Length > 0 ? list.userid : "0";
                usersList.user_code = (list.firstname).Substring(0, 3) + (list.mobile).Substring(0, 2);
                usersList.name1 = list.firstname;
                usersList.name2 = list.lastname;
                usersList.user_type = "2";
                usersList.status = "1";
                usersList.display_name = list.firstname;
                uid = bl.savesignup(usersList); 
                retval = uid.ToString();
                if (uid > 0)
                {
                    int pid = 0;
                    logincredentialsList logincredentialsList = new logincredentialsList();
                    logincredentialsList.login_credential_id = list.loginid.Trim().Length > 0 ? list.loginid : "0"; ;
                    logincredentialsList.user_id = uid.ToString();
                    logincredentialsList.username = list.username;
                    logincredentialsList.login_password = list.password;
                    logincredentialsList.valid_till = null;
                    logincredentialsList.status = "1";
                    logincredentialsList.id = uid.ToString();
                    pid = bl.savelogincredentials(logincredentialsList);
                    retval = retval + "," + pid.ToString();
                }
                if (uid > 0)
                {
                    int cid = 0;
                    contactList contactList = new contactList();
                    contactList.contact_id = list.contactid.Trim().Length > 0 ? list.contactid : "0"; ;
                    contactList.user_id = uid.ToString();
                    contactList.email = list.email;
                    contactList.phone = "";
                    contactList.mobile1 = list.mobile;
                    contactList.mobile2 = "";
                    contactList.master_type = "1";
                    contactList.status = "1";
                    contactList.id = uid.ToString();
                    cid = bl.savecontacts(contactList);
                    retval = retval + "," + cid.ToString();
                }

                return retval;
            }
            catch (Exception ex)
            {
                return retval;
            }
        }

        public int avlusername(signupList list)
        {
            return bl.avlusername(list.username);
        }


        [System.Web.Services.WebMethod]
        public static string websavesignup(signupList list)
        {
            signup cl = new signup();
            return cl.savesignup(list);
        }

        [System.Web.Services.WebMethod]
        public static int webavlusername(signupList list)
        {
            signup cl = new signup();
            return cl.avlusername(list);
        }


    }
}