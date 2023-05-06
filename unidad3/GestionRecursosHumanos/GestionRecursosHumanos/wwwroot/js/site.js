// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
	$('.accordion-title').click(function () {
		// Obtener el elemento .accordion-item más cercano al título pulsado
		var accordionItem = $(this).closest('.accordion-item');

		// Comprobar si el elemento .accordion-item está abierto o cerrado
		if (accordionItem.hasClass('active')) {
			// Si está abierto, cerrarlo
			accordionItem.removeClass('active');
			accordionItem.find('.accordion-content').slideUp();
		}
		else {
			// Si está cerrado, abrirlo
			$('.accordion-item.active').removeClass('active');
			$('.accordion-content').slideUp();
			accordionItem.addClass('active');
			accordionItem.find('.accordion-content').slideDown();
		}
	});
});