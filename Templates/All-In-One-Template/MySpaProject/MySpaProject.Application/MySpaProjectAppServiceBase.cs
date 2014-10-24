using Abp.Application.Services;

namespace MySpaProject
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class MySpaProjectAppServiceBase : ApplicationService
    {
        protected MySpaProjectAppServiceBase()
        {
            LocalizationSourceName = MySpaProjectConsts.LocalizationSourceName;
        }
    }
}