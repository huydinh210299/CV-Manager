
$(document).on('click', '.btn-save-cv', async function () {
    let page = editor.getHtml();
    let token = get_cookie("jwt");
    if (page === "") {
        alert("Chưa có nội dung CV");
    }
    else if (token === "") {
        alert("Bạn chưa đăng nhập hoặc không có quyền thực hiện thao tác này");
    }
    else {
        const dom = cheerio.load(page);
        const name = dom('.cvo-profile-fullname').text();
        const cvName = $('.cv-name').val();
        const phone = dom('.cvo-profile-phone').text();
        const email = dom('.cvo-profile-email').text();
        const html = editor.getHtml();
        const css = editor.getCss();
        const type = $('.type').val();
        const data = {
            name: name,
            cvname: cvName,
            phone: phone,
            email: email,
            html: html,
            css: css,
            type: type,
        }

        var rs = await $.ajax({
            type: "POST",
            url: "/api/cv/create",
            headers: {
                "Authorization": `Bearer ${token}`
            },
            contentType: "application/json",
            data: JSON.stringify(data)
        });

        if (rs.statusCode === 200) {
            console.log("done");
        }

        if (rs.statusCode === 400) {
            console.log("fail");
        }

    }
});


$(document).on('click', '.btn-edit-cv', async function () {
    let page = editor.getHtml();
    let token = get_cookie("jwt");
    if (token === "") {
        alert("Bạn chưa đăng nhập hoặc không có quyền thực hiện thao tác này");
    }
    else {
        const dom = cheerio.load(page);
        const name = dom('.cvo-profile-fullname').text();
        const phone = dom('.cvo-profile-phone').text();
        const email = dom('.cvo-profile-email').text();
        const html = editor.getHtml();
        const css = editor.getCss();
        const ID = $('.cv-id').val();
        const data = {
            name: name,
            phone: phone,
            email: email,
            html: html,
            css: css,
            ID: ID,
        }
        var rs = await $.ajax({
            type: "POST",
            url: "/api/cv/edit",
            headers: {
                "Authorization": `Bearer ${token}`
            },
            contentType: "application/json",
            data: JSON.stringify(data)
        });

        alert(rs.statusText);

    }
});
