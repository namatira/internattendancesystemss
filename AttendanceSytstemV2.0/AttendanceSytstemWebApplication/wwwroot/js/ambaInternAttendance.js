var dataTable;


$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#InternAtten_Load').DataTable({
        "processing": true,
        "ajax": {
            "url": "/api/AmbassadorInternSchedule",
            "type": "GET",
            "datatype": "json",

        },
        "columns": [
            {
                "data": "username",
                "width": "10%"
            },
            {
                "data": "date",
                "width": "10%",
                "render": function (data) {
                    return moment(data).format('d MMMM YYYY')
                },
            },
            {
                "data": "time",
                "width": "10%",
                "render": function (data) {
                    return moment(data).format('h:mm a')
                }
            },
            {
                "data": "status",
                "render": function (data) {
                    if (data == 1) {
                        return "In Time"
                    }
                    else if (data == 2) {
                        return "Out Time"
                    }
                },
                "width": "10%"
            },
            {
                "data": "id",
                "render": function (data) {
                    return `<div class="text-center">
                        <a href="EditInternAttendance?id=${data}" class='btn btn-success text-white' style='cursor:pointer; width:70px;'>
                            Edit
                        </a>
                        &nbsp;
                        <a class='btn btn-danger text-white' style='cursor:pointer; width:70px;'
                            onclick=Delete('/api/AmbassadorInternSchedule?id='+${data})>
                            Delete
                        </a>
                        </div>`;
                }, "width": "40%"
            }
        ],
        "language": {
            "emptyTable": "no data found"
        },
        width: "100%"
    })
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