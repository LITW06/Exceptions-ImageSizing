$(() => {
    $("#upload").on('click', function() {
        var formData = new FormData();
        const file = $("#image")[0].files[0];
        formData.append('image', file);
        $("#upload").button('loading');

        $.ajax({
            url: '/home/upload',
            type: 'POST',
            data: formData,
            processData: false,
            contentType: false,
            success: function ({name}) {
                window.location.href = `/oilpaints/${name}`;
            }
        });
    });
});