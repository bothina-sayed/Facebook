//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace facebook_mvc.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class post
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public post()
        {
            this.comments = new HashSet<comment>();
            this.likes = new HashSet<like>();
        }
    
        public int post_id { get; set; }
        public string post_description { get; set; }
        public Nullable<int> likesNumber { get; set; }
        public string post_state { get; set; }
        public int user_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comment> comments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<like> likes { get; set; }
        public virtual user_profile user_profile { get; set; }
    }
}