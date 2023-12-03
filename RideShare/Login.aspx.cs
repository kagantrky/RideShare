using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RideShare
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            using (var db = new RideShareEntities1()) // RideShareEntities context
            {
                string email = txtEmail.Text;
                string password = txtPassword.Text;
                int userId;


                var user = db.Users.FirstOrDefault(u => u.Email == email && u.Password == password);


                if (user != null)
                {
                    Session["UserID"] = user.UserID;
                    //userId = user.UserID;
                    // Giriş başarılı, kullanıcıyı ana sayfaya yönlendir
                    Response.Redirect("Default.aspx"); 
                }
                else
                {
                    // Giriş başarısız, hata mesajı göster
                    lblErrorMessage.Text = "Giriş başarısız. Lütfen e-posta ve şifrenizi kontrol edin.";
                    lblErrorMessage.Visible = true;
                }
            }
        }
    }
}