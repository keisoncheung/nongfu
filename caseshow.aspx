<%@ Page Title="" Language="C#" MasterPageFile="~/mar1.master" AutoEventWireup="true" CodeFile="caseshow.aspx.cs" Inherits="caseshow" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="main_pro_title">
            	<div class="main_pro_title_l">工程案例</div>
                <div class="main_pro_title_weizhi">当前位置：首页 > 工程案例 > 工程案例</div>
            </div>
<div class="news_details">
            	<div class="details_title">
                	<div><%=title%>
                    	<div class="cfrom">
                        	<span><%=crdate %></span>
                            <span></span>
                        </div>
                    </div>
                </div>
                <div class="details_text">
                	<%=content %>
                </div>
            </div>

</asp:Content>

