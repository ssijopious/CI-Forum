<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ciforum.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="posts">
        <%--<nav aria-label="Page navigation example">
            <ul class="pagination justify-content-end">
                <li class="page-item disabled">
                    <a class="page-link" href="#" tabindex="-1">Previous</a>
                </li>
                <li class="page-item active"><a class="page-link" href="#">1</a></li>
                <li class="page-item"><a class="page-link" href="#">2</a></li>
                <li class="page-item"><a class="page-link" href="#">3</a></li>
                <li class="page-item">
                    <a class="page-link" href="#">Next</a>
                </li>
            </ul>
        </nav>--%>
        <div class="posts__head">
            <div class="posts__topic">Topic</div>
            <div class="posts__category">Category</div>
            <div class="posts__users">Users</div>
            <div class="posts__replies">Comments</div>
            <div class="posts__views">Views</div>
            <div class="posts__activity">Activity</div>
        </div>
        <div class="posts__body" id="posts__body">
        </div>
    </div>
    <script src="jquery/jquery.min.js"></script>
    <script src="jquery/velocity.min.js"></script>
    <script src="jquery/app.js"></script>
    <script src="jquery/ciforum.js"></script>
    <script src="jquery/bootstrap.min.js"></script>
    <%--Script--%>
    <script type="text/javascript">        
        $(document).ready(function () {
            getuser();
            showhide('divheadermenu', 's');
            showhide('divheadersearch', 's');
            getposts('0');
        });
    </script>
</asp:Content>
