(function (angular) {
    'use strict';
    angular.module('pandaApp').controller('productsCtrl', ControllerFnc);

    ControllerFnc.$inject = [
        "_",
        'productService',
        '$location',
        '$window',
        '$mdToast',
        '$scope'
    ];
    function ControllerFnc() {
        _,
            productService,
            $location,
            $window,
            $mdToast,
            $scope
    }
    //Init properties
    var me = this;

    _.assign(me, {
        config: {

        }
    });
    (function init() {
        me.products = [{
                "ProductId": 0,
                "Name": "mąka poznańska",
                "Description": "100% mąka pszenna",
                "Price": 2.99
            },
            {
                "ProductId": 0,
                "Name": "Ketchup Heinz",
                "Description": "100g produktu wykonano z 140g pomidorów",
                "Price": 4.49
            },
            {
                "ProductId": 0,
                "Name": "Cisowianka",
                "Description": "Woda lekkogazowana",
                "Price": 1.69
            },
            {
                "ProductId": 0,
                "Name": "Chleb",
                "Description": "chleb pszenno-żytni",
                "Price": 1.96
            },
            {
                "ProductId": 0,
                "Name": "Pomarańcza",
                "Description": "kraj pochodzenia: Hiszpania",
                "Price": 2.99
            },
            {
                "ProductId": 0,
                "Name": "Banan",
                "Description": "Kraj pochodzenia: Argentyna",
                "Price": 3.99
            }
        ]
            })();
})(angular);


