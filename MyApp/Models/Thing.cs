using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyApp.Models 
{
    public class MyAppContext : DbContext
    {
        public DbSet<Thing> Things { get; set; }
        public MyAppContext()
            : base("MyAppContext")
        {
        }
    }

    public class Thing
    {
        public long ThingId { get; set; }
        public string Name { get; set; }
    }
}