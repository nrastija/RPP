using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace vj4_zadatak7
{
    public partial class NorthwndModel : DbContext
    {
        public NorthwndModel()
            : base("name=NorthwndModel")
        {
        }

        public virtual DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
