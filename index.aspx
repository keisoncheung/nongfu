<%@ Page Title="" Language="C#" MasterPageFile="~/mar1.master" AutoEventWireup="true"
    CodeFile="index.aspx.cs" Inherits="index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
<script type="text/javascript">
    $(function () { menuBgChange(0); });
</script>
    <div class="main_pro">
        <div class="main_pro_title">
            <div class="main_pro_title_l">
                产品展示</div>
            <div class="main_pro_title_more">
                <a href="proList.aspx" target="_self">更多></div>
        </div>
        <%=index_case_list()%>
    </div>
    <!--案例展示-->
    <div id="film" class="main_pro">
        <div class="main_pro_title">
            <div class="main_pro_title_l">
                案例展示</div>
            <div class="main_pro_title_more">
                <a href="Case.aspx?key=54" target="_self">更多></a></div>
        </div>
        <div id="roll">
            <ul id="rollmain">
                <%=index_case_list2() %>
            </ul>
        </div>
    </div>
    <div id="news_hangye">
        <div class="news_hangye_title">
            <div class="news_hangye_title_l">
                行业资讯</div>
            <div class="news_hangye_title_more">
                <a href="news.aspx?key=26" target="_self">更多></div>
        </div>
        <div class="news_hangye_list">
            <ul>
                <%=indexNews()%>
            </ul>
        </div>
    </div>
</asp:Content>
