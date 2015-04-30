(function () {

    var app = angular.module("AngularDemo");

    app.controller("mainController", ["$scope",mainController]);

    function mainController($scope) {

        $scope.mainMessage = "Hello Main Controller";
    }

}());