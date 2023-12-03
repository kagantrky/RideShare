using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RideShare
{
    public partial class MyTrips : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //LoadMyTrips();
                if (Session["UserID"] != null)
                {
                    int userId = Convert.ToInt32(Session["UserID"]);
                    LoadUserTrips(userId);
                }
                else
                {
                    // Kullanıcı giriş yapmamışsa, Login sayfasına yönlendir
                    Response.Redirect("Login.aspx");
                }
            }
        }
        private void LoadUserTrips(int userId)
        {

            //int userId = 1;

            using (var db = new RideShareEntities1())
            {
                var userTrips = db.TripPlans.Where(t => t.UserID == userId).ToList();
                gvMyTrips.DataSource = userTrips;
                gvMyTrips.DataBind();
            }
        }
        protected void gvMyTrips_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "DeleteTrip")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                int planId = Convert.ToInt32(gvMyTrips.DataKeys[rowIndex].Value); // PlanID alınır

                DeleteTrip(planId);
            }
        }

        private void DeleteTrip(int planId)
        {
            using (var db = new RideShareEntities1())
            {
                var trip = db.TripPlans.FirstOrDefault(t => t.PlanID == planId);
                if (trip != null)
                {
                    db.TripPlans.Remove(trip);
                    db.SaveChanges();

                    // GridView'i güncelle
                    int userId = Convert.ToInt32(Session["UserID"]);
                    LoadUserTrips(userId);
                }
            }
        }
    }
}