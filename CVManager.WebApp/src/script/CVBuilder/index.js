import {editor} from './grapesjs/grapesjs.config';
import initBuilderEvent from './event/index';
import TemplateBlocks from './grapesjs/template/templates';
import GrapesJSEvent from "./grapesjs/grapesjs.event";

var bm = editor.BlockManager;

//Thêm các templates
TemplateBlocks(bm);

//Khởi tạo event cho builder
initBuilderEvent();

//Khởi tạo các event cho Grapesjs
GrapesJSEvent();

//dev editor
window.editor = editor;
