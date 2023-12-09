using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UsersManageUI.Models
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
        public int PhoneNumber { get; set; }
        public string Skillsets { get; set; }
        public string Hobby { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public bool IsActive { get; set; }
    }
}