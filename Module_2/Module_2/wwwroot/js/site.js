function getInfo(id) {

    $.post("/Home/GetInfo", { id: id })
        .done(function (data) {

            var count = data.length;
            console.log(count);

            var result_str = "";
            for (var i = 0; i < count; i++) {
                console.log(data[i]);
                result_str = result_str + " " + data[i];
            }
            $("#result_text").html(result_str);
            console.log(data);
        });
}
