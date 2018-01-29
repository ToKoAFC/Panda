var app = angular
    .module('pandaApp', ['ngRoute', 'ngMaterial', 'ngMdIcons', 'ngGuid', 'md.data.table'])
    .config(['$locationProvider', function ($locationProvider) {

        $locationProvider.html5Mode({
            enabled: true,
            requireBase: false
        });
    }])
    .constant('_', window._);