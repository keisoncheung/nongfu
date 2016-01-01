<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE>
<html >
<head>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
<meta name="keywords" content="JS代码,焦点图,JS广告代码,JS特效代码" />
<meta name="description" content="此代码内容为自适应宽度的jQuery焦点图代码，属于站长常用代码，更多焦点图代码请访问懒人图库JS代码频道。" />
<title>自适应宽度的jQuery焦点图代码_懒人图库</title>
    <link href="css/main.css" rel="stylesheet" type="text/css" />
<link rel="stylesheet" type="text/css" href="css/bootstrap.min.css">
<link rel="stylesheet" type="text/css" href="css/lrtk.css">

</head>
<body>
<!-- 代码 开始 -->
<div class="container-fluid text-center">
    <div class="header">
                <img class="headerImg" src="images/baner1.jpg" data-slideshow='images/baner1.jpg|images/baner2.jpg|images/baner3.jpg'>
            </div>
</div>
<script src="js/jquery.min.js"></script>
<script src="js/jquery.hammer-full.min.js"></script>
<script src="js/plugin.js"> </script>
<script src="js/lrtk.js"></script>
<script>
    var links = ["http://www.lanrentuku.com", "http://www.lanrentuku.com/lanren/", "http://www.lanrentuku.com/js/biaoqian.html", "http://www.lanrentuku.com/js/xiangce.html"];
    $(".slide").click(function () {
        var index = $(this).attr('index');
        if (index === undefined) {
            window.open(links[0]);
        } else {
            window.open(links[(parseInt(index) + 1)]);
        }

    });
</script>
<!-- 代码 结束 -->

</body>
</html>