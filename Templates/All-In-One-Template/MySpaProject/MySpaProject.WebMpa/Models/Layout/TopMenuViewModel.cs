using Abp.Application.Navigation;

namespace MySpaProject.WebMpa.Models.Layout
{
    public class TopMenuViewModel
    {
        public UserMenu MainMenu { get; set; }

        public string ActiveMenuItemName { get; set; }
    }
}