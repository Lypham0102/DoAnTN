(function () {
    'use strict';

    setTimeout(function () {
        $('.loader_bg').fadeToggle();
    }, 1500);

    angular
        .module('app')
        .directive('script', script);

    script.$inject = ['$window'];

})();
