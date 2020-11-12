import {editor} from './grapesjs/grapesjs.config';
import initBuilderEvent from './event/index';
import TemplateBlocks from './grapesjs/template/templates';
import GrapesJSEvent from "./grapesjs/grapesjs.event";
import cheerio from "cheerio";

var bm = editor.BlockManager;

//Thêm các templates
TemplateBlocks(bm);

//Khởi tạo event cho builder
initBuilderEvent();

//Khởi tạo các event cho Grapesjs
GrapesJSEvent();

//dev editor
window.editor = editor;

window.cheerio = cheerio;

//Các lệnh thực hiện set html và css của CV khi chỉnh sửa
if($('.cv-html')){
    editor.setComponents($('.cv-html').val());
}
if($('.cv-css')){
    editor.setStyle($('.cv-css').val());
}