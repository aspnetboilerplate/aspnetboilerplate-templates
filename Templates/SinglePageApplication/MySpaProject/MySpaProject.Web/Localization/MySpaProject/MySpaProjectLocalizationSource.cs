using System.Web;
using Abp.Dependency;
using Abp.Localization.Sources.Xml;

namespace MySpaProject.Web.Localization.MySpaProject
{
    public class MySpaProjectLocalizationSource : XmlLocalizationSource
    {
        public MySpaProjectLocalizationSource()
            : base("MySpaProject", HttpContext.Current.Server.MapPath("/Localization/MySpaProject"))
        {
        }
    }
}