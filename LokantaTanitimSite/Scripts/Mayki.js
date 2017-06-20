$(document).ready(function () {
    $('#submit').click(function () {
        alert($('#name').val())
        $.post("http://localhost:59591/Home/PostMessage", {
            name: $('#name').val(),
            message: $('#comment').val(),
            eposta: $('#email').val()
        }, function (data, status) {
            if (data == "1") {
                //popup mesajınız gönderildi
            }
            else
            {
                //popup mesajı gönderildi
            }
        })

    })
})