// globale Variable um zwischen openweathermap und eigener API zu switchen (Suboptimal)
var url = 'https://api.openweathermap.org/data/2.5/weather?q=';
var useOpenWeatherMap = true;
$(document).ready(function () {
    if (useOpenWeatherMap) {
        getLocation();
    }
    $("#remark").hide();
    $("input[name='apiSelector']").click(function () {
        if ($("#chkOpenWeather").prop("checked")) {
            useOpenWeatherMap = true;
            url = 'https://api.openweathermap.org/data/2.5/weather?q=';
            $("#remark").hide();
        }
        if ($("#chkOwnAPI").prop("checked")) {
            useOpenWeatherMap = false;
            url = 'http://localhost:5230/api/Weather/';
            $("#resultDiv").hide();
            $("#remark").show();
        }
    });
    $("#weatherForm").submit(function (event) {
        var city = $("#city").val().toString();
        if (city.length === 0) {
            $("#resultDiv").hide();
            $("#errorDiv").append("Bitte geben Sie eine Stadt ein!").show();
            return;
        }
        getWeatherInformationByCity(city);
        event.preventDefault();
    });
});
function getLocation() {
    if (navigator.geolocation) {
        navigator.geolocation.watchPosition(function (position) {
            getWeatherInformationByGeolocation(position);
        });
    }
}
function getWeatherInformationByGeolocation(position) {
    var url = "https://api.openweathermap.org/data/2.5/weather?lat=".concat(position.coords.latitude, "&lon=").concat(position.coords.longitude);
    getWeatherInformation(url);
}
function getWeatherInformationByCity(city) {
    getWeatherInformation("".concat(url).concat(city));
}
function getWeatherInformation(url) {
    var errorDiv = $("#errorDiv");
    var resultDiv = $("#resultDiv");
    if (useOpenWeatherMap) {
        var apiKey = "d15db65ae3ffbde3e76ac23f9673d5d1";
        url = "".concat(url, "&appid=").concat(apiKey, "&lang=de&units=metric");
    }
    errorDiv.empty().hide();
    resultDiv.hide();
    $.getJSON(url, function (data) { })
        .done(function (data) {
        $("#resultHeader").text("Aktuelle Wetterlage in ".concat(data.name, ", ").concat(data.sys.country));
        $("#temperature").text("".concat(data.main.temp, " \u00B0C"));
        $("#pressure").text("".concat(data.main.pressure, " hPa"));
        $("#humidity").text("".concat(data.main.humidity, " %"));
        $("#temp_min").text("".concat(data.main.temp_min, " \u00B0C"));
        $("#temp_max").text("".concat(data.main.temp_max, " \u00B0C"));
        $("#wind_speed").text("".concat(data.wind.speed, " m/s"));
        $("#wind_direction").text("".concat(data.wind.deg, " \u00B0"));
        $("#weather").text("".concat(data.weather[0].description));
        $("#clouds").text("".concat(data.clouds.all, " %"));
        if (useOpenWeatherMap) {
            var iconurl = "http://openweathermap.org/img/w/".concat(data.weather[0].icon, ".png");
            $("#icon").attr("src", iconurl);
        }
        var timeStamp = new Date(data.dt * 1000);
        $("#dateTime").text("Stand: ".concat(timeStamp.toLocaleString()));
        resultDiv.show();
        $("input#city").val("");
    })
        .fail(function (jqXHR, textStatus, errorThrown) {
        if (jqXHR.status === 404) {
            $("#errorDiv").append("Der Ort konnte nicht gefunden werden! Bitte versuchen Sie eine andere Stadt.").show();
        }
        else {
            $("#errorDiv").append("Unerwarteter Fehler: (Keine Internetverbindung?)").show();
        }
        $("input#city").val("");
    });
}
//# sourceMappingURL=weatherClient.js.map