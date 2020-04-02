﻿using liabilitiesmgmtgrp.com.Configuration;
using liabilitiesmgmtgrp.com.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace liabilitiesmgmtgrp.com.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class comDbContextFactory : IDesignTimeDbContextFactory<comDbContext>
    {
        public comDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<comDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(comConsts.ConnectionStringName)
            );

            return new comDbContext(builder.Options);
        }
    }
}