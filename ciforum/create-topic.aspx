<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="create-topic.aspx.cs" Inherits="ciforum.create_topic" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script>
        SEC_HTTPS = true;
        SEC_BASE = "compilers.widgets.sphere-engine.com";
        (function (d, s, id) {
            SEC = window.SEC || (window.SEC = []);
            var js, fjs = d.getElementsByTagName(s)[0];
            if (d.getElementById(id)) return; js = d.createElement(s); js.id = id;
            js.src = (SEC_HTTPS ? "https" : "http") + "://" + SEC_BASE + "/static/sdk/sdk.js";
            fjs.parentNode.insertBefore(js, fjs);
        }(document, "script", "sphere-engine-compilers-jssdk"));
    </script>
    <div class="create">
        <div class="create__head">
            <div class="create__title">
                <img src="css/fonts/icons/main/New_Topic.svg" alt="New topic">Create New Post
            </div>
            <span>Forum Guidelines</span>
        </div>
        <div class="create__section">
            <label class="create__label" for="title">Post Title</label>
            <label class="hidden" id="lblpostid">0</label>
            <label class="hidden" id="lblparentpostid">0</label>
            <label class="hidden" id="lblsubparentpostid">0</label>
            <label class="hidden" id="lblposttype">1</label>
            <input type="text" class="form-control" id="txttitle" placeholder="Title">
        </div>
        <div class="row">
            <div class="col-md-6">
                <div class="create__section">
                    <label class="create__label" for="category">Category</label>
                    <input class="form-control" placeholder="Categories" id="txttagtopic" onkeyup="serchtag('txttagtopic,tagSearchultopic,1');">
                    <label class="hidden" id="lblhtxttagtopic">0</label>
                    <ul class="ul_Advancelist hidden" id="tagSearchultopic">
                    </ul>

                </div>
            </div>
            <div class="col-md-6">
                <div class="create__section">
                    <label class="create__label" for="sub-category">Sub Category</label>
                    <input class="form-control" placeholder="Categories" id="txttagtopicsub" onkeyup="serchtag('txttagtopicsub,tagSearchultopicsub,2');">
                    <label class="hidden" id="lblhtxttagtopicsub">0</label>
                    <ul class="ul_Advancelist hidden" id="tagSearchultopicsub">
                    </ul>
                </div>
                <div class="tags" id="divsubtag">
                </div>
            </div>
        </div>
        <div class="create__section create__textarea">
            <label class="create__label" for="description">Description</label>
            <textarea class="form-control" id="txtdescription"></textarea>
        </div>
         <div class="create__section create__textarea">
            <label class="create__label" for="description">Description</label>
            <div class="sec-widget form-control" data-id="sourcecode_widget" data-widget="457a5343e71d5e1017185f2d59cbd50f"></div>
        </div>
        <div class="col-md-6">
            <div class="create__section">
                <input type="file" id="fileInput" accept=".zip, .csv" />
                <label class="create__label" for="fileInput">Only .csv or .zip file are allowed</label>
            </div>
        </div>       

        <div class="col-md-6">
            <div class="create__footer">
                <label class="create__btn-cansel btn" onclick="cancelnewpost();">Cancel</label>
                <label class="create__btn-create btn btn--type-02" onclick="savenewpost(null);">Create Post</label>
               <%--<label class="create__btn-cansel btn" onclick="test();">test</label>--%> 
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
        CKEDITOR.replace('txtdescription');
        $(document).ready(function () {
            getuser();

        });
    </script>
</asp:Content>
