define(['plugins/router'],
    function (router) {

        return new function () {
            var that = this;

            that.router = router;

            that.languages = abp.localization.languages;
            that.currentLanguage = abp.localization.currentLanguage;

            that.activate = function () {
                router.map([
                    { route: '', title: abp.localization.localize('HomePage', 'MySpaProject'), moduleId: 'viewmodels/home', nav: true },
                    { route: 'about', title: abp.localization.localize('About', 'MySpaProject'), moduleId: 'viewmodels/about', nav: true }
                ]).buildNavigationModel();

                return that.router.activate();
            };
        };
    });