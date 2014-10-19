using Abp.Application.Navigation;
using Abp.Localization;

namespace MySpaProject.WebSpaAngular
{
    public class MySpaProjectNavigationProvider : INavigationProvider
    {
        public void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        "Home",
                        new LocalizableString("HomePage", MySpaProjectConsts.LocalizationSourceName)
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "About",
                        new LocalizableString("About", MySpaProjectConsts.LocalizationSourceName)
                        )
                );
        }
    }
}
