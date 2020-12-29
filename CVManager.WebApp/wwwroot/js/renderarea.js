{
    let data = [];
    let address = $('.address').val() ? $('.address').val() : "";
    Object.keys(quanhuyen).forEach(key => {
        data.push(quanhuyen[key]['name']);
    });
    for (let i = 0; i < data.length; i++) {
        if (data[i] === address) {
            $('.area').append(`<option value="${data[i]}" selected>${data[i]}</option>`)
        }
        else {
            $('.area').append(`<option value="${data[i]}">${data[i]}</option>`)
        }
    }
}