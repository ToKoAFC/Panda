(function (angular) {
    'use strict';
    angular
        .module('pandaApp')
        .service('productService', ['$http', function ($http) {

            this.GetProductList = function (instanceTypeId) {
                return $http({
                    method: 'POST',
                    url: '/api/Product/GetProductList'
                })
                    .then(function (data) {
                        return data;
                    })
            };

            this.GetProduct = function (productId) {
                return $http({
                    method: 'POST',
                    url: '/api/Product/GetProduct',
                    data: {
                        ProductId: productId
                    }
                })
                    .then(function (data) {
                        return data;
                    })
            };

            this.SaveProduct = function (productId) {
                return $http({
                    method: 'POST',
                    url: '/api/Product/SaveProduct',
                    data: {
                        ProductId: productId
                    }
                })
            };

        }]);

})(angular);



