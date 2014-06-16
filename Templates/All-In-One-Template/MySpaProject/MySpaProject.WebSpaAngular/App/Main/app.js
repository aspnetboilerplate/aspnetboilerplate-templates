(function () {
    'use strict';

    var app = angular.module('app', [
        'ngAnimate',
        'ngRoute',
        'ngSanitize',

        'ui.bootstrap',
        'ui.jq',

        'abp'
    ]);

    app.constant('routes', getRoutes());

    function getRoutes() {
        return [
            {
                url: '/', //default: /home
                config: {
                    templateUrl: '/App/Main/views/home/home.cshtml',
                    menuItem: 'Home'
                }
            },
            {
                url: '/about',
                config: {
                    templateUrl: '/App/Main/views/about/about.cshtml',
                    menuItem: 'About'
                }
            }
        ];
    }

    app.config(['$routeProvider', 'routes', routeConfigurator]);
    function routeConfigurator($routeProvider, routes) {

        routes.forEach(function (r) {
            $routeProvider.when(r.url, r.config);
        });

        $routeProvider.otherwise({ redirectTo: abp.appPath });
    }

    app.run(['$rootScope', '$location', '$routeParams', '$route', function ($rootScope, $location, $routeParams, $route) {
        $rootScope.$on('$routeChangeSuccess', function (event, next, current) {
            if (next && next.$$route) {
                $rootScope.activeMenu = next.$$route.menuItem;
            }
        });
    }]);
})();