using System;
using System.Web;
using System.Collections.Generic;
using BussinessObject;
using BussinessLogic;
using System.Data;


namespace ciforum
{
    public partial class dashboard : System.Web.UI.Page
    {
        ClassBO bo = new ClassBO();
        ClassBL bl = new ClassBL();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public List<BussinessObject.masterList> serchmaster()
        {
            dt = new DataTable();
            dt = bl.serchmaster();
            List<masterList> list = new List<masterList>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    masterList itlist = new masterList();
                    itlist.master_type_id = dr[bo.master_id].ToString();
                    itlist.master_type = dr[bo.master_type].ToString();
                    list.Add(itlist);
                }
            }
            return list;
        }

        public List<BussinessObject.userdataList> getuserdata()
        {
            dt = new DataTable();
            int id = Convert.ToInt32(HttpContext.Current.Session["uid"].ToString());
            dt = bl.getuserdata(id);
            List<userdataList> list = new List<userdataList>();
            if (dt.Rows.Count > 0)
            {
                userdataList itlist = new userdataList();
                itlist.user_id = dt.Rows[0][bo.user_id].ToString();
                itlist.user_code = dt.Rows[0][bo.user_code].ToString();
                itlist.name1 = dt.Rows[0][bo.name].ToString();
                itlist.name2 = dt.Rows[0][bo.name2].ToString();
                itlist.user_type = dt.Rows[0][bo.user_type].ToString();
                itlist.type_id = dt.Rows[0][bo.user_type_id].ToString();
                itlist.created_date = DateTime.Parse(dt.Rows[0][bo.created_date].ToString()).ToString("dd MMM, yyyy");
                itlist.description = dt.Rows[0][bo.description].ToString();
                itlist.age = dt.Rows[0][bo.age].ToString();
                itlist.display_name = dt.Rows[0][bo.displayname].ToString();
                itlist.website_url = dt.Rows[0][bo.website].ToString();
                itlist.lastaccessdate = dt.Rows[0][bo.lastaccessdate].ToString().Length > 0 ? DateTime.Parse(dt.Rows[0][bo.lastaccessdate].ToString()).ToString("dd MMM, yyyy") : DateTime.Now.ToString("dd MMM, yyyy");
                itlist.username = dt.Rows[0][bo.username].ToString();
                itlist.login_password = dt.Rows[0][bo.password].ToString();
                itlist.total_bounty = dt.Rows[0][bo.total_bounty].ToString();
                list.Add(itlist);
            }
            return list;
        }

        public List<BussinessObject.contactList> getusercontact()
        {
            dt = new DataTable();
            int id = Convert.ToInt32(HttpContext.Current.Session["uid"].ToString());
            dt = bl.getusercontact(id);
            List<contactList> list = new List<contactList>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    contactList itlist = new contactList();
                    itlist.contact_id = dr[bo.contactid].ToString(); 
                    itlist.master_id = dr[bo.master_id].ToString();
                    itlist.master_type = dr[bo.master_type].ToString();
                    itlist.email = dr[bo.email].ToString();
                    itlist.phone = dr[bo.phone].ToString();
                    itlist.mobile1 = dr[bo.mobile1].ToString();
                    itlist.mobile2 = dr[bo.mobile2].ToString();
                    list.Add(itlist);
                }
            }
            return list;
        }

        public List<BussinessObject.useraddressList> getuseraddress()
        {
            dt = new DataTable();
            int id = Convert.ToInt32(HttpContext.Current.Session["uid"].ToString());
            dt = bl.getuseraddress(id);
            List<useraddressList> list = new List<useraddressList>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    useraddressList itlist = new useraddressList();
                    itlist.address_id = dr[bo.addressid].ToString(); 
                    itlist.master_id = dr[bo.master_id].ToString();
                    itlist.master_type = dr[bo.master_type].ToString();
                    itlist.line1 = dr[bo.line1].ToString();
                    itlist.line2 = dr[bo.line2].ToString();
                    itlist.district = dr[bo.district].ToString();
                    itlist.states = dr[bo.states].ToString();
                    itlist.country = dr[bo.country].ToString();
                    itlist.post_code = dr[bo.post_code].ToString();
                    itlist.affiliation = dr[bo.affiliation].ToString();
                    list.Add(itlist);
                }
            }
            return list;
        }
        
        public int savecontactdetail(contactList list)
        {
            if (HttpContext.Current.Session["uid"] != null)
            {
                string pid= HttpContext.Current.Session["uid"].ToString();
                list.user_id = pid;
                list.id = pid;
                list.status = "1"; 

                return bl.savecontacts(list);
            }
            else
                return 0;
        }

        public int saveaddressdetail(useraddressList list)
        {
            if (HttpContext.Current.Session["uid"] != null)
            {
                string pid = HttpContext.Current.Session["uid"].ToString();
                list.user_id = pid;
                list.id = pid;
                list.status = "1";
                return bl.saveaddressdetail(list);
            }
            else
                return 0;
        }

        public int saveuserdetail(usersList list)
        {
            if (HttpContext.Current.Session["uid"] != null)
            {
                string pid = HttpContext.Current.Session["uid"].ToString();
                list.user_id = pid;
                list.status = "1";
                return bl.savesignup(list);
            }
            else
                return 0;
        }
        

        [System.Web.Services.WebMethod]
        public static List<BussinessObject.masterList> webserchmaster(string code)
        {
            dashboard cl = new dashboard();
            return cl.serchmaster();
        }

        [System.Web.Services.WebMethod]
        public static List<BussinessObject.userdataList> webgetuserdata(string code)
        {
            dashboard cl = new dashboard();
            return cl.getuserdata();
        }

        [System.Web.Services.WebMethod]
        public static List<BussinessObject.contactList> webgetusercontact(string code)
        {
            dashboard cl = new dashboard();
            return cl.getusercontact();
        }

        [System.Web.Services.WebMethod]
        public static List<BussinessObject.useraddressList> webgetuseraddress(string code)
        {
            dashboard cl = new dashboard();
            return cl.getuseraddress();
        }

        [System.Web.Services.WebMethod]
        public static int websavecontactdetail(contactList list)
        {
            dashboard cl = new dashboard();
            return cl.savecontactdetail(list);
        }

        [System.Web.Services.WebMethod]
        public static int websaveaddressdetail(useraddressList list)
        {
            dashboard cl = new dashboard();
            return cl.saveaddressdetail(list);
        }

        [System.Web.Services.WebMethod]
        public static int websaveuserdetail(usersList list)
        {
            dashboard cl = new dashboard();
            return cl.saveuserdetail(list);
        }


    }
}