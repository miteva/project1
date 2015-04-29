
function getBikesFromDatabase() {
    var url="http://localhost:58694/Home/GetBikes";
    $.ajax(

        {
            cache: false,
            url: url,
            type: 'post',
            dataType: 'json',
            success: function (data) {
           
                var th = "<tr><th>RegNum</th><th>Producer</th><th>Model</th><th>Colour</th><th>City</th></tr>";
                $("#tableBikes").append(th);
                $.each(data, function (i) {

                    var content = "<tr><td>" + data[i].RegNumber + "</td><td>" + data[i].Prdoucer + "</td><td>" + data[i].Model +
                        "</td><td>"+ data[i].Colour+"</td><td>"+data[i].City+"</td></tr>"
                    
                    $("#tableBikes").append(content);

                });

            },
            error: function () {
                alert("The ajax call failed");
            }
        })
}

