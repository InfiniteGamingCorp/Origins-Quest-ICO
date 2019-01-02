$(document).ready(function () {

    $("#frmContactForm").on('submit', function (e) {

        e.preventDefault() // prevent the form's normal submission

        var dataToPost = $(this).serialize();        

        $.post("Site/ContactFormAsync", dataToPost, function (data, status) {
            if (data.success) {
                ClearContactForm();
                Swal(
                    'Contact Us',
                    'Your message has been sent.',
                    'success'
                )
            }
            else {
                Swal(
                    'Contact Us',
                    'There as a problem sending your message.',
                    'error'
                )
            }
        });
    })

    $("#frmSubscribe").on('submit', function (e) {

        e.preventDefault() // prevent the form's normal submission

        //var dataToPost = $(this).serialize();

        var dataToPost = "{'SubscriberEmail':'" + $('#SubscriberEmail').val() + "'}";

        $.ajax({
            url: "Site/SubscribeAsync",
            type: "POST",
            dataType: 'json',
            data: dataToPost,
            cache: false,
            contentType: "application/jsonrequest; charset=utf-8",
            success: function (data) {
                if (data.success) {
                    ClearSubscribeForm();
                    Swal(
                        'Newsletter',
                        'You have been added to our newsletter list.',
                        'success'
                    )
                }
                else {
                    Swal(
                        'Newsletter',
                        'There as a problem subscribing to the newsletter.',
                        'error'
                    )
                }
            }
        });

        //$.post("Site/SubscribeAsync", dataToPost, function (data, status) {
        //    if (data.success) {
        //        ClearSubscribeForm();
        //        Swal(
        //            'Newsletter',
        //            'You have been added to our newsletter list.',
        //            'success'
        //        )
        //    }
        //    else {
        //        Swal(
        //            'Newsletter',
        //            'There as a problem subscribing to the newsletter.',
        //            'error'
        //        )
        //    }
        //});
    })

});

function ClearContactForm() {
    $('#Name').val('');
    $('#Email').val('');
    $('#Comment').val('');
}

function ClearSubscribeForm() {
    $("#frmSubscribe input[name=SubscribeEmail]").val('');
}