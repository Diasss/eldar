using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class InititalData : DropCreateDatabaseAlways<Model1>
    {
        protected override void Seed(Model1 context)
        {

            context.Products.Add(new Products { Name = "Pomidor", Cost = 200 });
            context.Products.Add(new Products { Name = "Coconut", Cost = 600 });
            context.Products.Add(new Products { Name = "Cucumber", Cost = 100 });

        }

    }

}