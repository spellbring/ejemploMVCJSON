function Categorias() {
    
}

Categorias.prototype.ObtainJson = function ()
{
    e.preventDefault();
    var aData= [];
    aData[0] = $("#ddlSelectYear").val(); 
    $("#contentHolder").empty();
    var jsonData = JSON.stringify({ aData:aData});
    $.ajax({
        type: "POST",
        //getListOfCars is my webmethod   
        url: "WebService.asmx/getListOfCars",
        data: jsonData,
        contentType: "application/json; charset=utf-8",
        dataType: "json", // dataType is json format
        success: OnSuccess,
        error: OnErrorCall
    });

    function OnSuccess(response) {
        console.log(response.d)
    }
    function OnErrorCall(response) { console.log(error); }


}

