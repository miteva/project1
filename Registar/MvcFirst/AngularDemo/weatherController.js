(function () {

    var app = angular.module("AngularDemo");

    app.controller("weatherController", ["$scope","$http", weatherController]);

    function weatherController($scope,$http) {

        //$scope.user = {

        //    "FirstName": "Bill",
        //    "LastName": "Gates",
        //    "Division": "Microsoft",
        //    "ImageUrl": "http://image.guardian.co.uk/sys-images/Media/Pix/pictures/2004/03/09/billgatesAP1.jpg"

        //};

      

      
        var onSuccessCity = function (response) {

           
            $scope.cities = response.data.list;
            $scope.showCities = true;
        };

        var onError = function (reason) {

            $scope.error = reason;
            $scope.showCities = false;
        }


        $scope.citySearch = "Paris";

        $scope.search= function () {

          
            var urlMulti = "http://api.openweathermap.org/data/2.5/box/city?bbox=12,32,15,37,10&cluster=yes";
            $http.get(urlMulti).then(onSuccessCity, onError);

        }
        $scope.search();



        $scope.sort = function (columnName) {

            if ($scope.sortColumn === columnName) {

                $scope.sortColumn = "-" + columnName;
            }
            else {
                $scope.sortColumn = columnName;
            }

        };
       
     
        

       
    }

}());