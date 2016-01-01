<%@ Page Title="" Language="C#" MasterPageFile="~/mar1.master" AutoEventWireup="true"
    CodeFile="Case.aspx.cs" Inherits="Case" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="main_pro_title">
        <div class="main_pro_title_l">
            工程案例</div>
        <div class="main_pro_title_weizhi">
            当前位置：首页 > 工程案例</div>
    </div>
    <%=New_list%>
    <%=Page_Text%>
</asp:Content>
