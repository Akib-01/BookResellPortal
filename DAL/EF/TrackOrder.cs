//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class TrackOrder
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string OrderDate { get; set; }
        public string ArrivalDate { get; set; }
        public string Status { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
