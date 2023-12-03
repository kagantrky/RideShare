using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RideShare
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            using (var db = new RideShareEntities1()) // Entity Framework'un olusturdugu context ismi
            {
                var user = new Users 
                {
                    Name = txtFirstName.Text,
                    Surname = txtLastName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text 
                };

                db.Users.Add(user);
                db.SaveChanges();

                // Kayıt sonrası işlemler, örneğin kullanıcıyı giriş sayfasına yönlendirme
                Response.Redirect("Login.aspx");
            }
        }
    }
}