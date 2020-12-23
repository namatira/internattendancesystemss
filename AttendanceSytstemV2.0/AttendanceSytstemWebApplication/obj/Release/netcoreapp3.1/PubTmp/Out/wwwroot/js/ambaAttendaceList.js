var dataTable;


$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#AmbaTable_Load').DataTable({
        "processing": true,
        "ajax": {
            "url": "/api/ambassador",
            "type": "GET",
            "datatype": "json",

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
                "width": "30%"
            }  
        ],
        "language": {
            "emptyTable": "no data found"
        },
        width: "100%"
    })
}