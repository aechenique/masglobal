var employeeApp = angular.module('employeeApp', []);

employeeApp.controller('EmployeeListController', function EmployeeListController($scope, $http) {
    $scope.employees = [];
    $scope.query = "";
    $scope.getList = function getList() {
        var id = $scope.query;

        if (id && isNaN(id)) {
            alert("The value must be an integer or blank!");
            return false;
        }

        $http.get('/Api/Employees/' + id).then(function (response) {
            $scope.employees = response.data;
        });
    };
});