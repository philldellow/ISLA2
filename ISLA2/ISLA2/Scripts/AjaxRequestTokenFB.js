function getData() {
    FB.getLoginStatus(function (response) {
        var accessToken = response.authResponse.accessToken;
        $.post('@Url.Action("UserInfo", "Home")',
        { 'accessToken': accessToken },
        function (data, statusText) {
            var name = data.name;
            var id = data.id;
        });
    });
}
function getData() {
    $.post('@Url.Action("UserInfo", "Home")',
    function (data, statusText) {
        var name = data.name;
        var id = data.id;
    });
}