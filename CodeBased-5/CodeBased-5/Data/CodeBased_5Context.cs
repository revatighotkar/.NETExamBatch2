using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodeBased_5.Models;

namespace CodeBased_5.Data
{
    public class CodeBased_5Context : DbContext
    {
        public CodeBased_5Context (DbContextOptions<CodeBased_5Context> options)
            : base(options)
        {
        }

        public DbSet<CodeBased_5.Models.Student> Student { get; set; }
    }
}
