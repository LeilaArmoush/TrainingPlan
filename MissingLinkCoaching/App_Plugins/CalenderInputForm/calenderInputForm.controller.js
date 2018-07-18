angular.module('umbraco').controller('CalenderInputForm.CalenderInputFormController', // inject umbracos assetsService
    function ($scope, assetsService) {

        $scope.items = [
            { ID: '000001', Title: 'Chicago' },
            { ID: '000002', Title: 'New York' },
            { ID: '000003', Title: 'Washington' },
        ];
        // tell the assetsService to load the markdown.editor libs from the markdown editors
        // plugin folder
        assetsService
            .load([
                "~/App_Plugins/MarkDownEditor/lib/markdown.converter.js",
                "~/App_Plugins/MarkDownEditor/lib/markdown.sanitizer.js",
                "~/App_Plugins/MarkDownEditor/lib/markdown.editor.js",
                "https://ajax.googleapis.com/ajax/libs/angularjs/1.6.9/angular.min.js",
                "https://ajax.googleapis.com/ajax/libs/angularjs/1.6.9/angular-animate.js"
            ])
            .then(function () {
                // this function will execute when all dependencies have loaded
                alert("editor dependencies loaded");
            });

        // load the separate css for the editor to avoid it blocking our js loading
        assetsService.loadCss("~/App_Plugins/MarkDownEditor/lib/markdown.css");

        var converter2 = new Markdown.Converter();
        var editor2 = new Markdown.Editor(converter2, "-" + $scope.model.alias);
        editor2.run();

    });