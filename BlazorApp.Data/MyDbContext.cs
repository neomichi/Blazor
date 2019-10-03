using System;
using System.Linq;
using System.Reflection.Metadata;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using BlazorApp.Data.Model;
using BlazorApp.Data.Models;


namespace BlazorApp.Data
{



    public class MyDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>

    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
            

        }

       public DbSet<ApplicationUser> appUsers { get; set; }
       public DbSet<ApplicationRole>  appRoles { get; set; }

    //public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
         

            base.OnModelCreating(builder);

            builder.HasPostgresExtension("uuid-ossp");

            builder.Entity<ApplicationUser>().Property(x => x.Id).HasDefaultValueSql("uuid_generate_v4()");
            builder.Entity<ApplicationRole>().Property(x => x.Id).HasDefaultValueSql("uuid_generate_v4()");


            //SELECT uuid_generate_v4();



            //select uuid_generate_v4();

            //WTF????
            //var converter = new ValueConverter<string, Guid>(
            //   v => new Guid(v),
            //   v => v.ToString(),
            //   new ConverterMappingHints(valueGeneratorFactory: (p, t) => new GuidStringGenerator()));

            //builder.Entity<Car>().Property(e => e.Id).HasConversion(converter);
        }
    }

    //https://github.com/aspnet/EntityFrameworkCore/issues/11867
    //public class GuidStringGenerator : ValueGenerator<string>
    //{
    //    private readonly SequentialGuidValueGenerator _guidGenerator
    //        = new SequentialGuidValueGenerator();

    //    public override string Next(EntityEntry entry)
    //        => _guidGenerator.Next(entry).ToString();

    //    public override bool GeneratesTemporaryValues
    //        => false;
    //}
}
