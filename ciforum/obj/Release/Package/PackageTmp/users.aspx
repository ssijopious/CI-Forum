<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="users.aspx.cs" Inherits="ciforum.users" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="price-table-wrapper" id="user_table">
        
    </div>

    <%--<p><iframe src="https://ciforum20190504014653.azurewebsites.net/Fileupload/081936230005120.csv" frameborder="0" height="400"
      width="95%"></iframe></p>--%>

    <script src="jquery/jquery.min.js"></script>
    <script src="jquery/velocity.min.js"></script>
    <script src="jquery/app.js"></script>
    <script src="jquery/ciforum.js"></script>
    <script src="jquery/bootstrap.min.js"></script>

    <script type="text/javascript">        
        $(document).ready(function () {
            getperson();
        });
    </script>

</asp:Content>
