import MenuLeftevent from './menu-right-event';
import NavbarEvent from './navbar-event';
export default function(){
    $(document).ready(function () {
        new MenuLeftevent();
        new NavbarEvent();
    })
}