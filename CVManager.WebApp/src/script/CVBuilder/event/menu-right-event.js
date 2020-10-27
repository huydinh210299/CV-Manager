import $ from 'jquery';
import { editor } from '../grapesjs/grapesjs.config';

export default class MenuLeftEvent{
    constructor() {
        this.initEvent();
    }

    initEvent(){
        $(document).on("click", ".cv-builder-switch-menu-item", this.onSwitchMenuItemClick.bind(this));
        $(document).on("change", ".progress-value", this.onSelectedProgressValue.bind(this));
    }

    //Hàm thực hiển chuyển tab
    onSwitchMenuItemClick(e) {
        let menuItem = e.target;
        let tabName = $(menuItem).attr('tab-name');
        $(`.${tabName}-content`).siblings().hide('fast');
        $(menuItem).siblings().removeClass('active');
        $(`.${tabName}-content`).show('fast');
        $(menuItem).addClass('active');
    }

    //Hàm thực hiện chọn value cho progress bar
    onSelectedProgressValue(e){
        let selectedComp = editor.getSelected();
        let classes = selectedComp.getClasses();
        let classLength = classes.length;
        if(!(classes[`${classLength}`] === "advance-component")){
            selectedComp = selectedComp.find('.progress-bar')[0];
        }
        let selectEl = e.target;
        let progressVal = $(selectEl).val();
        selectedComp.setStyle({
            ...selectedComp.getStyle(),
            "width" : `${progressVal}%`
        });
    }
}