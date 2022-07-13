$(document).ready(function () {
    $('.select2').select2({
        theme: "classic",
        allowClear: true,
        placeholder:"Select"
    });
    $('#Boards_CountrysId').select2({
        theme: "classic",
        //allowClear: true,
        placeholder:"Select"
    });
    $('#UnsolvedPaper_CountrysId').select2({
        theme: "classic",
        allowClear: false,
        placeholder:"Select"
    });
});