using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Mladost.Areas.Identity.Data;

// Add profile data for application users by adding properties to the MladostUser class
public class MladostUser : IdentityUser
{
    [PersonalData]
    [Column(TypeName = "varchar(255)")]
    public string FirstName { get; set; }

    [PersonalData]
    [Column(TypeName = "varchar(255)")]
    public string LastName { get; set; }
}

