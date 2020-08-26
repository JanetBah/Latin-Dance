using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Latin_Dance.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the Latin_DanceUser class
    public class Latin_DanceUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName ="nvarchar100")]
        public string FullName { get; set; }
    }
}
