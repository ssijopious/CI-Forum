using System;
using System.Collections.Generic;
using BussinessObject;
using BussinessLogic;
using System.Data;

namespace ciforum
{
    public partial class index : System.Web.UI.Page
    {
        ClassBO bo = new ClassBO();
        ClassBL bl = new ClassBL();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public List<BussinessObject.tagList> serchtag(string code)
        {
            dt = new DataTable();
            dt = bl.serchtag(code);
            List<tagList> list = new List<tagList>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    tagList itlist = new tagList();
                    itlist.tag_type_id = dr[bo.tag_id].ToString();
                    itlist.tag_type = dr[bo.tag_type].ToString();
                    list.Add(itlist);
                }
            }
            return list;
        }

        public List<BussinessObject.postlist> getpostlist(string post_title, int order_by, string tag_type)
        {
            dt = new DataTable();
            dt = bl.getpostlist(post_title, order_by, tag_type);
            List<postlist> list = new List<postlist>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    postlist itlist = new postlist();

                    itlist.post_id = dr[bo.post_id].ToString();
                    itlist.user_id = dr[bo.user_id].ToString();
                    itlist.title = dr[bo.title].ToString();
                    itlist.tag_type_id = dr[bo.tag_id].ToString();
                    itlist.tag_type = dr[bo.tag_type].ToString();
                    itlist.body_content = dr[bo.body_content].ToString();
                    itlist.created_date = dr[bo.created_date].ToString();
                    itlist.closed_date = dr[bo.closed_date].ToString();
                    itlist.view_count = dr[bo.view_count].ToString();
                    itlist.comment_count = dr[bo.comment_count].ToString();
                    itlist.favorite_count = dr[bo.favorite_count].ToString();
                    itlist.last_user_ids = dr[bo.last_user_ids].ToString();
                    itlist.last_user_display_names = dr[bo.last_user_display_names].ToString();
                    itlist.activity = dr[bo.activity].ToString();
                    list.Add(itlist);
                }
            }

            return list;
        }

        public List<BussinessObject.vtbList> tagvoteuser(int user_id, int tag_id)
        {
            dt = new DataTable();
            List<vtbList> list = new List<vtbList>();
            dt = bl.tagvoteuser(tag_id, user_id);
            if (dt.Rows.Count > 0)
            {
                if (tag_id != 0)
                {
                    vtbList itlist = new vtbList();
                    itlist.name1 = dt.Rows[0][bo.name].ToString();
                    itlist.display_name = dt.Rows[0][bo.displayname].ToString() != null || dt.Rows[0][bo.displayname].ToString().Length > 0 ? dt.Rows[0][bo.displayname].ToString() : dt.Rows[0][bo.name].ToString();
                    itlist.created_date = DateTime.Parse(dt.Rows[0][bo.created_date].ToString()).ToString("dd MMM, yyyy");
                    itlist.tag_bounty = dt.Rows[0][bo.tag_bounty].ToString();
                    itlist.total_bounty = dt.Rows[0][bo.total_bounty].ToString();
                    itlist.tag_name = dt.Rows[0][bo.tag_type].ToString();
                    list.Add(itlist);
                }
                else
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        vtbList itlist = new vtbList();
                        itlist.userid = dr[bo.user_id].ToString(); 
                        itlist.name1 = dr[bo.name].ToString();
                        itlist.display_name = dr[bo.displayname].ToString() != null || dr[bo.displayname].ToString().Length > 0 ? dr[bo.displayname].ToString() : dr[bo.name].ToString();
                        itlist.created_date = DateTime.Parse(dr[bo.created_date].ToString()).ToString("dd MMM, yyyy");
                        itlist.tag_bounty = dr[bo.tag_bounty].ToString();
                        itlist.total_bounty = dr[bo.total_bounty].ToString();
                        itlist.tag_name = dr[bo.tag_type].ToString();
                        list.Add(itlist);
                    }
                }
            }

            return list;
        }



        [System.Web.Services.WebMethod]
        public static List<BussinessObject.tagList> webserchtag(string code)
        {
            index cl = new index();
            return cl.serchtag(code);
        }

        [System.Web.Services.WebMethod]
        public static List<BussinessObject.postlist> webgetpostlist(string code)
        {
            index cl = new index();
            string[] postselect = code.Split(',');
            return cl.getpostlist(postselect[0] == "0" || postselect[0].Length < 1 ? null : postselect[0], Convert.ToInt32(postselect[1]), postselect[2] == "0" || postselect[2].Length < 1 ? null : postselect[2]);
        }

        [System.Web.Services.WebMethod]
        public static List<BussinessObject.vtbList> webtagvoteuser(string code)
        {
            index cl = new index();
            string[] vottag = code.Split('_');
            return cl.tagvoteuser(Convert.ToInt32(vottag[0]), Convert.ToInt32(vottag[1]));
        }

    }
}