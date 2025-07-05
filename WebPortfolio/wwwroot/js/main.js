"use strict";


jQuery(document).ready(function ($) {

    /*---------------------------------------------*
     * Mobile menu
     ---------------------------------------------*/
    $(document).on('click', '.navbar-collapse.in', function (e) {
        if ($(e.target).is('a')) {
            $(this).collapse('hide');
        }
    });

    /*---------------------------------------------*
     * STICKY scroll
     ---------------------------------------------*/

    $.localScroll();

    /*---------------------------------------------*
     * WOW
     ---------------------------------------------*/

    var wow = new WOW({
        mobile: false // trigger animations on mobile devices (default is true)
    });
    wow.init();

    /*---------------------------------------------*
     * Counter 
     ---------------------------------------------*/

    $('.statistic-counter').counterUp({
        delay: 10,
        time: 2000
    });

    /*---------------------------------------------*
     * Carousel
     ---------------------------------------------*/
    setTimeout(function () {
        var carousel = function () {
            $('.featured-carousel').owlCarousel({
                loop: true,
                autoplay: true,
                autoplayTimeout: 20000,
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
        carousel();
    }, 500);

    /*---------------------------------------------*
     * Modal
     ---------------------------------------------*/

    var modalContentData = {
        "mdv-intern": {
            "title": "Full Stack Development Intern (500 hrs.)",
            "date": "June 2024 - October 2024",
            "company": "My Dream Visa (MDV)",
            "link": "https://mydreamvisa.com/",
            "content": "In the summer of 2024, I volunteered as a Full Stack Development Intern to enhance my skills and gain hands-on experience. During the internship, we developed an application designed to streamline the USCIS marriage-based green card application process.",
            "contributions": "<li>Designed and enhanced UI components for responsiveness and improved UI/UX</li><li>Debugged and refactored front-end code to ensure a clean and maintainable codebase</li><li>Added a caching system to the eligibility quiz page to retain user data after registration</li><li>Implemented dynamic, auto-filling input fields to enhance the user experience</li><li>Developed and validated input formatting for phone numbers, currency, SSNs, and A-numbers</li><li>Designed and integrated an FAQ sidebar for improved site navigation and user support</li>",
            "technologies": "<li>Vue.js</li><li>Express.js</li><li>Node.js</li><li>MySQL</li><li>Quasar</li><li>Html</li><li>Css</li><li>Javascript</li><li>Typescript</li>"
        },
        "mdv-developer": {
            "title": "Part-time Full Stack Developer",
            "date": "September 2024 - Present",
            "company": "My Dream Visa (MDV)",
            "link": "https://mydreamvisa.com/",
            "content": "Following the completion of my internship, I was offered a part-time position as a Junior Full Stack Developer at My Dream Visa. In this role, I contributed to the development of new USCIS immigration services, including the Parent Green Card application, Form I-751, and Form I-129F.",
            "contributions": "<li>Enhanced page navigation by integrating custom logic and implementing a locking mechanism</li><li>Assisted in resolving user registration issues and bugs</li><li>Developed and implemented a paywall system to restrict access for unsubscribed users</li><li>Added support for maintenance mode across the front-end, back-end server, and admin panel</li>",
            "technologies": "<li>Vue.js</li><li>Express.js</li><li>Node.js</li><li>MySQL</li><li>Quasar</li><li>Html</li><li>Css</li><li>Javascript</li><li>Typescript</li>"
        }
    };

    $('#workExpModal').on('show.bs.modal', function (event) {
        var button = $(event.relatedTarget);
        var role = button.data('role');
        var data = modalContentData[role];

        var modal = $(this);
        modal.find('.modal-title').text(data.title);
        modal.find('#modalDate').text(data.date);
        modal.find('#modalCompanyLink').text(data.company).attr('href', data.link);
        modal.find('#modalContent').html(data.content);
        modal.find('#modalContributions').html(data.contributions);
        modal.find('#modalTechnologies').html(data.technologies);
    });

    // main-menu-scroll

    jQuery(window).scroll(function () {
        var top = jQuery(document).scrollTop();
        var height = 300;

        if (top > height) {
            jQuery('.navbar-fixed-top').addClass('menu-scroll');
        } else {
            jQuery('.navbar-fixed-top').removeClass('menu-scroll');
        }
    });

    // scroll Up

    $(window).scroll(function () {
        if ($(this).scrollTop() > 600) {
            $('.scrollup').fadeIn('slow');
        } else {
            $('.scrollup').fadeOut('slow');
        }
    });

    $('.scrollup').click(function () {
        $("html, body").animate({ scrollTop: 0 }, 1000);
        return false;
    });

    $('#mixcontent').mixItUp({
        animation: {
            animateResizeContainer: false,
            effects: 'fade rotateX(-45deg) translateY(-10%)'
        }
    });

    //End
});
