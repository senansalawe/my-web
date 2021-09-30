// global
// resize image in the window
$(function (){
    'use strict';
    var myHeader = $('.header');
    myHeader.height($(window).height());
    $(window).resize(function () {
        myHeader.height($(window).height());
    });
    // resize image in the window
    // =================================
    // add active for links (new for me 01)
    $('.links li').click(function() {
        $(this).addClass('active').siblings().removeClass('active')
    });
    // add active for links (new for me 01)
    // =================================
});