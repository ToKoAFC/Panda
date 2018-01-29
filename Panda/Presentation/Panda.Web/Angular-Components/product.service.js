(function (angular) {
    'use strict';
    angular
        .module('pandaApp')
        .service('productService', ['$http', "$rootScope", function ($http, $rootScope) {

            this.GetProducts = function () {
                return $http({
                    method: 'POST',
                    url: '/api/Product/GetProducts'
                })
                    .then(function (response) {
                        return response.data;
                    });
            };
            
        }]);

})(angular);



