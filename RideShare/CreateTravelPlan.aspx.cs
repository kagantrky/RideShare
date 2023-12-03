using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RideShare
{
    public partial class CreateTravelPlan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["UserID"] == null)
            //{
            //    Response.Redirect("Login.aspx");
            //}
        }
        protected void btnCreatePlan_Click(object sender, EventArgs e)
        {

            // Session'dan kullanıcının ID'sini alın
            if (Session["UserID"] != null)
            {
                int userId = Convert.ToInt32(Session["UserID"]); // UserID'yi Session'dan al

                using (var db = new RideShareEntities1())
                {
                    var tripPlan = new TripPlans
                    {
                        WhereFrom = txtFrom.Text,
                        WhereTo = txtTo.Text,
                        TripDate = Convert.ToDateTime(txtDate.Text),
                        TripHour = txtTripHour.Text,
                        Description = txtDescription.Text,
                        Seats = Convert.ToInt32(txtSeatCount.Text),
                        UserID = userId // UserID'yi TripPlans nesnesine ekleyin
                    };

                    db.TripPlans.Add(tripPlan);
                    db.SaveChanges();

                    // Plan oluşturulduktan sonra başka bir sayfaya yönlendirme yapabilirsiniz
                    Response.Redirect("MyTrips.aspx"); // Örneğin MyTrips sayfasına
                }
            }
            else
            {
                // Kullanıcı giriş yapmamışsa, Login sayfasına yönlendir
                Response.Redirect("Login.aspx");
            }
        }

    }
}