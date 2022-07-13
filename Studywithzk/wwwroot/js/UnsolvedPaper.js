$(document).ready(function () {
    var countryId = $('#UnsolvedPaper_CountrysId').val();
    var stateId = $('#stid').text();
    var boardid = $('#boardid').text();
    GetStates(countryId, stateId);
    GetBoard(stateId, boardid);


    ClassicEditor.create(document.querySelector('#editor'), {
    })
        //.plugins.addExternal('ckeditor_wiris', 'https://www.wiris.net/demo/plugins/ckeditor/', 'plugin.js')
        //.config.toolbar_Full.push({ name: 'wiris', items: ['ckeditor_wiris_formulaEditor', 'ckeditor_wiris_formulaEditorChemistry'] })
        //.then(editor => {
        //	window.editor = editor;
        //})
        .catch(err => {
            console.error(err.stack);
        });
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
