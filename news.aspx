<%@ Page Title="" Language="C#" MasterPageFile="~/mar1.master" AutoEventWireup="true" CodeFile="news.aspx.cs" Inherits="news" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="main_pro_title">
            	<div class="main_pro_title_l">新闻中心</div>
                <div class="main_pro_title_weizhi">当前位置：首页 > 新闻中心</div>
            </div>
            <div class="news_list">
            	<ul>
                	 <%=New_list%>
                </ul>
            </div>
             <%=Page_Text%>
</asp:Content>

