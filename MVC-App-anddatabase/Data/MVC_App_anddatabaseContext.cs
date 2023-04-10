using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_App_anddatabase.Models;

namespace MVC_App_anddatabase.Data
{
    public class MVC_App_anddatabaseContext : DbContext
    {
        public MVC_App_anddatabaseContext (DbContextOptions<MVC_App_anddatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_App_anddatabase.Models.Movie> Movie { get; set; } = default!;
    }
}
