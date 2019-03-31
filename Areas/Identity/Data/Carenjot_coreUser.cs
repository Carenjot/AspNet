using System;
using System.Collections.Generic;
using System.Linq;
using Carenjot_core.Models;
using Microsoft.AspNetCore.Identity;

namespace Carenjot_core.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the Carenjot_coreUser class
    public class Carenjot_coreUser : IdentityUser
    {
        public ICollection<Task> Tasks { get; set; }
    }
}
