function Delete(url) {
    swal({
        title: "Are you sure?",
        text: "Once Deleted, you will not be able to recover",
        icon: "warning",
        buttons: true,
        dangerMode: true
    }).then((willDelete) => {
        if (willDelete) {
            $.ajax({
                type: "DELETE",
                url: url,
                success: function (data) {
                    if (data.success) {
                        swal({
                            title: "Success",
                            content: "Successfully Deleted",
                            icon: "success",
                        }).then((ok) => {
                            location.reload()
                        });
                    }
                    else {
                        swal({
                            title: "Error",
                            content: "Error Occurs",
                            icon: "Error"
                        }).then((ok) => {
                            location.reload()
                        });
                    }
                }
            });
        }
    });
}