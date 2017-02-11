var app = angular.module('plunker', ['ngDragDrop']);

app.controller('MainCtrl', function ($scope, $http) {

    $scope.list1 = [];
    $scope.list2 = [];
    $scope.list3 = [];

    $scope.getList1 = function () {
        $http.get('/home/getList1').then(function (response) {
            $scope.list1 = response.data;
        });
    }

    $scope.getList1();

    $scope.getList2 = function () {
        $http.get('/home/getList2').then(function (response) {
            $scope.list2 = response.data;
        });
    }

    $scope.getList2();

    $scope.getList3 = function () {
        $http.get('/home/getList3').then(function (response) {
            $scope.list3 = response.data;
        });
    }

    $scope.getList3();

    $scope.col1 = "";
    $scope.col2 = "";

    $scope.onDrop1 = function ($data, array) {
        $scope.col1 = $data.name;
        $scope.onBoth();
    };

    $scope.onDrop2 = function ($data, array) {
        $scope.col2 = $data.name;
        $scope.onBoth();
    };

    $scope.onBoth = function () {
        
        if (!($scope.col1 == "" || $scope.col2 == "")) {
            $.ajax({
                type: "POST",
                url: "/home/updateList3?temp=" + ($scope.col1 + "," + $scope.col2),
                success:function(){location.reload();}
            });
        }

    };

});
