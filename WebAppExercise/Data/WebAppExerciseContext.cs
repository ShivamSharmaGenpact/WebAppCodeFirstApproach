using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppExercise.Models;

namespace WebAppExercise.Data
{
    public class WebAppExerciseContext : DbContext
    {
        public WebAppExerciseContext (DbContextOptions<WebAppExerciseContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppExercise.Models.Course> Course { get; set; } = default!;
    }
}
