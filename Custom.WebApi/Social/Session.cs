//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Custom.Social
{
    using System;
    using System.Collections.Generic;
    
    public partial class Session
    {
        public int Id { get; set; }
        public System.DateTime Since { get; set; }
        public Nullable<System.DateTime> Until { get; set; }
    
        public virtual Identity Identity { get; set; }
    }
}