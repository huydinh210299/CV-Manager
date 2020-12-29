
//Hàm thực hiện chức năng đăng ký
$(document).on('submit', '#form-register', async function(e){
    e.preventDefault();

    const username = $('#form-register [name="username"]').val();
    const password = $('#form-register [name="password"]').val();
    const password_again = $('#form-register [name="password-again"]').val();
    const name = $('#form-register [name="name"]').val();
    const school = $('#form-register [name="school"]').val();
    const phone = $('#form-register [name="phone"]').val();
    const email = $('#form-register [name="email"]').val();
    const area = $('#form-register [name="area"]').val();
    const data = {
        username : username,
        password : password,
        name : name,
        school : school,
        phone : phone,
        email : email,
        area : area,
    }
    if(password !== password_again){
        $('.warning').text("Mật khẩu không trùng khớp");
    }
    else{
        const rs = await $.ajax({
            type: "POST",
            url: "/api/user/register",
            contentType :"application/json",
            data : JSON.stringify(data)
        });
        if(rs.statusCode === 200){
            $('.success').text(rs.statusText);
        }
        if(rs.statusCode === 400){
            $('.warning').text(rs.statusText);
        }    
    }
});

//Hàm thực hiện chức năng đăng nhập
$(document).on('submit', '#form-login', async function(e){
    e.preventDefault();
    //get data
    const username = $('#form-login [name="username"]').val();
    const password = $('#form-login [name="password"]').val();

    const data = {
        username : username,
        password : password,
    }

    const rs = await $.ajax({
        type: "POST",
        url: "/api/user/login",
        contentType :"application/json",
        data : JSON.stringify(data)
    });
    if(rs.statusCode === 400){
        $('.warning').text(rs.statusText);
    }
    if(rs.token){
        set_cookie("jwt", rs.token);
        $('.success').html("Đăng nhập thành công. Mời quay lại <a href='/'>trang chính</a>");
    }

})

//Hàm thực hiện chức năng logout
$(document).on('click', '.logout-btn', function (e) {
    delete_cookie('jwt');
    window.location.replace("/");
})