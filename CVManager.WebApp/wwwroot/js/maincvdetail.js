let rowHTML = `<iframe id="cv-preview" style="width: 100%;height: 297mm;"></iframe>`;
$('.preview-zone').append(rowHTML);

//Lấy thông tin HTML và CSS
let html = $('.html-src').val();
let css = $('.css-src').val();

$("#cv-preview")[0].srcdoc = `<html>
        <head>
            <meta name="viewport" content="width=device-width, initial-scale=1">
            <link rel="stylesheet" href="/lib/bootstrap/dist/css/bootstrap.min.css">
            <style>
                body{
                    overflow-y: scroll;
                }
                ::-webkit-scrollbar {
                    width: 10px;
                }

                /* Track */
                ::-webkit-scrollbar-track {
                    background: #f1f1f1;
                }

                /* Handle */
                ::-webkit-scrollbar-thumb {
                    background: #888;
                    border-radius: 5px;
                }

                /* Handle on hover */
                ::-webkit-scrollbar-thumb:hover {
                    background: #555;
                }
                ${css}
            </style>
            </head>
            <body>
                ${html}
        </body>
        `;

