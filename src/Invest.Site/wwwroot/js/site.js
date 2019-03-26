$('#carousel').owlCarousel({
	loop: true,
	margin: -1,
	items: 1,
	nav: true,
	navText: ['<i class="ion-ios-arrow-back" aria-hidden="true"></i>', '<i class="ion-ios-arrow-forward" aria-hidden="true"></i>'],
	autoplay: true,
	autoplayTimeout: 3000,
	autoplayHoverPause: true
});

$('#property-carousel').owlCarousel({
	loop: true,
	margin: 30,
	responsive: {
		0: {
			items: 1,
		},
		769: {
			items: 2,
		},
		992: {
			items: 3,
		}
	}
});


$('.intro-carousel').on('translate.owl.carousel', function () {
	$('.intro-content .intro-title').removeClass('zoomIn animated').hide();
	$('.intro-content .intro-price').removeClass('fadeInUp animated').hide();
	$('.intro-content .intro-title-top, .intro-content .spacial').removeClass('fadeIn animated').hide();
});

$('.intro-carousel').on('translated.owl.carousel', function () {
	$('.intro-content .intro-title').addClass('zoomIn animated').show();
	$('.intro-content .intro-price').addClass('fadeInUp animated').show();
	$('.intro-content .intro-title-top, .intro-content .spacial').addClass('fadeIn animated').show();
});
