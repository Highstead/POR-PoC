var app = angular.module('MyGridApp', ['ui.grid']);

app.controller('bodyController', ['$scope', function($scope) {
    $scope.myData = [];

    $.get("http://localhost/api/ItemInventory", function(data) {
        $scope.myData = data;
    });

    /*$scope.myData = [{name: "Moroni", age: 50},
                     {name: "Tiancum", age: 43},
                     {name: "Jacob", age: 27},
                     {name: "Nephi", age: 29},
                     {name: "Nephi", age: 29},
                     {name: "Nephi", age: 29},
                     {name: "Nephi", age: 29},
                     {name: "Nephi", age: 29},
                     {name: "Enos", age: 34}];
                     */
    $scope.gridOptions = {
        data : 'myData',
        columnDefs: [
            { field: 'ItemId', displayName: 'Id' },
            { field: 'Name', displayName: 'Item Name' },
            { field: 'Category', displayName: 'Item Category' },
            { field: 'Quantity', displayName: 'Quantity' }
        ]
    };// $scope.myData is also acceptable but will not update properly. OK to use the object if you don't care about updating the data in the grid.
}]);