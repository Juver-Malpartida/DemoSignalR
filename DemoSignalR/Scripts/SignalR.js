(
function () {
    var myHub = $.connection.myHub;
    $.connection.hub.start()
        .done(function () {
            writeToDisplay("Working");
            myHub.server.announce("Connected!");
        })
        .fail(function () { writeToDisplay("error!"); });

    myHub.client.announce = function (message) {
        writeToDisplay(message);
    }

    var writeToDisplay = function (message) {
        $("#welcome-messages").append(message + "<br/>");
    }
}
)()
