using Abp.Modules;
using Abp.Reflection.Extensions;
using liabilitiesmgmtgrp.com.Localization;

namespace liabilitiesmgmtgrp.com
{
    public class comCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            comLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(comCoreModule).GetAssembly());
        }
    }
}