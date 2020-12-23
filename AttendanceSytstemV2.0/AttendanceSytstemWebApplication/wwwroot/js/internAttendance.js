var dataTable;


$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#InternTable_Load').DataTable({
        "ajax": {
            "url": "/api/interns",
            "type": "GET",
            "datatype": "json"

        },
        "columns": [
            {
                "data": "date",
                "width": "20%",
                "render": function (data) {
                    return moment(data).format('DD MMMM YYYY')
                },
            },
            {
                "data": "time",
                "width": "20%",
                "render": function (data) {
                    return moment(data).format('HH:mm:ss')
                },
            },
            {
                "data": "status",
                "width": "20%",
                "render": function (data) {
                    if (data == 1) {
                        return "In Time"
                    }
                    else if (data == 2) {
                        return "Out Time"
                    }
                },
            }
        ],
        "language": {
            "emptyTable": "no data found"
        },
        "width": "100%"
    });
}
function Delete(url) {
    swal({
        title: "Are you sure?",
        text: "Once deleted, you will not be able to recover",
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
                        toastr.success(data.message);
                        dataTable.ajax.reload();
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            });
        }
    });
}