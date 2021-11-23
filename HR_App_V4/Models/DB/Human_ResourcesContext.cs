using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace HR_App_V4.Models.DB
{
    public partial class Human_ResourcesContext : DbContext
    {
        public Human_ResourcesContext()
        {
        }

        public Human_ResourcesContext(DbContextOptions<Human_ResourcesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<WC_Inbox> WC_Inbox { get; set; } = null!;

    }
}
