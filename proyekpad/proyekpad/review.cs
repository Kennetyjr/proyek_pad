//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace proyekpad
{
    using System;
    using System.Collections.Generic;
    
    public partial class review
    {
        public string re_id { get; set; }
        public string re_description { get; set; }
        public int re_rating { get; set; }
        public string re_al_id { get; set; }
        public string re_us_id { get; set; }
    
        public virtual alatmusik alatmusik { get; set; }
        public virtual user user { get; set; }
    }
}
