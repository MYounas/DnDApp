
var app = angular.module('myApp', ['dndLists']);
app.controller('myController', ['$http', function ($http) {
    var vm = this;

    vm.list1 = [];
    vm.list2 = [];
    vm.list3 = [];

    vm.getList1 = function () {
        $http.get('/home/getList1').then(function (response) {
            vm.list1 = response.data;
        });
    }

    vm.getList1();

    vm.falto=function(item){
        alert(JSON.stringify(item));
    }

    vm.getList2 = function () {
        $http.get('/home/getList2').then(function (response) {
            vm.list2 = response.data;
        });
    }

    vm.getList2();

    vm.getList3 = function () {
        $http.get('/home/getList3').then(function (response) {
            vm.list3 = response.data;
        });
    }

    vm.getList3();


}]);