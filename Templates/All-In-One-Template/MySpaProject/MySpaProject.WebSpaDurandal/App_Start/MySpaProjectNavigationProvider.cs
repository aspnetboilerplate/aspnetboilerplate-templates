using Abp.Application.Navigation;
using Abp.Localization;

namespace MyCompany.MySpaProject.WebSpaDurandal
{
    /// <summary>
    /// This class defines menus for the application.
    /// It uses ABP's menu system.
    /// When you add menu items here, they are automatically appear in durandal application.
    /// See App/Main/views/layout.cshtml and App/Main/viewmodels/layout.js to know how to render menu.
    /// </summary>
    public class MySpaProjectNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        "Home",
                        new LocalizableString("HomePage", MySpaProjectConsts.LocalizationSourceName),
                        url: "#",
                        icon: "fa fa-home"
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "About",
                        new LocalizableString("About", MySpaProjectConsts.LocalizationSourceName),
                        url: "#about",
                        icon: "fa fa-info"
                        )
                );
        }
    }
}
