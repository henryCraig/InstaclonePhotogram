using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InstaclonePhotogram.Models;

namespace InstaclonePhotogram.Models
{
    public class InstaclonePhotogramContext : DbContext
    {
        public InstaclonePhotogramContext (DbContextOptions<InstaclonePhotogramContext> options)
            : base(options)
        {
        }

        public DbSet<InstaclonePhotogram.Models.User> User { get; set; }

        public DbSet<InstaclonePhotogram.Models.Photo> Photo { get; set; }
    }
}
