namespace BussinessObject
{
    public class ClassBO
    {
        public string tag_id = "TAG_TYPE_ID";
        public string tag_type = "TAG_TYPE";
        public string master_id = "MASTER_TYPE_ID";
        public string master_type = "MASTER_TYPE";
        public string sub_tags = "SUB_TAGS";
        public string post_id = "POST_ID";
        public string parent_post_id = "PARENT_POST_ID";
        public string sub_parent_post_id = "SUB_PARENT_POST_ID";
        public string post_type_id = "POST_TYPE_ID";
        public string post_type = "POST_TYPE";
        public string user_id = "USER_ID";
        public string user_code = "USER_CODE";
        public string name = "NAME1";
        public string name2 = "NAME2";
        public string description = "DESCRIPTION";
        public string age = "AGE";
        public string user_type = "USER_TYPE";
        public string user_type_id = "USER_TYPE_ID";
        public string displayname = "DISPLAY_NAME";
        public string website = "WEBSITE_URL";
        public string username = "USERNAME";
        public string password = "LOGIN_PASSWORD";
        public string title = "TITLE";
        public string body_content = "BODY_CONTENT";
        public string created_date = "CREATED_DATE";
        public string lastaccessdate = "LAST_ACCESS_DATE";
        public string closed_date = "CLOSED_DATE";
        public string closed_by = "CLOSED_BY";
        public string view_count = "VIEW_COUNT";
        public string answer_count = "ANSWER_COUNT";
        public string comment_count = "COMMENTCOUNT";
        public string favorite_count = "FAVORITE_COUNT";
        public string last_user_ids = "LATEST_USER_ID";
        public string last_editor_display_name = "LAST_EDITOR_DISPLAY_NAME";
        public string last_user_display_names = "LATEST_USER_DISPLAY_NAME";
        public string activity = "ACTIVITY";
        public string file_name = "FILE_NAME";
        public string upvote = "UPVOTE";
        public string downvote = "DOWNVOTE";
        public string tag_bounty = "TAG_BOUNTY";
        public string total_bounty = "TOTAL_BOUNTY";
        public string email = "EMAIL";
        public string phone = "PHONE";
        public string mobile1 = "MOBILE1";
        public string mobile2 = "MOBILE2";
        public string line1 = "LINE1";
        public string line2 = "LINE2";
        public string district = "DISTRICT";
        public string states = "STATES";
        public string country = "COUNTRY";
        public string post_code = "POST_CODE";
        public string affiliation = "AFFILIATION";
        public string contactid = "CONTACT_ID";
        public string addressid = "ADDRESS_ID"; 

        //Procedures
        public static string usersinsupdte = "PROC_USERS_INSUPDTE";
        public static string logininsupdte = "PROC_LOGIN_CRED_INSUPDTE";
        public static string contactinsupdte = "PROC_CONTACT_INSUPDTE";
        public static string usernameavl = "PROC_LOGINCREDENTIALS_NAMEAVL";
        public static string tagselect = "PROC_TAGTYPES_SELECT";
        public static string masterselect = "PROC_MASTERTYPES_SELECT";
        public static string postlistselect = "PROC_VIEW_POST_SELECT";
        public static string postinsupdte = "PROC_POSTS_INSUPDTE";
        public static string singlepostselect = "PROC_SINGLE_POST_SELECT";
        public static string favoriteadd = "PROC_FAVORITE_INSUPDTE";
        public static string voteadd = "PROC_VOTES_INSUPDTE";
        public static string logincheck = "PROC_LOGINCREDENTIALS_CHECK";
        public static string tagvoteuser = "PROC_TAGVOTE_USER_SELECT";
        public static string userdataselect = "PROC_USER_DATA_SELECT";
        public static string usercontactselect = "PROC_USER_CONTACT_SELECT";
        public static string useraddressselect = "PROC_USER_ADDRESS_SELECT";
        public static string useraddressinsupdte = "PROC_ADDRESS_INSUPDTE"; 


        //Parameters
        public string P_user_id = "P_USER_ID";
        public string P_user_code = "P_USER_CODE";
        public string P_name1 = "P_NAME1";
        public string P_name2 = "P_NAME2";
        public string P_user_type = "P_USER_TYPE";
        public string P_status = "P_STATUS";
        public string P_modified_by = "P_MODIFIED_BY";
        public string P_description = "P_DESCRIPTION";
        public string P_age = "P_AGE";
        public string P_display_name = "P_DISPLAY_NAME";
        public string P_last_access_date = "P_LAST_ACCESS_DATE";
        public string P_reputation = "P_REPUTATION";
        public string P_viewers = "P_VIEWERS";
        public string P_website_url = "P_WEBSITE_URL";
        public string P_parent_id = "P_PARENT_ID";
        public string P_ret = "P_RET";
        public string P_username = "P_USERNAME";
        public string P_login_credential_id = "P_LOGIN_CREDENTIAL_ID";
        public string P_login_password = "P_LOGIN_PASSWORD";
        public string P_valid_till = "P_VALID_TILL";
        public string P_id = "P_ID";
        public string P_contact_id = "P_CONTACT_ID";
        public string P_email = "P_EMAIL";
        public string P_phone = "P_PHONE";
        public string P_mobile1 = "P_MOBILE1";
        public string P_mobile2 = "P_MOBILE2";
        public string P_master_type = "P_MASTER_TYPE";
        public string P_master_type_id = "P_MASTER_TYPE_ID";
        public string P_tag_type_id = "P_TAG_TYPE_ID";
        public string P_tag_type = "P_TAG_TYPE";
        public string P_order_by = "P_ORDER_BY";
        public string P_title = "P_TITLE";
        public string P_post_id = "P_POST_ID";
        public string P_post_type_id = "P_POST_TYPE_ID";
        public string P_parent_post_id = "P_PARENT_POST_ID";
        public string P_sub_tags = "P_SUB_TAGS";
        public string P_body_content = "P_BODY_CONTENT";
        public string P_created_date = "P_CREATED_DATE";
        public string P_view_count = "P_VIEW_COUNT";
        public string P_last_activity_date = "P_LAST_ACTIVITY_DATE";
        public string P_last_edited_date = "P_LAST_EDITED_DATE";
        public string P_last_editor_user_id = "P_LAST_EDITOR_USER_ID";
        public string P_last_editor_display_name = "P_LAST_EDITOR_DISPLAY_NAME";
        public string P_favorite_count = "P_FAVORITE_COUNT";
        public string P_accepted_answer_id = "P_ACCEPTED_ANSWER_ID";
        public string P_answer_count = "P_ANSWER_COUNT";
        public string P_closed_date = "P_CLOSED_DATE";
        public string P_commentcount = "P_COMMENTCOUNT";
        public string P_closed_by = "P_CLOSED_BY";
        public string P_file_name = "P_FILE_NAME";
        public string P_sub_parent_post = "P_SUB_PARENT_POST_ID";
        public string P_voted_by = "P_VOTED_BY";
        public string P_voted_to = "P_VOTED_TO";
        public string P_vote_type_id = "P_VOTE_TYPE_ID";
        public string P_address_id = "P_ADDRESS_ID";
        public string P_line1 = "P_LINE1";
        public string P_line2 = "P_LINE2";
        public string P_district = "P_DISTRICT";        
        public string P_states = "P_STATES";
        public string P_country = "P_COUNTRY";
        public string P_postcode = "P_POST_CODE";
        public string P_affiliation = "P_AFFILIATION";

    }

    public class signupList
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string userid { get; set; }
        public string contactid { get; set; }
        public string loginid { get; set; }
    }

    public class usersList
    {
        public string user_id { get; set; }
        public string user_code { get; set; }
        public string name1 { get; set; }
        public string name2 { get; set; }
        public string user_type { get; set; }
        public string status { get; set; }
        public string modified_by { get; set; }
        public string description { get; set; }
        public string age { get; set; }
        public string display_name { get; set; }
        public string last_access_date { get; set; }
        public string reputation { get; set; }
        public string viewers { get; set; }
        public string website_url { get; set; }
        public string parent_id { get; set; }
    }

    public class logincredentialsList
    {
        public string user_id { get; set; }
        public string login_credential_id { get; set; }
        public string username { get; set; }
        public string login_password { get; set; }
        public string valid_till { get; set; }
        public string status { get; set; }
        public string id { get; set; }
    }

    public class contactList
    {
        public string contact_id { get; set; }
        public string user_id { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string mobile1 { get; set; }
        public string mobile2 { get; set; }
        public string status { get; set; }
        public string master_type { get; set; }
        public string master_id { get; set; }
        public string id { get; set; }
    }

    public class tagList
    {
        public string tag_type_id { get; set; }
        public string tag_type { get; set; }
    }

    public class postlist
    {
        public string post_id { get; set; }
        public string user_id { get; set; }
        public string title { get; set; }
        public string tag_type_id { get; set; }
        public string tag_type { get; set; }
        public string body_content { get; set; }
        public string created_date { get; set; }
        public string closed_date { get; set; }
        public string view_count { get; set; }
        public string comment_count { get; set; }
        public string favorite_count { get; set; }
        public string last_user_ids { get; set; }
        public string last_user_display_names { get; set; }
        public string activity { get; set; }
    }

    public class newpostlist
    {
        public string post_id { get; set; }
        public string post_type_id { get; set; }
        public string parent_post_id { get; set; }
        public string sub_parent_post { get; set; }
        public string user_id { get; set; }
        public string title { get; set; }
        public string tag_type_id { get; set; }
        public string sub_tags { get; set; }
        public string body_content { get; set; }
        public string created_date { get; set; }
        public string view_count { get; set; }
        public string last_activity_date { get; set; }
        public string last_edited_date { get; set; }
        public string last_editor_user_id { get; set; }
        public string last_editor_display_name { get; set; }
        public string favorite_count { get; set; }
        public string accepted_answer_id { get; set; }
        public string answer_count { get; set; }
        public string closed_date { get; set; }
        public string closed_by { get; set; }
        public string comment_count { get; set; }
        public string file_name { get; set; }

    }

    public class singlepostlist
    {
        public string post_id { get; set; }
        public string parent_post_id { get; set; }
        public string sub_parent_post_id { get; set; }
        public string user_id { get; set; }
        public string name { get; set; }
        public string displayname { get; set; }
        public string last_editor_display_name { get; set; }
        public string post_type_id { get; set; }
        public string post_type { get; set; }
        public string title { get; set; }
        public string tag_type_id { get; set; }
        public string tag_type { get; set; }
        public string sub_tags { get; set; }
        public string created_date { get; set; }
        public string body_content { get; set; }
        public string answer_count { get; set; }
        public string commentcount { get; set; }
        public string favorite_count { get; set; }
        public string view_count { get; set; }
        public string file_name { get; set; }
        public string upvote { get; set; }
        public string downvote { get; set; }
        public string closed_date { get; set; }
        public string closed_by { get; set; }

    }

    public class voteList
    {
        public string voted_by { get; set; }
        public string voted_to { get; set; }
        public string vote_type_id { get; set; }
        public string post_id { get; set; }
        public string tag_type_id { get; set; }
    }

    public class vtbList
    {
        public string userid { get; set; }
        public string name1 { get; set; }
        public string display_name { get; set; }
        public string created_date { get; set; }
        public string tag_bounty { get; set; }
        public string total_bounty { get; set; }
        public string tag_name { get; set; }
    }

    public class masterList
    {
        public string master_type_id { get; set; }
        public string master_type { get; set; }
    }

    public class userdataList
    {
        public string user_id { get; set; }
        public string user_code { get; set; }
        public string name1 { get; set; }
        public string name2 { get; set; }
        public string user_type { get; set; }
        public string type_id{ get; set; }
        public string created_date { get; set; }
        public string description { get; set; }
        public string age { get; set; }
        public string display_name { get; set; }
        public string website_url { get; set; }
        public string username { get; set; }
        public string login_password { get; set; }
        public string lastaccessdate { get; set; }
        public string total_bounty { get; set; }

    }

    public class useraddressList
    {
        public string address_id { get; set; }
        public string user_id { get; set; }
        public string master_id { get; set; }
        public string master_type { get; set; }
        public string line1 { get; set; }
        public string line2 { get; set; }
        public string district { get; set; }
        public string states { get; set; }
        public string country { get; set; }
        public string post_code { get; set; }
        public string affiliation { get; set; }
        public string status { get; set; }
        public string id { get; set; }
    }

}
