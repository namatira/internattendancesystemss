"use strtict";

//String connection with SignalR Hub
var connection = new signalR.HubConnectionBuilder().withUrl("/notificationHub").build();

//Display notification (Update Notification)
connection.on("ReceiveMessage", function (user, time) {
    var encodeMsg = "<p class='dropdown-item'>" + user + "<br>" + time + " Logged" + "</p>";
    if ($('#nodata').length) {
        $('#nodata').remove();
        $(".noti-content").prepend(encodeMsg);
    }
    else {
        $(".noti-content").prepend(encodeMsg);
    }

    var count = 0;
    count = parseInt($('span.count').html()) || 0;
    count++;
    $('span.count').html(count);

});

//Start Connection with SignalR Hub
connection.start().then(function () {
}).catch(function (err) {
    return console.error(err.toString());
});


//Show Notification Bar
function showNotif() {
    var x = document.getElementById("noti-content");
    if (x.style.display === "none") {
        x.style.display = "block";
        $('span.count').html('&nbsp;');
    }
    else {
        x.style.display = "none";
    }
}

//function to send notification 
function call() {
    var user = document.getElementById("userName").value;
    var time = document.getElementById("time").value;

    connection.invoke("sendNotification", user, time).catch(function (err) {
        return console.error(err.toString());
    });
}

