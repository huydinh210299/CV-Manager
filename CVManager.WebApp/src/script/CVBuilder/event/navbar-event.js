import $ from 'jquery';
import { editor } from '../grapesjs/grapesjs.config';

export default class NavbarEvent {
    constructor() {
        this.initEvent();
    }

    initEvent() {
        $(document).on('click', '.cancel-cv-template', this.cancelCVTemplate);
        $(document).on('click', '.save-cv', this.openModalSave);
    }

    //Hàm thực hiện bỏ mẫu CV đang dùng
    cancelCVTemplate() {
        var r = confirm("Bạn có chắc muốn bỏ mẫu CV đang dùng!");
        if (r == true) {
            editor.setComponents();
        } else {
        }
    }

    //Hàm thực hiện bật modal save CV
    openModalSave(){
        $('.btn-open-modal-create').trigger('click');
    }

}