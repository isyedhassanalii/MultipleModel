using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MultipleModel.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("db")
        {}
        public DbSet<ModelA> ModelAs { get; set; }
        public DbSet<ModelB> ModelBs { get; set; }
    }
}