using System.Web.Mvc;
using Abp.Application.Navigation;
using Abp.Localization;
using MySpaProject.WebMpa.Models.Layout;

namespace MySpaProject.WebMpa.Controllers
{
    public class LayoutController : MySpaProjectControllerBase
    {
        private readonly IUserNavigationManager _userNavigationManager;
        private readonly ILocalizationManager _localizationManager;

        public LayoutController(IUserNavigationManager userNavigationManager, ILocalizationManager localizationManager)
        {
            _userNavigationManager = userNavigationManager;
            _localizationManager = localizationManager;
        }

        [ChildActionOnly]
        public PartialViewResult TopMenu()
        {
            var model = new TopMenuViewModel
                        {
                            MainMenu = _userNavigationManager.GetMenu("MainMenu", CurrentSession.UserId)
                        };

            return PartialView("_TopMenu", model);
        }

        [ChildActionOnly]
        public PartialViewResult LanguageSelection()
        {
            var model = new LanguageSelectionViewModel
                        {
                            CurrentLanguage = _localizationManager.CurrentLanguage,
                            Languages = _localizationManager.GetAllLanguages()
                        };

            return PartialView("_LanguageSelection", model);
        }
    }
}