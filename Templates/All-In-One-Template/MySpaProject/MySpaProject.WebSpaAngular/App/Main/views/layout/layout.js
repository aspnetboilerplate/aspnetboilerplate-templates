(function () {
    var app = angular.module('app');

    var controllerId = 'app.controllers.views.layout';
    app.controller(controllerId, ['routes', function (routes) {
        var vm = this;

        vm.routes = routes;

        vm.languages = abp.localization.languages;
        vm.currentLanguage = abp.localization.currentLanguage;

        vm.menu = abp.nav.menus.MainMenu;
    }]);
})();