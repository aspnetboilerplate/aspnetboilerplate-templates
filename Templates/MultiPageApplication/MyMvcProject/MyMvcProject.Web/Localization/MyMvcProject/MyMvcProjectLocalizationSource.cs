using System.Web;
using Abp.Dependency;
using Abp.Localization.Sources.Xml;

namespace MyMvcProject.Web.Localization.MyMvcProject
{
    public class MyMvcProjectLocalizationSource : XmlLocalizationSource, ISingletonDependency //TODO: Remove ISingletonDependency after Abp 0.1.5.0
    {
        public MyMvcProjectLocalizationSource()
            : base("MyMvcProject", HttpContext.Current.Server.MapPath("/Localization/MyMvcProject"))
        {
        }
    }
}