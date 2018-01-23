var app = angular
    .module("pandaApp",
    [
        'ngMaterial',
        'ngMdIcons'
    ],
    function ($locationProvider) {
        $locationProvider.html5Mode({
            enabled: true,
            requireBase: false,

        });
    })
    .constant('_', window._);