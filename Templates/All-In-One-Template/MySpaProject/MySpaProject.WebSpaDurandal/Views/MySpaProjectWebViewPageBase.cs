using Abp.Web.Mvc.Views;

namespace MyCompany.MySpaProject.WebSpaDurandal.Views
{
    public abstract class MySpaProjectWebViewPageBase : MySpaProjectWebViewPageBase<dynamic>
    {

    }

    public abstract class MySpaProjectWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected MySpaProjectWebViewPageBase()
        {
            LocalizationSourceName = MySpaProjectConsts.LocalizationSourceName;
        }
    }
}