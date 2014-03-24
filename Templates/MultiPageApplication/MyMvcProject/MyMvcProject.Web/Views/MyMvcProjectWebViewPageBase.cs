using Abp.Web.Mvc.Views;

namespace MyMvcProject.Web.Views
{
    public abstract class MyMvcProjectWebViewPageBase : MyMvcProjectWebViewPageBase<dynamic>
    {

    }

    public abstract class MyMvcProjectWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected MyMvcProjectWebViewPageBase()
        {
            LocalizationSourceName = "MyMvcProject";
        }
    }
}