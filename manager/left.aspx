<%@ Page Language="C#" AutoEventWireup="true" CodeFile="left.aspx.cs" Inherits="manager_left" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="Admin_STYLE.CSS" type="text/css" rel="stylesheet" />
    <style type="text/css">
        body
        {
            background-color: #507CD1;
            text-align: center;
        }
        .menu
        {
            width: 158px;
            text-align: left;
        }
        .menu .menuContent
        {
            margin-bottom: 12px;
            background-color: #d4ecf5;
        }
        .menu_title
        {
        }
        .menu_title span
        {
            position: relative;
            top: 2px;
            left: 8px;
            color: #0F42A6;
            font-weight: bold;
        }
        .menu_title2
        {
        }
        .menu_title2 span
        {
            position: relative;
            top: 2px;
            left: 8px;
            color: #cc0000;
            font-weight: bold;
        }
        a:link
        {
            font-weight: bold;
            text-decoration: none;
            color: #000000;
        }
        a:visited
        {
            font-weight: bold;
            text-decoration: none;
            color: #000000;
        }
        a:hover
        {
            font-weight: bold;
            color: #f60;
            text-decoration: none;
        }
        a:active
        {
            font-weight: bold;
            text-decoration: none;
            color: #F90;
        }
        li
        {
            list-style: disc outside url(bgpic/open.gif);
            font-weight: 700;
            height: 19px;
            padding-left: 4px;
            vertical-align: bottom;
            overflow: hidden;
            padding-top: 12px;
        }
        ul
        {
            margin: 0px 0px 0px 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="menu">
        <img src="bgpic/title.gif" alt="" />
        <div class="menu_title" onmouseover="this.className='menu_title2';" onmouseout="this.className='menu_title';"
            style="background-image: url(bgpic/title_bg_quit.gif); line-height: 25px;">
            <span><b>&nbsp;&nbsp;</b><b><a href="main.aspx?lanauage=1&ac=管理首页" target="main">网站首页</a></b>
                | <a href="out.aspx" target="_top"><b>退出</b></a></span>
        </div>
    </div>
    <div class="menu">
        <div lang="MainMenu" style="background-image: url(bgpic/Admin_left_02.gif); line-height: 25px;"
            class="menu_title" onmouseover="this.className='menu_title1';" onmouseout="this.className='menu_title';">
            <span style="cursor: hand">&nbsp;网站资料管理<span lang="zh-cn"></span> <span style="color: #ff0000">
                √</span></span>
        </div>
        <div class="menuContent">
            <ul>
                <li><a href="information.aspx?lanauage=1" target="main">公司资料</a></li>
            </ul>
        </div>
        <div lang="MainMenu" style="background-image: url(bgpic/Admin_left_02.gif); line-height: 25px;"
            class="menu_title" onmouseover="this.className='menu_title2';" onmouseout="this.className='menu_title';">
            <span style="cursor: hand">&nbsp;栏目管理<span lang="zh-cn"></span> <span style="color: #ff0000">
                √</span></span>
        </div>
        <div class="menuContent">
            <ul>
                <li><a href="Article.aspx" target="main">栏目管理</a></li>
            </ul>
        </div>
       <%-- <div lang="MainMenu" style="background-image: url(bgpic/Admin_left_02.gif); line-height: 25px;"
            class="menu_title" onmouseover="this.className='menu_title2';" onmouseout="this.className='menu_title';">
            <span style="cursor: hand">&nbsp;首页大图管理<span lang="zh-cn"></span> <span style="color: #ff0000">
                √</span></span>
        </div>
        <div class="menuContent">
            <ul>
             <li><a href="pictures.aspx" target="main">添加数据</a></li>
                <li><a href="picturelist.aspx" target="main">首页大图管理</a></li>
            </ul>
        </div>--%>
      <div lang="MainMenu" style="background-image: url(bgpic/Admin_left_02.gif); line-height: 25px;"
            class="menu_title" onmouseover="this.className='menu_title5';" onmouseout="this.className='menu_title';">
            <span style="cursor: hand">&nbsp;工程案例<span lang="zh-cn"></span> <span style="color: #ff0000">
                √</span></span>
        </div>
        <div class="menuContent">
            <ul>
               <li><a href="news.aspx?type=54" target="main">案例列表</a></li>
                <li><a href="newsshow.aspx?type=54" target="main">案例列表</a></li>
            </ul>
        </div>
        
         <div lang="MainMenu" style="background-image: url(bgpic/Admin_left_02.gif); line-height: 25px;"
            class="menu_title" onmouseover="this.className='menu_title5';" onmouseout="this.className='menu_title';">
            <span style="cursor: hand">&nbsp;新闻中心<span lang="zh-cn"></span> <span style="color: #ff0000">
                √</span></span>
        </div>
        <div class="menuContent">
            <ul>
               
                <li><a href="news.aspx?type=26" target="main">新闻列表</a></li>
                <li><a href="newsshow.aspx?type=26" target="main">新闻列表</a></li>
            </ul>
        </div>

        <div lang="MainMenu" style="background-image: url(bgpic/Admin_left_02.gif); line-height: 25px;"
            class="menu_title" onmouseover="this.className='menu_title5';" onmouseout="this.className='menu_title';">
            <span style="cursor: hand">&nbsp;产品中心<span lang="zh-cn"></span> <span style="color: #ff0000">
                √</span></span>
        </div>
        <div class="menuContent">
            <ul>
               
                <li><a href="proshow.aspx?lan=1" target="main">产品列表</a></li>
                <li><a href="protype.aspx" target="main">产品类别</a></li>
            </ul>
        </div>
        
         
      <%--  <div lang="MainMenu" style="background-image: url(bgpic/Admin_left_02.gif); line-height: 25px;"
            class="menu_title" onmouseover="this.className='menu_title5';" onmouseout="this.className='menu_title';">
            <span style="cursor: hand">&nbsp;在线留言<span lang="zh-cn"></span> <span style="color: #ff0000">
                √</span></span>
        </div>
        <div class="menuContent">
            <ul>
                <li><a href="guessbookshow.aspx" target="main">留言列表</a></li>
            </ul>
        </div>
        
          <div lang="MainMenu" style="background-image: url(bgpic/Admin_left_02.gif); line-height: 25px;"
            class="menu_title" onmouseover="this.className='menu_title5';" onmouseout="this.className='menu_title';">
            <span style="cursor: hand">&nbsp;友情链接<span lang="zh-cn"></span> <span style="color: #ff0000">
                √</span></span>
        </div>
        <div class="menuContent">
            <ul>
             <li><a href="yingyong.aspx" target="main">文章列表</a></li>
                <li><a href="yingyongshow.aspx" target="main">文章列表</a></li>
            </ul>
        </div>--%>
        
        <div lang="MainMenu" style="background-image: url(bgpic/Admin_left_02.gif); line-height: 25px;"
            class="menu_title" onmouseover="this.className='menu_title5';" onmouseout="this.className='menu_title';">
            <span style="cursor: hand">&nbsp;密码管理<span lang="zh-cn"></span> <span style="color: #ff0000">
                √</span></span>
        </div>
        <div class="menuContent">
            <ul>
                <li><a href="changepwd.aspx" target="main">修改密码</a></li>
            </ul>
        </div>
    </div>
    </form>

    <script type="text/javascript">

        var onclick = function() {
            var div = this.nextSibling; //this.nextSibling;
            if (div.style.display == "none") {
                div.style.display = "";
            }
            else {
                div.style.display = "none";
            }
        }
        var divs = document.getElementsByTagName("div");
        for (var i = 0; i < divs.length; i++) {
            if (divs[i].lang == "MainMenu") {
                divs[i].setAttribute('onclick', document.all ? eval(onclick) : 'javascript:onclick()');
            }
        }    	
    </script>

</body>
</html>