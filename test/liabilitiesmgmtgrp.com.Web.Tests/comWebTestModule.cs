using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using liabilitiesmgmtgrp.com.Web.Startup;
namespace liabilitiesmgmtgrp.com.Web.Tests
{
    [DependsOn(
        typeof(comWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class comWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(comWebTestModule).GetAssembly());
        }
    }
}