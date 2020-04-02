using Abp.Application.Services;

namespace liabilitiesmgmtgrp.com
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class comAppServiceBase : ApplicationService
    {
        protected comAppServiceBase()
        {
            LocalizationSourceName = comConsts.LocalizationSourceName;
        }
    }
}