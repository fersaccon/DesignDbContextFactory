using System;
using System.Collections.Generic;
using System.Text;

namespace BOL
{
    public class Admins
    {
        public int Id { get; set; }
        public string IdentityId { get; set; }
        public AppUser Identity { get; set; }  // navigation property
        public string Location { get; set; }
    }
}
