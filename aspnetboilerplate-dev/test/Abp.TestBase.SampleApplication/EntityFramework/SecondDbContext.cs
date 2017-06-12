﻿using System.Data.Common;
using System.Data.Entity;
using Abp.Domain.Entities;
using Abp.EntityFramework;

namespace Abp.TestBase.SampleApplication.EntityFramework
{
    /* This dummy dbcontext is just to demonstrate usage of 2 dbcontextes in same UOW.
     */

    public class SecondDbContext : AbpDbContext
    {
        public virtual IDbSet<SecondDbContextEntity> SecondDbContextEntities { get; set; }
    }

    public class SecondDbContextEntity : Entity
    {
        public string Name { get; set; }
    }
}