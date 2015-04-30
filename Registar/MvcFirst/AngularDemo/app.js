(function () {

    var app = angular.module("AngularDemo", ['ngRoute']);
    app.config(function ($routeProvider) {

        $routeProvider.when("/citis", {

            templateUrl: 'citis.html',
            controller: 'weatherController'

        }).when("/city/:cityName", {

            templateUrl: 'city.html',
            controller: 'cityController'

        }).otherwise({ redirectTo: "/" });

    })

}());