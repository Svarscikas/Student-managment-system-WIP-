using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Lab2.Models;

namespace Lab2.Context
{
    public class SchoolInitializer : DropCreateDatabaseIfModelChanges<SchoolContext>  
    {
       
        protected override void Seed(SchoolContext context)
        {
            context.Database.CreateIfNotExists();
            
        }
    }
}