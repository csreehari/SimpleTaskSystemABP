(function () {
    var controllerId = 'app.views.holders';
    angular.module('app').controller(controllerId, [
        '$scope', 'abp.services.smps.user','abp.services.smps.project', function ($scope, holderService, projectService) {
            var vm = this;
            vm.holders = holderService.getHolders();
            vm.projects = projectService.getProjects();
            //About logic...
        }
    ]);
})();