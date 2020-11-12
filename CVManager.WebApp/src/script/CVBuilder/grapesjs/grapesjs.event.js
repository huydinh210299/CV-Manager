import { editor } from './grapesjs.config';
import suggestion from '../common/suggestion';

const GrapesJSEvent = () => {

    //Sự kiện khi select vào component
    editor.on('component:selected', (some, argument) => {
        //Hiển thị phần gợi ý
        let selected = some.getEl();
        let cvoBlockName = null;
        if ($(selected).hasClass('cvo-block')) {
            cvoBlockName = $(selected).attr('cvo-block-name');
        }
        else {
            if ($(selected).closest('.cvo-block')) {
                let cvoBlock = $(selected).closest('.cvo-block');
                cvoBlockName = $(cvoBlock).attr('cvo-block-name');
            }
        }
        if (cvoBlockName != null) {
            let suggest = suggestion[`${cvoBlockName}`];
            $('.suggestion-title').text(suggest.title);
            $('.suggestion-icon').css('background-image', `url(${suggest.path})`);
            $('.suggestion-body').html(suggest.content);
        } else {
            $('.suggestion-title').text("Hướng dẫn");
            $('.suggestion-icon').css('background-image', `url('/content/icon/icon-info.svg')`);
            $('.suggestion-body').html(`<div>
            <h4>Lưu ý: Kéo mẫu CV cần dùng vào khung!</h4> <br/>
            1. Điền đầy đủ các thông tin hiển thị trong CV<br/>
            2. Bấm nút Lưu CV<br/>
            3. Xem & Tải CV về máy<br/>
            Một số lưu ý chung:<br/>
            &nbsp;•Sắp xếp thời gian theo thứ tự mới -> cũ.<br/>
            &nbsp;•Ưu tiên những gì quan trọng, có liên quan đến vị trí ứng tuyển lên đầu.<br/>
            &nbsp;•Ngày tháng nên dùng: 01/2016, 01-2016 hoặc Jan 2016</div><br/>
            `);
        }

        //Hiển thị style manager riêng cho component: ví dụ: progressbar
        if (selected.classList.contains('advance-component')) {
            let adStyleName = $(selected).attr('advance-component-name');
            $(`.${adStyleName}-style`).show();
            $(`.${adStyleName}-style`).siblings().hide();
        }
        else {
            $('.advance-style').hide();
        }
    });

    //Hàm thực hiện xóa ckeditor cũ khi kéo thả một component
    editor.on('component:drag:start', (some, argument) => {
        if ($(`#cke_${some.target.ccid}`)) {
            $(`#cke_${some.target.ccid}`).remove();
        }
    });


    //Hàm thực hiện lấy kiểu CV khi drag vào
    editor.on('block:drag:stop', (some, argument) => {
        let srcImgType = $($.parseHTML(argument.attributes.label)[0]).attr('src');
        console.log(srcImgType)
        $('.type').val(srcImgType);
    });

    $(document).ready(function () {
        const categories = editor.BlockManager.getCategories();
        categories.each(category => {
            category.set('open', false).on('change:open', opened => {
                opened.get('open') && categories.each(category => {
                    category !== opened && category.set('open', false)
                })
            })
        })
    })
}

export default GrapesJSEvent;