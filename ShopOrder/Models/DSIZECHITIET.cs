//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopOrder.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DSIZECHITIET
    {
        public string ID { get; set; }
        public string DMATHANGID { get; set; }
        public string DSIZEID { get; set; }
    
        public virtual DMATHANG DMATHANG { get; set; }
        public virtual DSIZE DSIZE { get; set; }
    }
}
