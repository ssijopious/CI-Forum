<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="single-topic.aspx.cs" Inherits="ciforum.single_topic" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="topics hidden" id="divpostlst">
        <div class="topics__heading">
            <%--title--%>
            <h2 class="topics__heading-title" id="hposttitle"></h2>
            <input type="text" class="hidden" id="txttitle">
            <label class="hidden" id="lblpostid">0</label>
            <label class="hidden" id="lblparentpostid">0</label>
            <label class="hidden" id="lblposttype">3</label>
            <label class="hidden" id="lblhtxttagtopic">0</label>
            <div class="topics__heading-info">
                <%--tag--%>
                <a href="#" class="category" id="aposttag"></a>
                <div class="tags" id="divpostsubtag">
                </div>
            </div>
        </div>
        <div class="topics__body">
            <div class="topics__content">
                <div class="topic">
                    <div id="divposts">
                    </div>
                    <label class="create__label" id="lblcntedits"></label>
                    <div id="diveidtposts" style="margin-top: 20px;">
                    </div>
                </div>
                <label class="create__label" id="lblcntans"></label>
                <div id="divansposts">
                </div>
                <label class="create__label" id="lblcntcmt"></label>
                <div id="divcomtposts">
                </div>

            </div>
        </div>
    </div>

    <div class="create" id="divpostcrt">
        <div class="create__head">
            <div class="create__title">
                <img src="css/fonts/icons/main/New_Topic.svg" alt="New topic">Create thread
            </div>
            <span>Forum Guidelines</span>
        </div>       
        
        <div class="create__section create__textarea">
            <label class="create__label" for="description">Description</label>
            <textarea class="form-control" id="txtdescription"></textarea>
        </div>
        <div class="col-md-6">
            <div class="create__section">
                <input type="file" id="fileInput" accept=".zip, .csv" />
                <label class="create__label" for="fileInput">Only .csv or .zip file are allowed</label>
            </div>
        </div>
        <div class="col-md-6">
            <div class="create__footer">
                <a href="#" class="create__btn-cansel btn" onclick="cancelnewpost();">Cancel</a>
                <label class="create__btn-create btn btn--type-02" onclick="savenewpost('0');">Create Post</label>
            </div>
        </div>
    </div>


    


    <%--Script--%> 
    <script src="jquery/jquery.min.js"></script>
    <script src="jquery/velocity.min.js"></script>
    <script src="jquery/app.js"></script>
    <script src="jquery/ciforum.js"></script>
    <script src="jquery/bootstrap.min.js"></script>
    <script src="https://cdn.ckeditor.com/4.11.1/standard/ckeditor.js"></script>
    <script src="https://d3js.org/d3.v5.min.js"></script>
    <script type="text/javascript">   
        CKEDITOR.replace( 'txtdescription' );
        $(document).ready(function () {
            getuser();
            var spid = readCookie("spcookie");
            getsinglepost(spid);


            var filenames = "http://localhost:56582/Fileupload/161943200804317.csv";
            var parsedCSV = "";
            var containerval = "";
            d3.text(filenames, function(data) {
                parsedCSV = d3.csv.parseRows(data);

                containerval = d3.select("body")
                    .append("table")

                    .selectAll("tr")
                        .data(parsedCSV).enter()
                        .append("tr")

                    .selectAll("td")
                        .data(function(d) { return d; }).enter()
                        .append("td")
                        .text(function(d) { return d; });
            });
            alert(containerval+parsedCSV);
        });
    </script>

</asp:Content>
