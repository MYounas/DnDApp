
//var app = angular.module('myApp', ['dndLists']);
//app.controller('myController', ['$http', function ($http) {
//    var vm = this;

//    vm.list1 = [];
//    vm.list2 = [];
//    vm.list3 = [];

//    vm.getList1 = function () {
//        $http.get('/home/getList1').then(function (response) {
//            vm.list1 = response.data;
//        });
//    }

//    vm.getList1();

//    vm.falto=function(item){
//        alert(JSON.stringify(item));
//    }

//    vm.getList2 = function () {
//        $http.get('/home/getList2').then(function (response) {
//            vm.list2 = response.data;
//        });
//    }

//    vm.getList2();

//    vm.getList3 = function () {
//        $http.get('/home/getList3').then(function (response) {
//            vm.list3 = response.data;
//        });
//    }

//    vm.getList3();


//}]);

var App = angular.module('drag-and-drop', ['ngDragDrop']);

App.controller('oneCtrl', function ($scope, $timeout) {
    $scope.list1 = [];
    $scope.list2 = [];
    $scope.list3 = [];
    $scope.list4 = [];

    $scope.list5 = [
      { 'title': 'Item 1', 'drag': true },
      { 'title': 'Item 2', 'drag': true },
      { 'title': 'Item 3', 'drag': true },
      { 'title': 'Item 4', 'drag': true },
      { 'title': 'Item 5', 'drag': true },
      { 'title': 'Item 6', 'drag': true },
      { 'title': 'Item 7', 'drag': true },
      { 'title': 'Item 8', 'drag': true }
    ];

    // Limit items to be dropped in list1
    $scope.optionsList1 = {
        accept: function (dragEl) {
            if ($scope.list1.length >= 2) {
                return false;
            } else {
                return true;
            }
        }
    };
});