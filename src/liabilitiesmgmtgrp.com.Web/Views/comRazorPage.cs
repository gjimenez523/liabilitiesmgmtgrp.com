using Abp.AspNetCore.Mvc.Views;

namespace liabilitiesmgmtgrp.com.Web.Views
{
    public abstract class comRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected comRazorPage()
        {
            LocalizationSourceName = comConsts.LocalizationSourceName;
        }
    }
}
