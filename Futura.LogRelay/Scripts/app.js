var app = angular.module("app", ["ngAnimate", "ngTouch", "ui.grid"]);

app.controller("MainCtrl",
[
    "$scope", "$http", "uiGridConstants", function($scope, $http, uiGridConstants) {

        $scope.myData = [];
        $scope.gridOptions = {
            enableFiltering: true,
            data: [],
            columnDefs: [
                { field: "TimeStamp", displayName: "Date", width: 225, enableFiltering: false },
                {
                    field: "Level",
                    displayName: "Level",
                    width: 100,
                    filter: {
                        //term: "Info",
                        noTerm: true,
                        type: uiGridConstants.filter.SELECT,
                        selectOptions: [
                            { value: "Fatal", label: "Fatal" },
                            { value: "Error", label: "Errors" },
                            { value: "Warn", label: "Warnings" },
                            { value: "Info", label: "Info" },
                            { value: "Debug", label: "Debug" },
                            { value: "Trace", label: "Trace" }
                        ]
                    }
                },
                { field: "Message", cellClass: "Message", minWidth: 500, maxWidth: 1000, enableFiltering: false }
            ],
            sortInfo: { fields: ["TimeStamp"], directions: ["desc"] },
            afterSelectionChange: function(rowItem, event) { alert(rowItem.entity.Message); }
        };

        $scope.changeData = function(logEvent) {
            $scope.gridOptions.data.push(logEvent);
        };

    }
]);