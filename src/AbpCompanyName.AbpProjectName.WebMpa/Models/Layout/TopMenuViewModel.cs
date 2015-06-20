using Abp.Application.Navigation;

namespace AbpCompanyName.AbpProjectName.WebMpa.Models.Layout
{
    public class TopMenuViewModel
    {
        public UserMenu MainMenu { get; set; }

        public string ActiveMenuItemName { get; set; }
    }
}