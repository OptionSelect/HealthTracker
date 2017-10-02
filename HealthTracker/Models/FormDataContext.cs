using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthTracker.Models
{
    public class FormDataContext : DbContext
    {
        public FormDataContext(DbContextOptions<FormDataContext> options)
            : base(options)
        { }

        public DbSet<FormData> FormDatas { get; set; }
    }
}
