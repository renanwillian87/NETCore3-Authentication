﻿var createState = function () {
    return "SessionValueMakeItjdhuashdhUIHDIHuhdihasudhIUHDSIUADdoipuoqj"
}

var createNonce = function () {
    return "NonceValue";
}

var signIn = function () {
    var redirectUri = "https://localhost:44324/Home/SignIn";
    var responseType = "id_token token";
    var scope = "openid ApiOne";
    var authUrl = 
        "/connect/authorize/callback" + 
        "?client_id=client_id_js" + 
        "&redirect_uri=" + encodeURIComponent(redirectUri)  + 
        "&response_type=" + encodeURIComponent(responseType) + 
        "&scope=" + encodeURIComponent(scope) + 
        "&nonce=" + createNonce()+ 
        "&state=" + createState();

    var returnUrl = encodeURIComponent(authUrl);

    window.location.href = "https://localhost:44333/Auth/Login?ReturnUrl=" + returnUrl; 
}