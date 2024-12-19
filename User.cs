using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FEH
{
    public class User
    {
        public int id {  get; set; }
        public string? fname { get; set; }
        public string? lname {  get; set; }
        public string? address {  get; set; }
        public string? username { get; set; }
        public string? password { get; set; }
        public bool isAdmin {  get; set; }
        /*public User(int Id,string Fname,string Lname,string Address,string Username,string Password,bool IsAdmin)
        {
            fname=Fname;
            lname=Lname;
            address=Address;
            username=Username;
            password=Password;
            isAdmin=IsAdmin;
        }
        public User()
        {

        }*/
    }
}
