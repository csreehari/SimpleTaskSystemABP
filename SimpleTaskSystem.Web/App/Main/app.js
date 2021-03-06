﻿(function () {
    'use strict';

    var app = angular.module('app', [
        'ngAnimate',
        'ngSanitize',

        'ui.router',
        'ui.bootstrap',
        'ui.jq',

        'abp'
    ]);

    //Configuration for Angular UI routing.
    app.config([
        '$stateProvider', '$urlRouterProvider',
        function($stateProvider, $urlRouterProvider) {
            $urlRouterProvider.otherwise('/');
            $stateProvider
                .state('home', {
                    url: '/',
                    templateUrl: '/App/Main/views/home/home.cshtml',
                    menu: 'Home' //Matches to name of 'Home' menu in SimpleTaskSystemNavigationProvider
                })
                .state('about', {
                    url: '/about',
                    templateUrl: '/App/Main/views/about/about.cshtml',
                    menu: 'About' //Matches to name of 'About' menu in SimpleTaskSystemNavigationProvider
                })
                .state('holders', {
                    url: '/holders',
                    templateUrl: '/App/Main/views/holders/holders.cshtml',
                    menu: 'Holders' //Matches to name of 'About' menu in SimpleTaskSystemNavigationProvider
                })
                .state('seekers', {
                    url: '/seekers',
                    templateUrl: '/App/Main/views/seekers/seekers.cshtml',
                    menu: 'Seekers' //Matches to name of 'About' menu in SimpleTaskSystemNavigationProvider
                });
        }
    ]);
})();