using System.Web;
using Abp.Dependency;
using Abp.Localization.Sources.Xml;

namespace MyMvcProject.Web.Localization.MyMvcProject
{
    public class MyMvcProjectLocalizationSource : XmlLocalizationSource
    {
        public MyMvcProjectLocalizationSource()
            : base("MyMvcProject", HttpContext.Current.Server.MapPath("/Localization/MyMvcProject"))
        {
        }
    }
}