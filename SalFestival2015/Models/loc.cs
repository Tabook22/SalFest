//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SalFestival2015.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class loc
    {
        public loc()
        {
            this.loc_markes = new HashSet<loc_markes>();
        }
    
        public int Id { get; set; }
        public string clat { get; set; }
        public string clog { get; set; }
        public Nullable<int> zoom { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public Nullable<int> cusId { get; set; }
        public Nullable<int> display { get; set; }
    
        public virtual cusInfo cusInfo { get; set; }
        public virtual ICollection<loc_markes> loc_markes { get; set; }
    }
}
