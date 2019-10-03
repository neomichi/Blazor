using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace BlazorApp.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<MyDbContext>
    {
     
        public MyDbContext CreateDbContext(string[] args)
        {

            //var index = Directory.GetCurrentDirectory().Length - "BlazorApp.Data".Length;
            //var path = Directory.GetCurrentDirectory().Substring(0, index) + "VuetifySpa.Web/appsettings.json";
            var connectionString = "Host=localhost;Port=5432;User ID=postgres;Password=123;Database=VueTest3;Pooling=true;";
           
    
              var builder = new DbContextOptionsBuilder<MyDbContext>();
          //  var connectionString = configuration.GetConnectionString("PostgreSQL");
            builder.UseNpgsql(connectionString);
            return new MyDbContext(builder.Options);
        }
    }
}
