//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DCode.Data.DbContexts
{
    using System;
    using System.Collections.Generic;
    
    public partial class email_tracker
    {
        public int id { get; set; }
        public string subject { get; set; }
        public string to_addresses { get; set; }
        public string cc_addresses { get; set; }
        public string bcc_Addresses { get; set; }
        public System.DateTime sent_date { get; set; }
        public string source { get; set; }
        public string body { get; set; }
    }
}
