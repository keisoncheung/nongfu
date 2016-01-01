<%@ Page Title="" Language="C#" MasterPageFile="~/mar1.master" AutoEventWireup="true"
    CodeFile="proList.aspx.cs" Inherits="proList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="main_pro_title">
        <div class="main_pro_title_l">
            产品中心</div>
        <div class="main_pro_title_weizhi">
            当前位置：首页 > 产品中心</div>
    </div>
    <%=Content%>
    <div style="text-align: center; margin-top: 10px; clear: both; clear: left; vertical-align: bottom"
        class="page_list">
        <%=getpage %></div>
</asp:Content>
