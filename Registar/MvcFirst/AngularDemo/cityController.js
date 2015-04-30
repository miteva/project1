(function () {

    var app = angular.module("AngularDemo");

    app.controller("cityController", ["$scope","$http", "$location",cityController]);

    function cityController($scope, $http, $location) {
        var onSuccessCity = function (response) {

            $scope.cityWeather = response.data;
            $location.path('city/Skopje')

        };

        var onError = function (reason) {

            $scope.error = reason;
        }


        $scope.citySearch = "Paris";

        $scope.search = function (city) {

            var url = "http://api.openweathermap.org/data/2.5/weather?q=" + city;

            $http.get(url).then(onSuccessCity, onError);

        }
    }}());