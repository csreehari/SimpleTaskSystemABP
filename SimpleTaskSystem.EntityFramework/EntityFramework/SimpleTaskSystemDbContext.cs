﻿using Abp.EntityFramework;
using SimpleTaskSystem.Models;
using System.Data.Entity;

namespace SimpleTaskSystem.EntityFramework
{
    public class SimpleTaskSystemDbContext : AbpDbContext
    {
        //TODO: Define an IDbSet for each Entity...

        //Example:
        //public virtual IDbSet<User> Users { get; set; }
        public virtual IDbSet<SMPSUser> Users { get; set; }
        public virtual IDbSet<Project> Projects { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public SimpleTaskSystemDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in SimpleTaskSystemDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of SimpleTaskSystemDbContext since ABP automatically handles it.
         */
        public SimpleTaskSystemDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }
    }
}
