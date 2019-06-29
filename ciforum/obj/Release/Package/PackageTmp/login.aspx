<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ciforum.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>CI-Forum</title>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />

    <link href="https://fonts.googleapis.com/css?family=Nunito+Sans:300,400,600,700,800" rel="stylesheet" />
    <link rel="icon" type="image/png" href="images/icons/favicon.ico" />
    <link href="vendor/bootstrap/v3/bootstrap.min.css" rel="stylesheet" />
    <link href="css/fonts/font-awesome.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="css/util.css" />
    <link rel="stylesheet" href="css/main.css" />
</head>
<body>
    <div class="limiter">
        <div class="container-login100">
            <div class="wrap-login100">
                <span class="login100-form-title p-b-26">Welcome
                </span>

                <div class="wrap-input100 validate-input">
                    <label class="signup__label" for="txtusername">
                        * Username &nbsp;
                        <label class="signup__label hidden" style='color: #a94442' id="lblerrorusername"></label>
                    </label>
                    <input class="input100" type="text" placeholder="Username" name="Username" id="txtusername" onblur="isNotnull(this,'lblerrorusername');" />
                </div>

                <div class="wrap-input100 validate-input">
                    <label class="signup__label" for="txtpassword">
                        * Password &nbsp;
                        <label class="signup__label hidden" style='color: #a94442' id="lblerrorpassword"></label>
                    </label>
                    <input class="input100" type="password" name="pass" id="txtpassword" onblur="isNotnull(this,'lblerrorpassword');" />
                </div>

                <div class="container-login100-form-btn">
                    <div class="wrap-login100-form-btn">
                        <div class="login100-form-bgbtn"></div>
                        <button class="login100-form-btn" onclick="loginclick();">
                            Login
                        </button>
                    </div>
                </div>

                <div class="text-center p-t-80">
                    <span class="txt1">Don’t have an account?</span>
                    <a class="txt2" href="signup.aspx">Sign Up
                    </a>
                </div>
            </div>
        </div>
    </div>
    <script src="jquery/jquery.min.js"></script>
    <script src="jquery/velocity.min.js"></script>
    <script src="jquery/app.js"></script>
    <script src="jquery/ciforum.js"></script>
</body>
</html>
