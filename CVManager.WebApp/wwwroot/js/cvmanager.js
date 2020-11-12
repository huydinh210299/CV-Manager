//Hàm thực hiện đặt làm CV chính
$(document).on('click', '.btn-set-mainCV', async function(e){
    let cvID = $(this).attr('cv-id');
    const data = {
        CvID: cvID
    }
    let token = get_cookie("jwt");
    if (token === "") {
        alert("Bạn chưa đăng nhập hoặc không có quyền thực hiện thao tác này");
    }
    else {
        const rs = await $.ajax({
            type: "POST",
            url: "/api/cv/maincv",
            contentType: "application/json",
            headers: {
                "Authorization": `Bearer ${token}`
            },
            data: JSON.stringify(data)
        });
        alert(rs.statusText);
        window.location.reload();
    }
})