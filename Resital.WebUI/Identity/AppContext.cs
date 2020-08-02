using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Web.Identity
{
    public class AppContext : IdentityDbContext<User>
    {
        public AppContext(DbContextOptions<AppContext> options):base(options)
        {
            
        }
    }
}
