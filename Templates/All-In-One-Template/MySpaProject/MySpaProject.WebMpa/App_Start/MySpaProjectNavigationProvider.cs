using Abp.Application.Navigation;
using Abp.Localization;

namespace MySpaProject.WebMpa
{
    /// <summary>
    /// This class defines menus for the application.
    /// It uses ABP's menu system.
    /// When you add menu items here, they are automatically appear in angular application.
    /// See _TopMenu.cshtml file under Views/Shared/ to know how to render menu.
    /// </summary>
    public class MySpaProjectNavigationProvider : INavigationProvider
    {
        public void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        "Home",
                        new LocalizableString("HomePage", MySpaProjectConsts.LocalizationSourceName),
                        url: "/",
                        icon: "fa fa-home"
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "About",
                        new LocalizableString("About", MySpaProjectConsts.LocalizationSourceName),
                        url: "/About",
                        icon: "fa fa-info"
                        )
                );
        }
    }
}
