<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE>
<html >
<head>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
<meta name="keywords" content="JS����,����ͼ,JS������,JS��Ч����" />
<meta name="description" content="�˴�������Ϊ����Ӧ��ȵ�jQuery����ͼ���룬����վ�����ô��룬���ཹ��ͼ�������������ͼ��JS����Ƶ����" />
<title>����Ӧ��ȵ�jQuery����ͼ����_����ͼ��</title>
    <link href="css/main.css" rel="stylesheet" type="text/css" />
<link rel="stylesheet" type="text/css" href="css/bootstrap.min.css">
<link rel="stylesheet" type="text/css" href="css/lrtk.css">

</head>
<body>
<!-- ���� ��ʼ -->
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
<!-- ���� ���� -->

</body>
</html>