//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RideShare
{
    using System;
    using System.Collections.Generic;
    
    public partial class TripPlans
    {
        public int PlanID { get; set; }
        public string WhereFrom { get; set; }
        public string WhereTo { get; set; }
        public string Description { get; set; }
        public int Seats { get; set; }
        public System.DateTime TripDate { get; set; }
        public string TripHour { get; set; }
        public Nullable<int> UserID { get; set; }
    
        public virtual Users Users { get; set; }
    }
}
