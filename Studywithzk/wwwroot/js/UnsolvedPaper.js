$(document).ready(function () {
    var countryId = $('#UnsolvedPaper_CountrysId').val();
    var stateId = $('#stid').text();
    var boardid = $('#boardid').text();
    GetStates(countryId, stateId);
    GetBoard(stateId, boardid);

    var mathElements = [
        'math',
        'maction',
        'maligngroup',
        'malignmark',
        'menclose',
        'merror',
        'mfenced',
        'mfrac',
        'mglyph',
        'mi',
        'mlabeledtr',
        'mlongdiv',
        'mmultiscripts',
        'mn',
        'mo',
        'mover',
        'mpadded',
        'mphantom',
        'mroot',
        'mrow',
        'ms',
        'mscarries',
        'mscarry',
        'msgroup',
        'msline',
        'mspace',
        'msqrt',
        'msrow',
        'mstack',
        'mstyle',
        'msub',
        'msup',
        'msubsup',
        'mtable',
        'mtd',
        'mtext',
        'mtr',
        'munder',
        'munderover',
        'semantics',
        'annotation',
        'annotation-xml'
    ];
    CKEDITOR.plugins.addExternal('ckeditor_wiris', 'https://ckeditor.com/docs/ckeditor4/4.19.0/examples/assets/plugins/ckeditor_wiris/', 'plugin.js');
    CKEDITOR.replace('ContentData', {
        extraPlugins: 'ckeditor_wiris',
        // For now, MathType is incompatible with CKEditor file upload plugins.
        removePlugins: 'uploadimage,uploadwidget,uploadfile,filetools,filebrowser',
        height: 320,
        // Update the ACF configuration with MathML syntax.
        extraAllowedContent: mathElements.join(' ') + '(*)[*]{*};img[data-mathml,data-custom-editor,role](Wirisformula)',
        removeButtons: 'PasteFromWord'
    });
    CKEDITOR.config.pasteFromWordPromptCleanup = false;
    CKEDITOR.config.pasteFromWordRemoveFontStyles = false;
    CKEDITOR.config.pasteFromWordRemoveStyles = false;
});

function GetStates(val, stateId) {
    $.ajax({
        type: "GET",
        url: '/Admin/Boards/GetState',
        data: { CountryId: val },
        success: (data) => {
            if (data !== null) {
                var s = '<option value="">Select</option>';
                for (var i = 0; i < data.length; i++) {
                    if (stateId != undefined || stateId != 0) {
                        if (stateId == data[i].id) {
                            s += '<option value="' + data[i].id + '" selected>' + data[i].statesName + '</option>';
                        }
                        else {
                            s += '<option value="' + data[i].id + '" >' + data[i].statesName + '</option>';
                        }
                    }
                    else {
                        s += '<option value="' + data[i].id + '">' + data[i].statesName + '</option>';
                    }
                }
                $('#UnsolvedPaper_StatesId').empty().append(s);
            }
        }
    });
}
function GetBoard(val, BoardId) {
    $.ajax({
        type: "GET",
        url: '/Admin/Papers/GetBoard',
        data: { BoardsId: val },
        success: (data) => {
            if (data !== null) {
                var s = '<option value="">Select</option>';
                for (var i = 0; i < data.length; i++) {
                    if (BoardId != undefined || BoardId != 0) {
                        if (BoardId == data[i].id) {
                            s += '<option value="' + data[i].id + '" selected>' + data[i].boardName + '</option>';
                        }
                        else {
                            s += '<option value="' + data[i].id + '" >' + data[i].boardName + '</option>';
                        }
                    }
                    else {
                        s += '<option value="' + data[i].id + '">' + data[i].boardName + '</option>';
                    }
                }
                $('#UnsolvedPaper_BoardsId').empty().append(s);
            }
        }
    });
}
function checkpdf()
{
    var val = $('input[type=file]').val().toLowerCase();
    var regex = new RegExp("(.*?)\.(pdf)$");
    if (!(regex.test(val))) {
        alert("Please Uplaod a Pdf File");
        $('#Paper').val('');
    }
}
