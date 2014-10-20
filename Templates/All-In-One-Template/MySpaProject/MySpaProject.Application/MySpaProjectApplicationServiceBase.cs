using Abp.Application.Services;

namespace MySpaProject
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class MySpaProjectApplicationServiceBase : ApplicationService
    {
        protected MySpaProjectApplicationServiceBase()
        {
            LocalizationSourceName = MySpaProjectConsts.LocalizationSourceName;
        }
    }
}