using System;
using System.Web;
using System.Collections.Generic;
using BussinessObject;
using BussinessLogic;
using System.Data;
using System.Configuration;

namespace ciforum
{
    public partial class single_topic : System.Web.UI.Page
    {
        ClassBO bo = new ClassBO();
        ClassBL bl = new ClassBL();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public List<BussinessObject.singlepostlist> getsinglepost(string post_id)
        {
            dt = new DataTable();
            dt = bl.getsinglepost(Convert.ToInt32(post_id));
            List<singlepostlist> list = new List<singlepostlist>();
            if (dt.Rows.Count > 0)
            {
                string smtpHost = ConfigurationManager.AppSettings["hostName"];

                foreach (DataRow dr in dt.Rows)
                {
                    singlepostlist itlist = new singlepostlist();
                    itlist.post_id = dr[bo.post_id].ToString();
                    itlist.parent_post_id = dr[bo.parent_post_id].ToString();
                    itlist.sub_parent_post_id = dr[bo.sub_parent_post_id].ToString();
                    itlist.user_id = dr[bo.user_id].ToString();
                    itlist.name = dr[bo.name].ToString();
                    itlist.displayname = dr[bo.displayname].ToString() != null || dr[bo.displayname].ToString().Length > 0 ? dr[bo.displayname].ToString() : dr[bo.name].ToString();
                    itlist.last_editor_display_name = dr[bo.last_editor_display_name].ToString();
                    itlist.post_type_id = dr[bo.post_type_id].ToString();
                    itlist.post_type = dr[bo.post_type].ToString();
                    itlist.title = dr[bo.title].ToString();
                    itlist.tag_type_id = dr[bo.tag_id].ToString();
                    itlist.tag_type = dr[bo.tag_type].ToString();
                    itlist.sub_tags = dr[bo.sub_tags].ToString();
                    itlist.created_date = DateTime.Parse(dr[bo.created_date].ToString()).ToString("dd MMM, yyyy");
                    itlist.body_content = dr[bo.body_content].ToString();
                    itlist.answer_count = dr[bo.answer_count].ToString();
                    itlist.commentcount = dr[bo.comment_count].ToString();
                    itlist.favorite_count = dr[bo.favorite_count].ToString();
                    itlist.view_count = dr[bo.view_count].ToString();
                    itlist.file_name = dr[bo.file_name].ToString() != null && dr[bo.file_name].ToString().Length > 0 ? smtpHost + "/Fileupload/" + dr[bo.file_name].ToString() : dr[bo.file_name].ToString();
                    itlist.upvote = dr[bo.upvote].ToString();
                    itlist.downvote = dr[bo.downvote].ToString();
                    itlist.closed_date = dr[bo.closed_date].ToString();
                    itlist.closed_by = dr[bo.closed_by].ToString();
                    list.Add(itlist);
                }
            }

            return list;
        }

        public string addfavorite(string post_id)
        {
            return (bl.addfavorite(post_id)).ToString();
        }

        public string addvote(voteList list)
        {
            try
            {
                if (HttpContext.Current.Session["uid"] != null && list.voted_by != list.voted_to)
                {
                    list.voted_by = HttpContext.Current.Session["uid"].ToString();
                    return (bl.addvote(list)).ToString();
                }
                else
                    return "0";
            }
            catch (Exception ex)
            {
                return "0";
            }
        }

        [System.Web.Services.WebMethod]
        public static List<BussinessObject.singlepostlist> webgetsinglepost(string code)
        {
            single_topic cl = new single_topic();
            return cl.getsinglepost(code);
        }

        [System.Web.Services.WebMethod]
        public static string webaddfavorite(string code)
        {
            single_topic cl = new single_topic();
            return cl.addfavorite(code);
        }

        [System.Web.Services.WebMethod]
        public static string webaddvote(voteList list)
        {
            single_topic cl = new single_topic();
            return cl.addvote(list);
        }
    }
}