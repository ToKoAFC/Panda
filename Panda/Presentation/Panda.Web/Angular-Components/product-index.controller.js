(function (angular) {
    'use strict';
    angular.module('pandaApp').controller('productsCtrl', ControllerFnc);

    ControllerFnc.$inject = [
        "_",
        'productService',
        '$mdDialog',
        '$mdToast',
        '$scope',
        '$window'
    ];
    function ControllerFnc(
        _,
        productService,
        $mdDialog,
        $mdToast,
        $scope,
        $window
    ) {

        //Init properties
        var me = this;

        _.assign(me, {
            config: {

            }
        });

        (function init() {
            productService.GetProducts().then(function (response) {
                me.products = response.data;
            });
        })();
    }
})(angular);