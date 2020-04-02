using Abp.AspNetCore.Mvc.Controllers;

namespace liabilitiesmgmtgrp.com.Web.Controllers
{
    public abstract class comControllerBase: AbpController
    {
        protected comControllerBase()
        {
            LocalizationSourceName = comConsts.LocalizationSourceName;
        }
    }
}