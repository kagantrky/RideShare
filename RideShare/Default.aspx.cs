using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RideShare
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // İlk sayfa yüklemede tüm seyahat planlarını yükle
                LoadTripPlans();
                LoadCurrentTrips(); // Güncel seyahat planları
            }
            //if (!IsPostBack)
            //{
            //    if (Session["UserLoggedIn"] != null && (bool)Session["UserLoggedIn"])
            //    {
            //        // Kullanıcı giriş yapmışsa, ana içeriği göster
            //        mainContent.Style["display"] = "block";

            //    }
            //    else
            //    {
            //        // Kullanıcı giriş yapmamışsa, sadece kayıt ve giriş butonlarını göster
            //        initialButtons.Style["display"] = "block";
            //    }
            //}
        }
        private void LoadCurrentTrips()
        {
            using (var db = new RideShareEntities1())
            {
               
                var tripPlans = db.TripPlans.ToList();
                gvCurrentTrips.DataSource = tripPlans;
                gvCurrentTrips.DataBind();
            }
        }
        protected void gvCurrentTrips_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "JoinTrip")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                int planId = Convert.ToInt32(gvCurrentTrips.DataKeys[rowIndex].Value);

            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            // Kullanıcının girdiği değerlere göre filtreleme yap
            LoadTripPlans(txtWhereFrom.Text, txtWhereTo.Text);
        }
        private void LoadTripPlans(string whereFrom = "", string whereTo = "")
        {
            // Veritabanından filtrelenmiş sonuçları çek ve GridView'a bağla

        }

        protected void gvTripPlans_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "JoinTrip")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                int planId = Convert.ToInt32(gvTripPlans.DataKeys[rowIndex].Value); 
                                                                                    
            }
        }


    }
}