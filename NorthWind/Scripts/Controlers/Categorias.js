function Categorias() {

}


Categorias.prototype.GetDatos = function (ruta, divDatos) {
    $.ajax({
        async: true,
        url: ruta,
        type: "GET",
        dataType: "json",
        success: function (data) {
       
            $(data).each(function (index, item) { 
                $("#" + divDatos).append("<tr><td>" + item.CategoryID + "</td><td> " + item.CategoryName + "</td></tr>"); 
            });
         
           
        }
    });


}

Categorias.prototype.Enviar = function (idForm, url, btn) {
    $("#" + btn).attr("disabled", "disabled");
    var formData = new FormData("#" + idForm[0]);

    $.ajax({
        type: "POST"
        , url: url
        , data: formData
        , cache: false
        , contentType: false
        , processData: false
        , beforeSend: function () {

        },
        success: function (data) {

            if (data == "OK") {
                $("#" + btn).delay(2000).queue(function (m) {
                    $("#" + btn).removeAttr("disabled");
                    m();
                    console.log(data);
                });

            }
           

        }


    })


}