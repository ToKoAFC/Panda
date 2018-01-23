(function (angular) {
    'use strict';
    angular.module('pandaApp').controller('productsCreateCtrl', ControllerFnc);

    ControllerFnc.$inject = [
        "_",
        'productService',
        '$location',
        '$window',
        '$mdToast',
        '$scope'
    ];
    function ControllerFnc(
        _,
        productService,
        $location,
        $window,
        $mdToast,
        $scope
    ) {

        //Init properties
        var me = this;

        _.assign(me, {
            config: {

            }
        });

        (function init() {
            me.productId = $location.search().productId;

            productService.GetProduct(me.productId).then(function (response) {
                me.product = response.data;
            });
        })();

        me.saveProduct = function (ev) {
            productService.saveProduct(me.product).then(
                function () {
                    $window.location.href = '/Product/Create';
                })
        }
        me.backToProductList = function () {
            $window.location.href = '/Product/Index';
        }
    }
})(angular);