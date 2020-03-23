﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication_Module6_TP1.Data
{
    public class WebApplication_Module6_TP1Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public WebApplication_Module6_TP1Context() : base("name=WebApplication_Module6_TP1Context")
        {
        }

        public System.Data.Entity.DbSet<WebApplication_Module6_TP1.Models.BO.Arme> Armes { get; set; }

        public System.Data.Entity.DbSet<WebApplication_Module6_TP1.Models.BO.Samourai> Samourais { get; set; }
    }
}
