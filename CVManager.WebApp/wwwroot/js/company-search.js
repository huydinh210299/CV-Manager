$(document).on('click', '.btn-prev', (e) => {
    let page = $('.page').val();
    page = parseInt(page) - 1;
    $('.page').val(page);
    $('#form-search').submit();
})

$(document).on('click', '.btn-next', (e) => {
    let page = $('.page').val();
    page = parseInt(page) + 1;
    $('.page').val(page);
    $('#form-search').submit();
})

$(document).on('click', '.btn-search', (e) => {
    e.preventDefault();
    let title = $('.name').val();
    let address = $('.area').val();
    $('.companyname').val(title);
    $('.address').val(address);
    $('#form-search').submit();
})

$(document).on('submit', '.form-search', (e) => {
    e.preventDefault();
    let title = $('.name').val();
    let address = $('.area').val();
    $('.companyname').val(title);
    $('.address').val(address);
    $('#form-search').submit();
})