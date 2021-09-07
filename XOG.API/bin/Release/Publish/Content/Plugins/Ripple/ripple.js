
(function ($) {
    "use strict";
    $.fn.ripple = function (options) {
        var settings = $.extend(true, {}, $.fn.ripple.defaults, options);
        this.bind("taphold", {duration: 200}, function (event) { 
            $(this).css({ "overflow": "hidden" });
            var $div = $('<div/>'), btnOffset = $(this).offset(), xPos = event.pageX - btnOffset.left, yPos = event.pageY - btnOffset.top;
            $div.addClass('ripple-effect');
            var $ripple = $(".ripple-effect");
            $ripple.css("height", $(this).height());
            $ripple.css("width", $(this).height());
            $div.css({
                top: yPos - ($ripple.height() / 2),
                left: xPos - ($ripple.width() / 2),
                background: settings.rippleColor
            }).appendTo(this);

            window.setTimeout(function () {
                $div.remove();
            }, 2000);
        });
    };
    $.fn.ripple.defaults = {
        rippleColor: '#fff'
    };
}(jQuery));

//(function ($) {
//  $('.ripple').ripple();
//  $('.ripple-dark').ripple({ rippleColor: '#333' });
//}(jQuery));