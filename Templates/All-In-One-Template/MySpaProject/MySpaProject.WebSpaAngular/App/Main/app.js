(function () {
    'use strict';

    var localize = abp.localization.getSource('MySpaProject');

    var app = angular.module('app', [
        'ngAnimate',
        'ngRoute',
        'ngSanitize',

        'ui.bootstrap',
        'ui.jq',

        'abp'
    ]);

    app.constant('routes', [
            {
                url: '/', //default
                config: {
                    templateUrl: '/App/Main/views/home/home.cshtml',
                    menuText: localize('HomePage'),
                    menuItem: 'HomePage'
                }
            },
            {
                url: '/about',
                config: {
                    templateUrl: '/App/Main/views/about/about.cshtml',
                    menuText: localize('About'),
                    menuItem: 'About'
                }
            }
        ]);

    app.config([
        '$routeProvider', 'routes',
        function ($routeProvider, routes) {
            routes.forEach(function (route) {
                $routeProvider.when(route.url, route.config);
            });

            $routeProvider.otherwise({
                redirectTo: '/'
            });
        }
    ]);

    app.run([
        '$rootScope',
        function ($rootScope) {
            $rootScope.$on('$routeChangeSuccess', function (event, next, current) {
                if (next && next.$$route) {
                    $rootScope.activeMenu = next.$$route.menuItem; //Used in layout.cshtml to make selected menu 'active'.
                }
            });
        }
    ]);
})();