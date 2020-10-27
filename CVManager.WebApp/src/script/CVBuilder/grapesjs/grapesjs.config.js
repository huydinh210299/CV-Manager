export const editor = grapesjs.init({
    container: '#gjs',
    fromElement: true,
    width: '210mm',
    storageManager: false,
    panels: { defaults: [] },
    blockManager: {
        appendTo: '#blocks',
    },
    canvas: {
        styles: [
            "/lib/bootstrap/dist/css/bootstrap.min.css"
        ],
        scripts: [
            
        ],
    },

    plugins: [
        "gjs-plugin-ckeditor"
    ],

    pluginsOpts: {
        "gjs-plugin-ckeditor": {
            position: "center",
            options: {
                startupFocus: true,
                extraAllowedContent: "*(*);*{*}", // Allows any class and any inline style
                allowedContent: true, // Disable auto-formatting, class removing, etc.
                enterMode: CKEDITOR.ENTER_BR,
                language: "vi",
                extraPlugins: "sharedspace,justify,colorbutton,panelbutton,font",
                removePlugins: 'magicline',
                toolbar: [{
                        name: "styles",
                        items: ["Font", "FontSize"]
                    },
                    ["Bold", "Italic", "Underline", "Strike"],
                    {
                        name: "paragraph",
                        items: [
                            "Outdent",
                            "Indent",
                            "NumberedList",
                            "BulletedList",
                            "-",
                            "JustifyLeft",
                            "JustifyCenter",
                            "JustifyRight",
                            "JustifyBlock",
                        ],
                    },
                    {
                        name: "links",
                        items: ["Link", "Unlink"]
                    },
                    {
                        name: "colors",
                        items: ["TextColor", "BGColor"]
                    },
                ],
                //font_names: resourceLandingPage.CKEDITOR.font_names_arr.join(';'),
                //contentsCss: resourceLandingPage.CKEDITOR.contents_Css,
                on: {
                    focus: function () {
                        this.execCommand("selectAll");
                    },
                },
            },
        },
    },

})
