$(function () {
    var game = $.connection.myHub;
    var check = true;
    var canSetWay = true;

    game.client.playerCanSetWay = function() {
        canSetWay = true;
    };

    game.client.setCheck = function (x, y) {
        $('#table').find('tr').eq(y).find('td').eq(x).find('img').each(function () {
            if (check) {
                check = false;
                this.src = "https://1.downloader.disk.yandex.ru/disk/0eef419d3dfb7947749426d77aec575a94df8291cc50b6fab9e15a372e9efc8d/577ba17c/bSsWx8SyjxqKW6xjs1b-wSuxXebd8A8Haq7AdCd2-HyV2h6lKo9Z-K947MFVmHvaOY-tASjz5Ot91g_RXKd4WQ%3D%3D?uid=0&filename=o.png&disposition=inline&hash=&limit=0&content_type=image%2Fpng&fsize=4506&hid=22de218b464964c2edbb079d63ce1d5a&media_type=image&tknv=v2&etag=47c9c03399200cebf474bebd3982f0d8";
            } else {
                check = true;
                this.src = "https://1.downloader.disk.yandex.ru/disk/d561903f2fd4a751656eaac37a56fc584c09fe8c157ae9e61a27103e90a8bdb1/577ba14b/bSsWx8SyjxqKW6xjs1b-wVfhLoobOJGU31aq3kliuLx8Exz7G05UgkES-ZgLRp-goTwKZhAd7xn6zakJNefu1w%3D%3D?uid=0&filename=x.png&disposition=inline&hash=&limit=0&content_type=image%2Fpng&fsize=2822&hid=202bde3d71747510f8e6239acac1d56d&media_type=image&tknv=v2&etag=fd5415b3dc7cd6f07857aa08fa1807b3";
            }
        });
    };

    game.client.endGame = function (message) {
        alert(message);
        canSetWay = true;
        for (i = 0; i < 3; i++) {
            for (k = 0; k < 3; k++) {
                $('#table').find('tr').eq(i).find('td').eq(k).find('img').each(function () {
                    this.src = "https://4.downloader.disk.yandex.ru/disk/e2f22b5bb86b98327c67f74fd5a03845f30b92f92fdc66cd8cc1c64abdeab649/577cfef7/bSsWx8SyjxqKW6xjs1b-weQesF89QVHeXTnZNPbRqN5b5CZt1hOTYRnUVbBJgeSKHS-9p0nc0N2krU58pDsGBw%3D%3D?uid=0&filename=circle.png&disposition=inline&hash=&limit=0&content_type=image%2Fpng&fsize=2436&hid=bd2da196f84ef752ae3aa75583fc9ee7&media_type=image&tknv=v2&etag=ba473a3a5c2228b5b1b1d807b172ffc5";
                });
            }
        }
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