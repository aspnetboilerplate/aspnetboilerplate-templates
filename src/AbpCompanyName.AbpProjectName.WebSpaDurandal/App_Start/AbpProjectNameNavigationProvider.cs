using Abp.Application.Navigation;
using Abp.Localization;

namespace AbpCompanyName.AbpProjectName.WebSpaDurandal
{
    /// <summary>
    /// This class defines menus for the application.
    /// It uses ABP's menu system.
    /// When you add menu items here, they are automatically appear in durandal application.
    /// See App/Main/views/layout.cshtml and App/Main/viewmodels/layout.js to know how to render menu.
    /// </summary>
    public class AbpProjectNameNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        "Home",
                        new LocalizableString("HomePage", AbpProjectNameConsts.LocalizationSourceName),
                        url: "#",
                        icon: "fa fa-home"
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "About",
                        new LocalizableString("About", AbpProjectNameConsts.LocalizationSourceName),
                        url: "#about",
                        icon: "fa fa-info"
                        )
                );
        }
    }
}
