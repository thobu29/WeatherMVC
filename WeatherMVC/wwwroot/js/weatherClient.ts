// globale Variable um zwischen openweathermap und eigener API zu switchen (Suboptimal)
let url = 'https://api.openweathermap.org/data/2.5/weather?q=';
let useOpenWeatherMap = true;

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
        var city: string = $("#city").val().toString();
        if (city.length === 0) {
            $("#resultDiv").hide();
            $("#errorDiv").append(`Bitte geben Sie eine Stadt ein!`).show();
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
    const url = `https://api.openweathermap.org/data/2.5/weather?lat=${position.coords.latitude}&lon=${position.coords.longitude}`;
    getWeatherInformation(url);
}

function getWeatherInformationByCity(city: string) {
    getWeatherInformation(`${url}${city}`);
}

function getWeatherInformation(url: string) {
    let errorDiv = $("#errorDiv");
    let resultDiv = $("#resultDiv");
    if (useOpenWeatherMap) {
        const apiKey = "d15db65ae3ffbde3e76ac23f9673d5d1";
        url = `${url}&appid=${apiKey}&lang=de&units=metric`;
    }
    errorDiv.empty().hide();
    resultDiv.hide();
    $.getJSON(url, function (data) { })
        .done(function (data) {
            $("#resultHeader").text(`Aktuelle Wetterlage in ${data.name}, ${data.sys.country}`);
            $("#temperature").text(`${data.main.temp} °C`);
            $("#pressure").text(`${data.main.pressure} hPa`);
            $("#humidity").text(`${data.main.humidity} %`);
            $("#temp_min").text(`${data.main.temp_min} °C`);
            $("#temp_max").text(`${data.main.temp_max} °C`);
            $("#wind_speed").text(`${data.wind.speed} m/s`);
            $("#wind_direction").text(`${data.wind.deg} °`);
            $("#weather").text(`${data.weather[0].description}`);
            $("#clouds").text(`${data.clouds.all} %`);
            if (useOpenWeatherMap) {
                var iconurl = `http://openweathermap.org/img/w/${data.weather[0].icon}.png`;
                $("#icon").attr("src", iconurl);
            }
            var timeStamp:Date = new Date(data.dt * 1000);
            $("#dateTime").text(`Stand: ${timeStamp.toLocaleString()}`);
            resultDiv.show();
            $("input#city").val("");
        })
        .fail(function (jqXHR, textStatus, errorThrown) {
            if (jqXHR.status === 404) {
                $("#errorDiv").append(`Der Ort konnte nicht gefunden werden! Bitte versuchen Sie eine andere Stadt.`).show();
            }
            else {
                $("#errorDiv").append("Unerwarteter Fehler: (Keine Internetverbindung?)").show();
            }
            $("input#city").val("");
        })
}
