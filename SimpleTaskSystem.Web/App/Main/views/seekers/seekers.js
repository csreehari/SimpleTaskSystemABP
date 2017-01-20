(function () {
    var controllerId = 'app.views.seekers';
    angular.module('app').controller(controllerId, [
        '$scope', 'abp.services.smps.user', function ($scope, seekerService) {
            var vm = this;
            vm.seekers = seekerService.getSeekers();
            //About logic...
        }
    ]);
})();