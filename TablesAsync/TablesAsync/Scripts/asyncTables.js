var initTables = () => {
	var isMobile;

	const fetchTable = () => {

		isMobile = window.innerWidth < 768;

		$.ajax({
			url: isMobile ? '/Table/Mobile' : '/Table/Desktop',
			contentType: 'application/html; charset=utf-8',
			type: 'GET',
			dataType: 'html',
			success: (result) => {
				$('#tableRoot').html(result);
			},
			error: (xhr, status) => {
				alert(status);
			}
		});
	};

	$(document).ready(() => {
		fetchTable();
	});

	$(window).resize(() => {
		if (isMobile != (window.innerWidth < 768)) {
			fetchTable();
		}
	});
}