$(document).ready(function () {
    var countryId = $('#Boards_CountrysId').val();
    var stateId = $('#stid').text();
    GetStates(countryId, stateId);
});
function GetStates(val, stateId)
{
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
                        else
                        {
                            s += '<option value="' + data[i].id + '" >' + data[i].statesName + '</option>';
                        }
                    }
                    else
                    {
                        s += '<option value="' + data[i].id + '">' + data[i].statesName + '</option>';
                    }
                }
                $('#Boards_StatesId').empty().append(s);
            }
        }
    });
}