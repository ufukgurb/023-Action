using AspNetMVC_021_Action.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace AspNetMVC_021_Action.DAL
{
    public class OBSContext:DbContext
    {

        public OBSContext() : base ("OBSVeritabani"){ }

        public DbSet<Fakulte> Fakulteler { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }
}