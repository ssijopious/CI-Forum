<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="dashboard.aspx.cs" Inherits="ciforum.dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <div class="create__head">
            <div class="create__title" style="padding-top: 20px; font-size: 150%;">User profile</div>
        </div>
        <button class="create__btn-cansel btn" type="button" onclick="togglediv('divuserdetail')">Personal data</button>
        <button class="create__btn-cansel btn" type="button" onclick="togglediv('divcontact')">Contact details</button>
        <button class="create__btn-cansel btn" type="button" onclick="togglediv('divaddress')">Address</button>
    </div>

    <%--User--%>
    <div class="create divtoggle" id="divuserdetail">
        <div class="create__head">
            <div class="create__title">Personal Data</div>
            <label class="hidden" id="lbluid"></label>
        </div>
        <div class="row">
            <div class="col-md-3">
                <div class="create__section">
                    <label class="signup__label" for="txtusercode" id="">User code</label>
                    <input type="text" class="form-control" disabled id="txtusercode" placeholder="" />
                </div>
            </div>
            <div class="col-md-3">
                <div class="create__section">
                    <label class="signup__label" for="txtusertype" id="">User type</label>
                    <label class="hidden" id="lblusertype"></label>
                    <input type="text" class="form-control" disabled id="txtusertype" placeholder="" />
                </div>
            </div>
            <div class="col-md-3">
                <div class="create__section">
                    <label class="signup__label" for="txtcreatedon" id="">Created on</label>
                    <input type="text" class="form-control" disabled id="txtcreatedon" placeholder="" />
                </div>
            </div>
            <div class="col-md-3">
                <div class="create__section">
                    <label class="signup__label" for="txtttlpoints" id="">Total points</label>
                    <input type="text" class="form-control" disabled id="txtttlpoints" placeholder="" />
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <div class="create__section">
                    <label class="signup__label" for="txtname1">
                        * First Name
                        <label class="signup__label hidden" style='color: #a94442' id="lblerrorfirstname"></label>
                    </label>
                    <input type="text" class="form-control" id="txtname1" placeholder="First Name" onblur="isNotnull(this,'lblerrorfirstname');">
                </div>
            </div>
            <div class="col-md-6">
                <div class="signup__label">
                    <label class="create__label" for="txtname2">Last Name</label>
                    <input type="text" class="form-control" id="txtname2" placeholder="Last Name">
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-md-6">
                <div class="create__section">
                    <label class="signup__label" for="txtdisplayname">Display name</label>
                    <input type="text" class="form-control" id="txtdisplayname" placeholder="Display name">
                </div>
            </div>
            <div class="col-md-6">
                <label class="signup__label" for="txtusername">
                    * Username &nbsp;
                                    <label class="signup__label hidden" style='color: #a94442' id="lblerrorusername"></label>
                    <label class="hidden" id="lblerrorusernameavl"></label>
                    <label class="hidden" id="lbllogin"></label>
                </label>
                <input type="text" class="form-control" placeholder="" id="txtusername" value="" onblur="checkusername(this,'lblerrorusername');" />
            </div>
        </div>

        <div class="row">
            <div class="col-md-6">
                <label class="signup__label" for="txtpassword">
                    * Password &nbsp;
                  <label class="signup__label hidden" style='color: #a94442' id="lblerrorpassword"></label>
                </label>
                <div class="message-input">
                    <input type="password" class="form-control" placeholder="" id="txtpassword" value="password" onblur="isNotnull(this,'lblerrorpassword');" />
                </div>
            </div>
            <div class="col-md-6">
                <div class="create__section">
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

        <div class="row">
            <div class="col-md-4">
                <div class="create__section">
                    <label class="signup__label" for="txtage">Age</label>
                    <input type="text" class="form-control" id="txtage" placeholder="Age" onkeydown="isnumber(this,2)">
                </div>
            </div>
            <div class="col-md-4">
                <div class="create__section">
                    <label class="signup__label" for="txtwebsite">
                        Web site
                        <label class="signup__label hidden" style='color: #a94442' id="lblerrorWeb"></label>
                    </label>
                    <input type="text" class="form-control" id="txtwebsite" placeholder="Web site" onblur="isWeb(this,'lblerrorWeb');">
                </div>
            </div>
            <div class="col-md-4">
                <div class="create__section">
                    <label class="signup__label" for="txtlastuse">Last accessed on </label>
                    <input type="text" class="form-control" disabled id="txtlastuse" placeholder="">
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="create__section create__textarea">
                    <label class="signup__label" for="txtdescription">Description</label>
                    <textarea class="form-control" id="txtdescription"></textarea>
                </div>
            </div>
        </div>
        <div class="create__footer">
            <label class="create__btn-cansel btn" onclick="cancelnewpost();">Cancel</label>
            <label class="create__btn-create btn btn--type-02" onclick="saveuserdetail();">Save Details</label>
        </div>
    </div>

    <%--Contact--%>
    <div class="create divtoggle hidden" id="divcontact">
        <div class="create__head">
            <div class="create__title">Contact details</div>
            <label class="hidden" id="lblcontacthead"></label>
        </div>

        <div id="divcnttable" style="border-bottom: solid 1px #e9ecee;">
            <div class="table-responsive">
                <table class="table" id="tblcontact">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Email</th>
                            <th>Phone</th>
                            <th>Mobile 1</th>
                            <th>Mobile 2</th>
                            <th>User Type</th>
                            <th></th>
                        </tr>
                    </thead>

                </table>
            </div>
        </div>

        <div id="divcntdetail">
            <div class="row">
                <div class="col-md-6">
                    <div class="create__section">
                        <label class="signup__label" for="txtmastertypecont">* Type</label>
                        <input class="form-control" placeholder="Type" id="txtmastertypecont" onclick="serchmaster('txtmastertypecont,masterSearchulcont');">
                        <label class="hidden" id="lblhtxtmastertypecont">0</label>
                        <label class="hidden" id="lblhcontid">0</label>
                        <ul class="ul_Advancelist hidden" id="masterSearchulcont">
                        </ul>
                    </div>
                </div>
            </div>

            <div class="row">
                <div class="col-md-6">
                    <div class="create__section">
                        <label class="signup__label" for="txtEmail">
                            * Email Address &nbsp;
                                    <label class="signup__label hidden" style='color: #a94442' id="lblerroremail"></label>
                            <label class="hidden" id="lblcontact"></label>
                        </label>
                        <input type="text" class="form-control" placeholder="Email" id="txtEmail" value="" onblur="isEmail(this,'lblerroremail');" />
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="signup__label">
                        <label class="signup__label" for="txtphone">Phone</label>
                        <input type="text" class="form-control" id="txtphone" placeholder="Phone" onkeydown="isnumber(this,12);" />
                    </div>
                </div>
            </div>

            <div class="row">
                <div class="col-md-6">
                    <div class="create__section">
                        <label class="signup__label" for="txtmobile">
                            * Mobile &nbsp;
                                    <label class="signup__label hidden" style='color: #a94442' id="lblerrormobile1"></label>
                        </label>
                        <input type="text" class="form-control" placeholder="Mobile" id="txtmobile1" value="" onkeydown="isnumber(this, 12);" onblur="isNotnull(this,'lblerrormobile1');" />
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="signup__label">
                        <label class="signup__label" for="txtmobile">
                            Alternative number &nbsp;
                                    <label class="signup__label hidden" style='color: #a94442' id="lblerrormobile2"></label>
                        </label>
                        <input type="text" class="form-control" placeholder="Alternative number" id="txtmobile2" value="" onkeydown="isnumber(this, 12);" />
                    </div>
                </div>
            </div>

            <div class="create__footer">
                <label class="create__btn-cansel btn" onclick="cancelnewpost();">Cancel</label>
                <label class="create__btn-create btn btn--type-02" onclick="savecontactdetail();">Save Contact</label>
            </div>
        </div>
    </div>

    <%--Address--%>
    <div class="create divtoggle hidden" id="divaddress">
        <div class="create__head">
            <div class="create__title">Address</div>
            <label class="hidden" id="lbladdress"></label>
        </div>

        <div id="divadstable" style="border-bottom: solid 1px #e9ecee;">
            <div class="table-responsive">
                <table class="table" id="tbladdress">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Line</th>
                            <th>District</th>
                            <th>State</th>
                            <th>Post Code</th>
                            <th>User Type</th>
                            <th></th>
                        </tr>
                    </thead>

                </table>
            </div>
        </div>
        <div id="divadsdetail">
            <div class="row">
                <div class="col-md-6">
                    <div class="create__section">
                        <label class="signup__label" for="txtmastertypeadrs">* Type</label>
                        <input class="form-control" placeholder="Type" id="txtmastertypeadrs" onclick="serchmaster('txtmastertypeadrs,masterSearchuladrs');">
                        <label class="hidden" id="lblhtxtmastertypeadrs">0</label>
                        <label class="hidden" id="lblhadsid">0</label>
                        <ul class="ul_Advancelist hidden" id="masterSearchuladrs">
                        </ul>
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="create__section">
                        <label class="signup__label" for="txtphone">Affiliation</label>
                        <input type="text" class="form-control" id="txtaffiliation" placeholder="Affiliation" />
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <div class="create__section">
                        <label class="signup__label" for="txtphone">Line 1</label>
                        <input type="text" class="form-control" id="txtline1" placeholder="Line 1" />
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="signup__label">
                        <label class="signup__label" for="txtphone">Line 2</label>
                        <input type="text" class="form-control" id="txtline2" placeholder="Line 2" />
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <div class="create__section">
                        <label class="signup__label" for="txtphone">District</label>
                        <input type="text" class="form-control" id="txtdistrict" placeholder="District" />
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="signup__label">
                        <label class="signup__label" for="txtphone">State</label>
                        <input type="text" class="form-control" id="txtstate" placeholder="State" />
                    </div>
                </div>
            </div>

            <div class="row">
                <div class="col-md-6">
                    <div class="create__section">
                        <label class="signup__label" for="txtphone">Country</label>
                        <input type="text" class="form-control" id="txtcountry" placeholder="Country" />
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="signup__label">
                        <label class="signup__label" for="txtphone">Post code</label>
                        <input type="text" class="form-control" id="txtpostcode" placeholder="Post code" />
                    </div>
                </div>
            </div>

            <div class="create__footer">
                <label class="create__btn-cansel btn" onclick="cancelnewpost();">Cancel</label>
                <label class="create__btn-create btn btn--type-02" onclick="saveaddressdetail();">Save Address</label>
            </div>
        </div>
    </div>

    <script src="jquery/jquery.min.js"></script>
    <script src="jquery/velocity.min.js"></script>
    <script src="jquery/app.js"></script>
    <script src="jquery/ciforum.js"></script>
    <script src="jquery/bootstrap.min.js"></script>
    <script src="https://cdn.ckeditor.com/4.11.1/standard/ckeditor.js"></script>
    <script type="text/javascript">  
        CKEDITOR.replace( 'txtdescription' );
        $(document).ready(function () {
            getuser();
            getuserdata();
        });

    </script>

</asp:Content>
