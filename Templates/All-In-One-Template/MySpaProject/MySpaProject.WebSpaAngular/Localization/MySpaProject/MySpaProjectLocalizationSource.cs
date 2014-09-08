using System.Web;
using Abp.Localization.Sources.Xml;

namespace MySpaProject.WebSpaAngular.Localization.MySpaProject
{
    public class MySpaProjectLocalizationSource : XmlLocalizationSource
    {
        public MySpaProjectLocalizationSource()
            : base("MySpaProject", HttpContext.Current.Server.MapPath("~/Localization/MySpaProject"))
        {
        }
    }
}