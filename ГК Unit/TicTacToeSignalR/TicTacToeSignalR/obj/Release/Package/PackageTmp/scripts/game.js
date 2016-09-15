$(function () {
    var game = $.connection.myHub;
    var check = true;
    var canSetWay = true;

    game.client.playerCanSetWay = function() {
        canSetWay = true;
        $('#info').text("Ваш ход");
    };

    game.client.setCheck = function (x, y) {
        $('#table').find('tr').eq(y).find('td').eq(x).find('img').each(function () {
            if (check) {
                check = false;
                this.src = "http://tictactoesignalr.azurewebsites.net/Images/x.png";
            } else {
                check = true;
                this.src = "http://tictactoesignalr.azurewebsites.net/Images/o.png";
            }
        });
        $('#info').text("Ход соперника");
    };

    game.client.endGame = function (message) {
        canSetWay = true;
        for (i = 0; i < 3; i++) {
            for (k = 0; k < 3; k++) {
                $('#table').find('tr').eq(i).find('td').eq(k).find('img').each(function () {
                    this.src = "http://tictactoesignalr.azurewebsites.net/Images/circle.png";
                });
            }
        }
        $('#info').text(message);
    };

    $.connection.hub.start().done(function () {
        game.server.playerConnected();
        $('td').click(function () {
            if (canSetWay) {
                var col = $(this).parent().children().index($(this));
                var row = $(this).parent().parent().children().index($(this).parent());
                game.server.send(col, row);
                canSetWay = false;
            }
        });
    });
});