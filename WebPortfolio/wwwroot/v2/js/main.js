(function ($) {
    'use strict';

    /*
    |--------------------------------------------------------------------------
    | Template Name: Portm
    | Author: Laralink
    | Version: 1.0.0
    |--------------------------------------------------------------------------
    |--------------------------------------------------------------------------
    | TABLE OF CONTENTS:
    |--------------------------------------------------------------------------
    |
    | 1. Preloader
    | 2. Mobile Menu
    | 3. Sticky Header
    | 4. Dynamic Background
    | 5. Isotop Initialize
    | 6. Carousel
    | 7. Tabs
    | 8. Counter Animation
    | 9. Progress Bar
    | 10. Cursor Animation
    |
    */

    /*--------------------------------------------------------------
      Scripts initialization
    --------------------------------------------------------------*/
    $.exists = function (selector) {
        return $(selector).length > 0;
    };

    $(window).on('load', function () {
        $(window).trigger('scroll');
        $(window).trigger('resize');
        preloader();
        isotopInit();
    });

    $(function () {
        $(window).trigger('resize');
        mainNav();
        stickyHeader();
        dynamicBackground();
        isotopInit();
        tabs();
        counterInit();
        progressBar();
        if ($.exists('.wow')) {
            new WOW().init();
        }
    });

    $(window).on('scroll', function () {
        counterInit();
    });

    setTimeout(function () {
        carousel();
    }, 500);

    /*--------------------------------------------------------------
      1. Preloader
    --------------------------------------------------------------*/
    function preloader() {
        $('.preloader_in').fadeOut();
        $('.preloader').delay(150).fadeOut('slow');
    }

    /*--------------------------------------------------------------
      2. Mobile Menu
    --------------------------------------------------------------*/
    function mainNav() {
        $('.nav').append('<span class="menu_toggle"><span></span></span>');
        $('.menu-item-has-children').append(
            '<span class="menu_dropdown_toggle"></span>',
        );
        $('.menu_toggle').on('click', function () {
            $(this)
                .toggleClass('toggle_active')
                .siblings('.nav_list')
                .slideToggle();
        });
        $('.menu_dropdown_toggle').on('click', function () {
            $(this).toggleClass('active').siblings('ul').slideToggle();
            $(this).parent().toggleClass('active');
        });
    }

    /*--------------------------------------------------------------
      3. Sticky Header
    --------------------------------------------------------------*/
    function stickyHeader() {
        var $window = $(window);
        var lastScrollTop = 0;
        var $header = $('.sticky_header');
        var headerHeight = $header.outerHeight() + 30;

        $window.scroll(function () {
            var windowTop = $window.scrollTop();

            if (windowTop >= headerHeight) {
                $header.addClass('gescout_sticky');
            } else {
                $header.removeClass('gescout_sticky');
                $header.removeClass('gescout_show');
            }

            if ($header.hasClass('gescout_sticky')) {
                if (windowTop < lastScrollTop) {
                    $header.addClass('gescout_show');
                } else {
                    $header.removeClass('gescout_show');
                }
            }

            lastScrollTop = windowTop;
        });
    }

    /*--------------------------------------------------------------
      4. Dynamic Background
    --------------------------------------------------------------*/
    function dynamicBackground() {
        $('[data-src]').each(function () {
            var src = $(this).attr('data-src');
            $(this).css({
                'background-image': 'url(' + src + ')',
            });
        });
    }

    /*--------------------------------------------------------------
      5. Isotop Initialize
    --------------------------------------------------------------*/
    function isotopInit() {
        if ($.exists('.isotop')) {
            $('.isotop').isotope({
                itemSelector: '.isotop_item',
                transitionDuration: '0.60s',
                percentPosition: true,
                masonry: {
                    columnWidth: '.grid_sizer',
                },
            });
            /* Active Class of Portfolio*/
            $('.isotop_filter ul li').on('click', function (event) {
                $(this).siblings('.active').removeClass('active');
                $(this).addClass('active');
                event.preventDefault();
            });
            /*=== Portfolio filtering ===*/
            $('.isotop_filter ul').on('click', 'a', function () {
                var filterElement = $(this).attr('data-filter');
                $('.isotop').isotope({
                    filter: filterElement,
                });
            });
        }
    }

    /*--------------------------------------------------------------
        6. Carousel
    --------------------------------------------------------------*/

    function carousel() {
        $('.featured-carousel').owlCarousel({
            loop: true,
            autoplay: true,
            autoplayTimeout: 200000,
            margin: 30,
            animateOut: 'fadeOut',
            animateIn: 'fadeIn',
            nav: true,
            dots: true,
            autoplayHoverPause: false,
            items: 1,
            navText: ["<p><span>&lsaquo;</span> Prev</p>", "<p>Next<span>&rsaquo;</span></p>"],
            responsive: {
                0: {
                    items: 1
                },
                600: {
                    items: 1
                },
                1000: {
                    items: 1
                }
            }
        });
    };

    /*--------------------------------------------------------------
      7. Tabs
    --------------------------------------------------------------*/
    function tabs() {
        $('.tabs .tab_links a').on('click', function (e) {
            var currentAttrValue = $(this).attr('href');
            $('.tabs ' + `[data-id="${currentAttrValue}"]`)
                .fadeIn(400)
                .siblings()
                .hide();
            $(this).parents('li').addClass('active').siblings().removeClass('active');
            isotopInit();
            e.preventDefault();
        });
    }

    /*--------------------------------------------------------------
      8. Counter Animation
    --------------------------------------------------------------*/
    function counterInit() {
        if ($.exists('.odometer')) {
            function winScrollPosition() {
                var scrollPos = $(window).scrollTop(),
                    winHeight = $(window).height();
                var scrollPosition = Math.round(scrollPos + winHeight / 1.2);
                return scrollPosition;
            }

            $('.odometer').each(function () {
                var elemOffset = $(this).offset().top;
                if (elemOffset < winScrollPosition()) {
                    $(this).html($(this).data('count-to'));
                }
            });
        }
    }

    /*--------------------------------------------------------------
      9. Progress Bar
    --------------------------------------------------------------*/
    function progressBar() {
        $('.progress').each(function () {
            var progressPercentage = $(this).data('progress') + '%';
            $(this).find('.progress_in').css('width', progressPercentage);
        });
    }

    /*--------------------------------------------------------------
      10. Cursor Animation
    --------------------------------------------------------------*/
    $(function () {
        $('body').append('<span class="cursor_lg d"></span>');
        $('body').append('<span class="cursor_sm"></span>');
        $('a, button').on('mouseenter', function () {
            $('.cursor_lg').addClass('opacity-0');
            $('.cursor_sm').addClass('opacity-0');
        });
        $('a, button').on('mouseleave', function () {
            $('.cursor_lg').removeClass('opacity-0');
            $('.cursor_sm').removeClass('opacity-0');
        });
    });
    function cursorMovingAnimation(event) {
        try {
            const timing = gsap.timeline({
                defaults: {
                    x: event.clientX,
                    y: event.clientY,
                },
            });

            timing
                .to('.cursor_lg', {
                    ease: 'power2.out',
                })
                .to(
                    '.cursor_sm',
                    {
                        ease: 'power2.out',
                    },
                    '-=0.4',
                );
        } catch (err) {
            console.log(err);
        }
    }
    document.addEventListener('mousemove', cursorMovingAnimation);
})(jQuery); // End of use strict
