using System;
using BussinessObject;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using System.Globalization;

namespace DataAccessLayer
{
    public class ClassDA
    {
        ClassBO bo = new ClassBO();
        OracleConnection con = new OracleConnection();
        OracleCommand cmd = new OracleCommand();
        OracleDataAdapter da = new OracleDataAdapter();
        string connStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        public int avlusername(string username)
        {
            try
            {
                bo = new ClassBO();
                con = new OracleConnection();
                con.ConnectionString = connStr;
                dt = new DataTable();
                using (OracleCommand cmd = new OracleCommand(ClassBO.usernameavl, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(bo.P_username, OracleDbType.Varchar2).Value = username;
                    OracleParameter p2 = new OracleParameter();
                    p2.ParameterName = bo.P_ret;
                    p2.OracleDbType = OracleDbType.RefCursor;
                    p2.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(p2);
                    con.Open();
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    da.Fill(dt);
                    con.Close();
                    con.Dispose();
                    return dt.Rows.Count > 0 ? 1 : 0;
                }
            }
            catch (Exception ex)
            {
                con.Close();
                return 1;
            }
        }

        public int savesignup(usersList list)
        {
            int rowCount = 0;
            try
            {
                bo = new ClassBO();
                con = new OracleConnection();
                con.ConnectionString = connStr;
                using (OracleCommand cmd = new OracleCommand(ClassBO.usersinsupdte, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(bo.P_user_id, OracleDbType.Int64).Value = Convert.ToInt64(list.user_id);
                    cmd.Parameters.Add(bo.P_user_code, OracleDbType.Varchar2).Value = list.user_code;
                    cmd.Parameters.Add(bo.P_name1, OracleDbType.Varchar2).Value = list.name1 != null && list.name1.Trim().Length > 0 ? list.name1 : (object)DBNull.Value;
                    cmd.Parameters.Add(bo.P_name2, OracleDbType.Varchar2).Value = list.name2 != null && list.name2.Trim().Length > 0 ? list.name2 : (object)DBNull.Value;
                    cmd.Parameters.Add(bo.P_user_type, OracleDbType.Int64).Value = list.user_type != null && list.user_type.Trim().Length > 0 ? Convert.ToInt64(list.user_type) : (object)DBNull.Value;
                    cmd.Parameters.Add(bo.P_status, OracleDbType.Int32).Value = Convert.ToInt32(list.status);
                    cmd.Parameters.Add(bo.P_modified_by, OracleDbType.Int64).Value = Convert.ToInt64(list.user_id);
                    cmd.Parameters.Add(bo.P_description, OracleDbType.Varchar2).Value = list.description != null && list.description.Trim().Length > 0 ? list.description : DBNull.Value.ToString();
                    cmd.Parameters.Add(bo.P_age, OracleDbType.Int32).Value = list.age != null ? Convert.ToInt32(list.age) : (object)DBNull.Value;
                    cmd.Parameters.Add(bo.P_display_name, OracleDbType.Varchar2).Value = list.display_name != null && list.display_name.Trim().Length > 0 ? list.display_name : list.name1;
                    cmd.Parameters.Add(bo.P_last_access_date, OracleDbType.Date).Value = DateTime.ParseExact((DateTime.Now).ToString("dd-MM-yyyy"), "dd-MM-yyyy", CultureInfo.InvariantCulture); ;
                    cmd.Parameters.Add(bo.P_reputation, OracleDbType.Int64).Value = DBNull.Value;
                    cmd.Parameters.Add(bo.P_viewers, OracleDbType.Int64).Value = DBNull.Value;
                    cmd.Parameters.Add(bo.P_website_url, OracleDbType.Varchar2).Value = list.website_url != null && list.website_url.Trim().Length > 0 ? list.website_url : DBNull.Value.ToString();
                    cmd.Parameters.Add(bo.P_parent_id, OracleDbType.Int64).Value = DBNull.Value;
                    OracleParameter p1 = new OracleParameter();
                    p1.ParameterName = bo.P_ret;
                    p1.OracleDbType = OracleDbType.Int64;
                    p1.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(p1);
                    con.Open();
                    rowCount = cmd.ExecuteNonQuery();
                    con.Close();
                    con.Dispose();
                    return Convert.ToInt32(p1.Value.ToString()); ;
                }
            }
            catch (Exception ex)
            {
                con.Close();
                return rowCount;
            }
        }

        public int savelogincredentials(logincredentialsList list)
        {
            int rowCount = 0;
            try
            {
                bo = new ClassBO();
                con = new OracleConnection();
                con.ConnectionString = connStr;
                using (OracleCommand cmd = new OracleCommand(ClassBO.logininsupdte, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(bo.P_login_credential_id, OracleDbType.Int64).Value = Convert.ToInt64(list.login_credential_id);
                    cmd.Parameters.Add(bo.P_user_id, OracleDbType.Int64).Value = Convert.ToInt64(list.user_id);
                    cmd.Parameters.Add(bo.P_username, OracleDbType.Varchar2).Value = list.username;
                    cmd.Parameters.Add(bo.P_login_password, OracleDbType.Varchar2).Value = list.login_password;
                    cmd.Parameters.Add(bo.P_valid_till, OracleDbType.Date).Value = DateTime.ParseExact((DateTime.Now).ToString("dd-MM-yyyy"), "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    cmd.Parameters.Add(bo.P_status, OracleDbType.Int32).Value = Convert.ToInt32(list.status);
                    cmd.Parameters.Add(bo.P_id, OracleDbType.Int32).Value = Convert.ToInt64(list.id);
                    OracleParameter p1 = new OracleParameter();
                    p1.ParameterName = bo.P_ret;
                    p1.OracleDbType = OracleDbType.Int64;
                    p1.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(p1);
                    con.Open();
                    rowCount = cmd.ExecuteNonQuery();
                    con.Close();
                    con.Dispose();
                    return Convert.ToInt32(p1.Value.ToString()); ;
                }
            }
            catch (Exception ex)
            {
                con.Close();
                return rowCount;
            }
        }

        public int savecontacts(contactList list)
        {
            int rowCount = 0;
            try
            {
                bo = new ClassBO();
                con = new OracleConnection();
                con.ConnectionString = connStr;
                using (OracleCommand cmd = new OracleCommand(ClassBO.contactinsupdte, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(bo.P_contact_id, OracleDbType.Int64).Value = list.contact_id != null && list.contact_id.Length > 0 ? Convert.ToInt64(list.contact_id) : 0;
                    cmd.Parameters.Add(bo.P_user_id, OracleDbType.Int64).Value = Convert.ToInt64(list.user_id);
                    cmd.Parameters.Add(bo.P_email, OracleDbType.Varchar2).Value = list.email;
                    cmd.Parameters.Add(bo.P_phone, OracleDbType.Int64).Value = list.phone != null && list.phone.Trim().Length > 0 ? Convert.ToInt64(list.phone) : (object)DBNull.Value;
                    cmd.Parameters.Add(bo.P_mobile1, OracleDbType.Int64).Value = list.mobile1 != null && list.mobile1.Trim().Length > 0 ? Convert.ToInt64(list.mobile1) : (object)DBNull.Value;
                    cmd.Parameters.Add(bo.P_mobile2, OracleDbType.Int64).Value = list.mobile2 != null && list.mobile2.Trim().Length > 0 ? Convert.ToInt64(list.mobile2) : (object)DBNull.Value;
                    cmd.Parameters.Add(bo.P_master_type, OracleDbType.Int64).Value = Convert.ToInt64(list.master_type);
                    cmd.Parameters.Add(bo.P_status, OracleDbType.Int32).Value = Convert.ToInt32(list.status);
                    cmd.Parameters.Add(bo.P_id, OracleDbType.Int64).Value = Convert.ToInt64(list.id);
                    OracleParameter p1 = new OracleParameter();
                    p1.ParameterName = bo.P_ret;
                    p1.OracleDbType = OracleDbType.Int64;
                    p1.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(p1);
                    con.Open();
                    rowCount = cmd.ExecuteNonQuery();
                    con.Close();
                    con.Dispose();
                    return Convert.ToInt32(p1.Value.ToString()); ;
                }
            }
            catch (Exception ex)
            {
                con.Close();
                return rowCount;
            }
        }

        public DataTable serchtag(string code)
        {
            try
            {
                bo = new ClassBO();
                con.ConnectionString = connStr;
                dt = new DataTable();
                using (OracleCommand cmd = new OracleCommand(ClassBO.tagselect, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(bo.P_tag_type_id, OracleDbType.Int32).Value = DBNull.Value;
                    cmd.Parameters.Add(bo.P_tag_type, OracleDbType.Varchar2).Value = code;
                    cmd.Parameters.Add(bo.P_status, OracleDbType.Int32).Value = 1;
                    OracleParameter p2 = new OracleParameter();
                    p2.ParameterName = "ecur";
                    p2.OracleDbType = OracleDbType.RefCursor;
                    p2.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(p2);
                    con.Open();
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    da.Fill(dt);
                    con.Close();
                    con.Dispose();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                con.Close();
                return null;
            }
        }

        public DataTable serchmaster()
        {
            try
            {
                bo = new ClassBO();
                con.ConnectionString = connStr;
                dt = new DataTable();
                using (OracleCommand cmd = new OracleCommand(ClassBO.masterselect, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(bo.P_master_type_id, OracleDbType.Int32).Value = DBNull.Value;
                    cmd.Parameters.Add(bo.P_master_type, OracleDbType.Varchar2).Value = DBNull.Value;
                    cmd.Parameters.Add(bo.P_status, OracleDbType.Int32).Value = DBNull.Value;
                    OracleParameter p2 = new OracleParameter();
                    p2.ParameterName = "ecur";
                    p2.OracleDbType = OracleDbType.RefCursor;
                    p2.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(p2);
                    con.Open();
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    da.Fill(dt);
                    con.Close();
                    con.Dispose();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                con.Close();
                return null;
            }
        }

        public DataTable getpostlist(string post_title, int order_by, string tag_type)
        {
            try
            {
                bo = new ClassBO();
                con.ConnectionString = connStr;
                dt = new DataTable();
                using (OracleCommand cmd = new OracleCommand(ClassBO.postlistselect, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(bo.P_tag_type, OracleDbType.Varchar2).Value = tag_type == null ? DBNull.Value.ToString() : tag_type;
                    cmd.Parameters.Add(bo.P_order_by, OracleDbType.Int32).Value = order_by;
                    cmd.Parameters.Add(bo.P_title, OracleDbType.NVarchar2).Value = post_title == null ? DBNull.Value.ToString() : post_title;
                    OracleParameter p2 = new OracleParameter();
                    p2.ParameterName = "ecur";
                    p2.OracleDbType = OracleDbType.RefCursor;
                    p2.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(p2);
                    con.Open();
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    da.Fill(dt);
                    con.Close();
                    con.Dispose();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                con.Close();
                return null;
            }
        }

        public int savenewpost(newpostlist list)
        {
            int rowCount = 0;
            try
            {
                bo = new ClassBO();
                con = new OracleConnection();
                con.ConnectionString = connStr;
                using (OracleCommand cmd = new OracleCommand(ClassBO.postinsupdte, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(bo.P_post_id, OracleDbType.Int64).Value = Convert.ToInt64(list.post_id);
                    cmd.Parameters.Add(bo.P_post_type_id, OracleDbType.Int64).Value = Convert.ToInt64(list.post_type_id);
                    cmd.Parameters.Add(bo.P_parent_post_id, OracleDbType.Int64).Value = list.parent_post_id != "0" || list.parent_post_id != "" ? Convert.ToInt64(list.parent_post_id) : (object)DBNull.Value;
                    cmd.Parameters.Add(bo.P_user_id, OracleDbType.Int64).Value = Convert.ToInt64(list.user_id);
                    cmd.Parameters.Add(bo.P_title, OracleDbType.NVarchar2).Value = list.title;
                    cmd.Parameters.Add(bo.P_tag_type_id, OracleDbType.Int64).Value = Convert.ToInt64(list.tag_type_id);
                    cmd.Parameters.Add(bo.P_sub_tags, OracleDbType.NVarchar2).Value = list.sub_tags;
                    cmd.Parameters.Add(bo.P_body_content, OracleDbType.NVarchar2).Value = list.body_content;
                    cmd.Parameters.Add(bo.P_view_count, OracleDbType.Int64).Value = list.view_count != null ? Convert.ToInt32(list.view_count) : (object)DBNull.Value;
                    cmd.Parameters.Add(bo.P_last_activity_date, OracleDbType.Date).Value = (DateTime.ParseExact((DateTime.Now).ToString("dd-MM-yyyy"), "dd-MM-yyyy", CultureInfo.InvariantCulture));
                    cmd.Parameters.Add(bo.P_last_edited_date, OracleDbType.Date).Value = list.last_edited_date != null ? (DateTime.ParseExact((DateTime.Now).ToString("dd-MM-yyyy"), "dd-MM-yyyy", CultureInfo.InvariantCulture)) : (object)DBNull.Value;
                    cmd.Parameters.Add(bo.P_last_editor_user_id, OracleDbType.Int64).Value = Convert.ToInt64(list.user_id);
                    cmd.Parameters.Add(bo.P_last_editor_display_name, OracleDbType.Varchar2).Value = list.last_editor_display_name;
                    cmd.Parameters.Add(bo.P_favorite_count, OracleDbType.Int64).Value = Convert.ToInt64(list.favorite_count);
                    cmd.Parameters.Add(bo.P_accepted_answer_id, OracleDbType.Int64).Value = Convert.ToInt64(list.accepted_answer_id);
                    cmd.Parameters.Add(bo.P_answer_count, OracleDbType.Int64).Value = Convert.ToInt64(list.answer_count);
                    cmd.Parameters.Add(bo.P_closed_date, OracleDbType.Date).Value = list.closed_date != null ? (DateTime.ParseExact((DateTime.Now).ToString("dd-MM-yyyy"), "dd-MM-yyyy", CultureInfo.InvariantCulture)) : (object)DBNull.Value;
                    cmd.Parameters.Add(bo.P_commentcount, OracleDbType.Int64).Value = Convert.ToInt64(list.comment_count);
                    cmd.Parameters.Add(bo.P_closed_by, OracleDbType.Int64).Value = Convert.ToInt64(list.closed_by);
                    cmd.Parameters.Add(bo.P_file_name, OracleDbType.NVarchar2).Value = list.file_name;
                    cmd.Parameters.Add(bo.P_sub_parent_post, OracleDbType.Int64).Value = (object)DBNull.Value;
                    OracleParameter p1 = new OracleParameter();
                    p1.ParameterName = bo.P_ret;
                    p1.OracleDbType = OracleDbType.Int64;
                    p1.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(p1);
                    con.Open();
                    rowCount = cmd.ExecuteNonQuery();
                    con.Close();
                    con.Dispose();
                    return Convert.ToInt32(p1.Value.ToString()); ;
                }
            }
            catch (Exception ex)
            {
                con.Close();
                return rowCount;
            }
        }

        public DataTable getsinglepost(int post_id)
        {
            try
            {
                bo = new ClassBO();
                con.ConnectionString = connStr;
                dt = new DataTable();
                using (OracleCommand cmd = new OracleCommand(ClassBO.singlepostselect, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(bo.P_post_id, OracleDbType.Int64).Value = post_id;
                    OracleParameter p2 = new OracleParameter();
                    p2.ParameterName = "ecur";
                    p2.OracleDbType = OracleDbType.RefCursor;
                    p2.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(p2);
                    con.Open();
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    da.Fill(dt);
                    con.Close();
                    con.Dispose();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                con.Close();
                return null;
            }
        }

        public string addfavorite(string post_id)
        {
            int rowCount = 0;
            try
            {
                bo = new ClassBO();
                con = new OracleConnection();
                con.ConnectionString = connStr;
                using (OracleCommand cmd = new OracleCommand(ClassBO.favoriteadd, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(bo.P_post_id, OracleDbType.Int64).Value = Convert.ToInt64(post_id);
                    con.Open();
                    rowCount = cmd.ExecuteNonQuery();
                    con.Close();
                    con.Dispose();
                    return rowCount.ToString();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                return rowCount.ToString();
            }
        }

        public string addvote(voteList list)
        {
            int rowCount = 0;
            try
            {
                bo = new ClassBO();
                con = new OracleConnection();
                con.ConnectionString = connStr;
                using (OracleCommand cmd = new OracleCommand(ClassBO.voteadd, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(bo.P_voted_by, OracleDbType.Int64).Value = Convert.ToInt64(list.voted_by);
                    cmd.Parameters.Add(bo.P_voted_to, OracleDbType.Int64).Value = Convert.ToInt64(list.voted_to);
                    cmd.Parameters.Add(bo.P_vote_type_id, OracleDbType.Int64).Value = Convert.ToInt64(list.vote_type_id);
                    cmd.Parameters.Add(bo.P_post_id, OracleDbType.Int64).Value = Convert.ToInt64(list.post_id);
                    cmd.Parameters.Add(bo.P_tag_type_id, OracleDbType.Int64).Value = Convert.ToInt64(list.tag_type_id);
                    cmd.Parameters.Add(bo.P_status, OracleDbType.Int32).Value = 1;
                    cmd.Parameters.Add(bo.P_id, OracleDbType.Int64).Value = Convert.ToInt64(list.voted_by);
                    OracleParameter p1 = new OracleParameter();
                    p1.ParameterName = bo.P_ret;
                    p1.OracleDbType = OracleDbType.Int64;
                    p1.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(p1);
                    con.Open();
                    rowCount = cmd.ExecuteNonQuery();
                    con.Close();
                    con.Dispose();
                    return p1.Value.ToString();//rowCount.ToString();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                return rowCount.ToString();
            }
        }

        public DataTable loginclick(string username, string password)
        {
            try
            {
                bo = new ClassBO();
                con.ConnectionString = connStr;
                dt = new DataTable();
                using (OracleCommand cmd = new OracleCommand(ClassBO.logincheck, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(bo.P_username, OracleDbType.Varchar2).Value = username;
                    cmd.Parameters.Add(bo.P_login_password, OracleDbType.Varchar2).Value = password;
                    OracleParameter p2 = new OracleParameter();
                    p2.ParameterName = bo.P_ret;
                    p2.OracleDbType = OracleDbType.RefCursor;
                    p2.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(p2);
                    con.Open();
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    da.Fill(dt);
                    con.Close();
                    con.Dispose();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                con.Close();
                return null;
            }
        }

        public DataTable tagvoteuser(int tag_id, int user_id)
        {
            try
            {
                bo = new ClassBO();
                con.ConnectionString = connStr;
                dt = new DataTable();
                using (OracleCommand cmd = new OracleCommand(ClassBO.tagvoteuser, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(bo.P_tag_type_id, OracleDbType.Int64).Value = tag_id==0? (object)DBNull.Value: tag_id;
                    cmd.Parameters.Add(bo.P_user_id, OracleDbType.Int64).Value = user_id == 0 ? (object)DBNull.Value : user_id;
                    OracleParameter p2 = new OracleParameter();
                    p2.ParameterName = bo.P_ret;
                    p2.OracleDbType = OracleDbType.RefCursor;
                    p2.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(p2);
                    con.Open();
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    da.Fill(dt);
                    con.Close();
                    con.Dispose();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                con.Close();
                return null;
            }
        }

        public DataTable getuserdata(int id)
        {
            try
            {
                bo = new ClassBO();
                con.ConnectionString = connStr;
                dt = new DataTable();
                using (OracleCommand cmd = new OracleCommand(ClassBO.userdataselect, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(bo.P_user_id, OracleDbType.Int32).Value = id;
                    OracleParameter p2 = new OracleParameter();
                    p2.ParameterName = "ecur";
                    p2.OracleDbType = OracleDbType.RefCursor;
                    p2.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(p2);
                    con.Open();
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    da.Fill(dt);
                    con.Close();
                    con.Dispose();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                con.Close();
                return null;
            }
        }

        public DataTable getusercontact(int id)
        {
            try
            {
                bo = new ClassBO();
                con.ConnectionString = connStr;
                dt = new DataTable();
                using (OracleCommand cmd = new OracleCommand(ClassBO.usercontactselect, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(bo.P_user_id, OracleDbType.Int32).Value = id;
                    OracleParameter p2 = new OracleParameter();
                    p2.ParameterName = "ecur";
                    p2.OracleDbType = OracleDbType.RefCursor;
                    p2.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(p2);
                    con.Open();
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    da.Fill(dt);
                    con.Close();
                    con.Dispose();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                con.Close();
                return null;
            }
        }

        public DataTable getuseraddress(int id)
        {
            try
            {
                bo = new ClassBO();
                con.ConnectionString = connStr;
                dt = new DataTable();
                using (OracleCommand cmd = new OracleCommand(ClassBO.useraddressselect, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(bo.P_user_id, OracleDbType.Int32).Value = id;
                    OracleParameter p2 = new OracleParameter();
                    p2.ParameterName = "ecur";
                    p2.OracleDbType = OracleDbType.RefCursor;
                    p2.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(p2);
                    con.Open();
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    da.Fill(dt);
                    con.Close();
                    con.Dispose();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                con.Close();
                return null;
            }
        }

        public int saveaddressdetail(useraddressList list)
        {
            int rowCount = 0;
            try
            {
                bo = new ClassBO();
                con = new OracleConnection();
                con.ConnectionString = connStr;
                using (OracleCommand cmd = new OracleCommand(ClassBO.useraddressinsupdte, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(bo.P_address_id, OracleDbType.Int64).Value = list.address_id != null || list.address_id.Length > 0 ? Convert.ToInt64(list.address_id) : 0;
                    cmd.Parameters.Add(bo.P_user_id, OracleDbType.Int64).Value = Convert.ToInt64(list.user_id);
                    cmd.Parameters.Add(bo.P_line1, OracleDbType.Varchar2).Value = list.line1;
                    cmd.Parameters.Add(bo.P_line2, OracleDbType.Varchar2).Value = list.line2 == null || list.line2.Trim().Length < 1 ? (object)DBNull.Value : list.line2;
                    cmd.Parameters.Add(bo.P_district, OracleDbType.Varchar2).Value = list.district == null || list.district.Trim().Length < 1 ? (object)DBNull.Value : list.district;
                    cmd.Parameters.Add(bo.P_states, OracleDbType.Varchar2).Value = list.states == null || list.states.Trim().Length < 1 ? (object)DBNull.Value : list.states;
                    cmd.Parameters.Add(bo.P_country, OracleDbType.Varchar2).Value = list.country == null || list.country.Trim().Length < 1 ? (object)DBNull.Value : list.country;
                    cmd.Parameters.Add(bo.P_postcode, OracleDbType.Varchar2).Value = list.post_code == null || list.post_code.Trim().Length < 1 ? (object)DBNull.Value : list.post_code;
                    cmd.Parameters.Add(bo.P_master_type, OracleDbType.Int64).Value = Convert.ToInt64(list.master_type);
                    cmd.Parameters.Add(bo.P_affiliation, OracleDbType.Varchar2).Value = list.affiliation == null || list.affiliation.Trim().Length < 1 ? (object)DBNull.Value : list.affiliation;
                    cmd.Parameters.Add(bo.P_status, OracleDbType.Int32).Value = Convert.ToInt32(list.status);
                    cmd.Parameters.Add(bo.P_id, OracleDbType.Int64).Value = Convert.ToInt64(list.id);
                    OracleParameter p1 = new OracleParameter();
                    p1.ParameterName = bo.P_ret;
                    p1.OracleDbType = OracleDbType.Int64;
                    p1.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(p1);
                    con.Open();
                    rowCount = cmd.ExecuteNonQuery();
                    con.Close();
                    con.Dispose();
                    return Convert.ToInt32(p1.Value.ToString()); ;
                }
            }
            catch (Exception ex)
            {
                con.Close();
                return rowCount;
            }
        }

    }
}
