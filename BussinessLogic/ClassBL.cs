using BussinessObject;
using DataAccessLayer;
using System.Collections.Generic;
using System.Data;

namespace BussinessLogic
{
    public class ClassBL
    {
        ClassDA da = new ClassDA();

        public int savesignup(usersList list)
        {
            return da.savesignup(list);
        }

        public int savecontacts(contactList list)
        {
            return da.savecontacts(list);
        }

        public int savelogincredentials(logincredentialsList list)
        {
            return da.savelogincredentials(list);
        }

        public int avlusername(string username)
        {
            return da.avlusername(username);
        }

        public DataTable serchtag(string code)
        {
            return da.serchtag(code);
        }

        public DataTable serchmaster()
        {
            return da.serchmaster();
        }
        
        public DataTable getpostlist(string post_title, int order_by, string tag_type)
        {
            return da.getpostlist(post_title, order_by, tag_type);
        }

        public int savenewpost(newpostlist list)
        {
            return da.savenewpost(list);
        }

        public DataTable getsinglepost(int post_id)
        {
            return da.getsinglepost(post_id);
        }

        public string addfavorite(string post_id)
        {
            return da.addfavorite(post_id);
        }

        public string addvote(voteList list)
        {
            return da.addvote(list);
        }

        public DataTable loginclick(string username, string password)
        {
            return da.loginclick( username,  password);
        }

        public DataTable tagvoteuser(int tag_id, int user_id)
        {
            return da.tagvoteuser(tag_id, user_id);
        }

        public DataTable getuserdata(int id)
        {
            return da.getuserdata(id);
        }

        public DataTable getusercontact(int id)
        {
            return da.getusercontact(id);
        }

        public DataTable getuseraddress(int id)
        {
            return da.getuseraddress(id);
        }

        public int saveaddressdetail(useraddressList list)
        {
            return da.saveaddressdetail(list);
        }
        

    }
}
