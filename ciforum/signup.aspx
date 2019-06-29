<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="ciforum.signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>CI Forum</title>
    <link rel="shortcut icon" href="img/fav.ico" type="image/x-icon" />

    <link href="https://fonts.googleapis.com/css?family=Nunito+Sans:300,400,600,700,800" rel="stylesheet" />
    <link href="css/fonts/style.css" rel="stylesheet" />
    <link href="css/fonts/font-awesome.min.css" rel="stylesheet" />
    <link href="vendor/bootstrap/v3/bootstrap.min.css" rel="stylesheet" />
    <link href="vendor/bootstrap/v4/bootstrap-grid.css" rel="stylesheet" />
    <link href="css/style.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
        <div class="signup">
            <!-- HEADER -->
            <header class="signup__header">
                <div class="container">
                    <div class="signup__header-content">
                        <p><a href="#">Already have an account?</a></p>
                        <a href="login.aspx" class="btn">Sign In</a>
                    </div>
                </div>
            </header>
            <main class="signup__main">
                <img class="signup__bg" src="images/signup-bg.png" alt="bg" />
                <div class="container">
                    <div class="signup__container">
                        <div class="signup__logo">
                            <a href="#">
                                <img src="css/fonts/icons/main/Logo_Forum.svg" alt="logo" />CI Forum</a>
                        </div>
                        <div class="signup__head">
                            <h3>Create a New Forum Account</h3>
                            <p>By singin up you can start posting, replaying to topics, earn badges, favorite, vote topics and many more.</p>
                        </div>
                        <div class="signup__form">
                            <div class="row">
                                <div class="col-md-6">
                                    <div class="signup__section">
                                        <label class="signup__label" for="txtfirstname">
                                            * First Name &nbsp;
                                            <label class="signup__label hidden" style='color: #a94442' id="lblerrorfirstname"></label>
                                            <label class="hidden" id="lbluser">0</label>
                                        </label>
                                        <input type="text" class="form-control" placeholder="" id="txtfirstname" value="" onblur="isNotnull(this,'lblerrorfirstname');" />
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <div class="signup__section">
                                        <label class="signup__label" for="txtlastname">Last Name</label>
                                        <input type="text" class="form-control" placeholder="" id="txtlastname" value="" />
                                    </div>
                                </div>
                            </div>
                            <div class="signup__section">
                                <label class="signup__label" for="txtEmail">
                                    * Email Address &nbsp;
                                    <label class="signup__label hidden" style='color: #a94442' id="lblerroremail"></label>
                                    <label class="hidden" id="lblcontact">0</label>
                                </label>
                                <input type="text" class="form-control" placeholder="" id="txtEmail" value="" onblur="isEmail(this,'lblerroremail');" />
                            </div>
                            <div class="signup__section">
                                <label class="signup__label" for="txtmobile">
                                    * Mobile &nbsp;
                                    <label class="signup__label hidden" style='color: #a94442' id="lblerrormobile"></label>
                                </label>
                                <input type="text" class="form-control" placeholder="" id="txtmobile" value="" onkeydown="isnumber(this, 12);" />
                            </div>
                            <div class="signup__section">
                                <label class="signup__label" for="txtusername">
                                    * Username &nbsp;
                                    <label class="signup__label hidden" style='color: #a94442' id="lblerrorusername"></label>
                                    <label class="hidden" id="lblerrorusernameavl"></label>
                                    <label class="hidden" id="lbllogin">0</label>
                                </label>
                                <input type="text" class="form-control" placeholder="" id="txtusername" value="" onblur="checkusername(this,'lblerrorusername');" />
                            </div>
                            <div class="row">
                                <div class="col-md-6">
                                    <div class="signup__section">
                                        <label class="signup__label" for="txtpassword">
                                            * Password &nbsp;
                                            <label class="signup__label hidden" style='color: #a94442' id="lblerrorpassword"></label>
                                        </label>
                                        <div class="message-input">
                                            <input type="password" class="form-control" placeholder="" id="txtpassword" value="" onblur="isNotnull(this,'lblerrorpassword');" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <div class="signup__section">
                                        <label class="signup__label" for="txtconfirmpassword">
                                            Confirm Password &nbsp;
                                            <label class="signup__label hidden" style='color: #a94442' id="lblerrorconfirmpassword">is not match.</label>
                                        </label>
                                        <div class="message-input">
                                            <input type="password" class="form-control" placeholder="" id="txtconfirmpassword" value="" onblur="issame(this,'txtpassword','lblerrorconfirmpassword');" />
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="signup__checkbox">
                                <div class="row">
                                    <div class="col-md-12">
                                        <label class="signup__box">
                                            <label class="custom-checkbox">
                                                <input type="checkbox" id="chcterms" />
                                                <i></i>
                                            </label>
                                            <span class="signup__label">* I agree to the Terms & Conditions. &nbsp;
                                                <label class="signup__label hidden" style='color: #a94442' id="lblerrorterms"></label>
                                            </span>
                                        </label>
                                    </div>
                                </div>
                            </div>
                            <div class="signup__btn-create btn btn--type-02" id="btnSave" onclick="savesignup()"><i class="fa fa-floppy-o">&nbsp;Create Account</i></div>
                        </div>
                    </div>
                </div>
            </main>
            <!-- FOOTER -->
            <footer class="signup__footer">
                <div class="container">
                    <div class="signup__footer-content">
                        <ul class="signup__footer-menu">
                            <li><a href="#">Teams</a></li>
                            <li><a href="#">Privacy</a></li>
                            <li><a href="#">Send Feedback</a></li>
                        </ul>
                        <ul class="signup__footer-social">
                            <li><a href="#"><i class="fa fa-facebook-square" aria-hidden="true"></i></a></li>
                            <li><a href="#"><i class="fa fa-twitter" aria-hidden="true"></i></a></li>
                            <li><a href="#"><i class="fa fa-google-plus" aria-hidden="true"></i></a></li>
                            <li><a href="#"><i class="fa fa-dribbble" aria-hidden="true"></i></a></li>
                            <li><a href="#"><i class="fa fa-cloud" aria-hidden="true"></i></a></li>
                            <li><a href="#"><i class="fa fa-rss" aria-hidden="true"></i></a></li>
                        </ul>
                    </div>
                </div>
            </footer>
        </div>
    </form>
    <div class="col-lg-12 hover hidden" id="divhover">
        <div class="hoverdiv" style="">
            <div class="loader"></div>
        </div>
    </div>
    <script src="jquery/jquery.min.js"></script>
    <script src="jquery/velocity.min.js"></script>
    <script src="jquery/app.js"></script>
    <script src="jquery/ciforum.js"></script>
</body>
</html>
