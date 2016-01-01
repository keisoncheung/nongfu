using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using DLL;
using System.Data;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    public string index_case_list()
    {

        StringBuilder sbr = new StringBuilder();
        bool bol = false;
        DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, "select top 10 id, ProName,PictureS from product where grade=1 order by id desc", null).Tables[0];
        string title = "";
        //sbr.Append("<table><tr>");
        foreach (DataRow dr in dt.Select())
        {
            title = Convert.ToString(dr["ProName"]);
            if (title.Length > 8)
            {
                title = title.Substring(0, 8) + "...";
            }

            //sbr.Append(@"<td><div class='cenul2_div'> <ul ><li class='cenul2_div_li1'><a href='productlist.aspx?pid=" + dr["id"] + "'title='" + dr["ProName"] + "'><img src='pic/ss" + dr["PictureS"] + "' onerror='pic/nopic.jpg'  /></a></li><li><a href='productlist.aspx?pid=" + dr["id"] + "'title='" + dr["ProName"] + "'>" + title + "</a></li></ul></div></td> ");
            sbr.Append(@"<div class='main_pro_con'><a href='producshow.aspx?pid="+dr["id"]+@"' target='_self'>
                	<img src='pic/"+dr["PictureS"]+@"'><br>"+title+"</a> </div>");
           // sbr.Append("<li><a href='productlist.aspx?pid=" + dr["id"] + "'title='" + dr["ProName"] + "'>" + title + "</a></li>");
            //sbr.Append("<li><div class='pic'><a href='productlist.aspx?pid=" + dr["id"] + "'title='" + dr["ProName"] + "'><img src='pic/ss" + dr["PictureS"] + "' onerror='pic/nopic.jpg'  /></a></div><div class='title'><a href='productlist.aspx?pid=" + dr["id"] + "'title='" + dr["ProName"] + "'>" + title + "</a></div></li>");


        }
        return sbr.ToString();


    }


    public string index_case_list2()
    {

        StringBuilder sbr = new StringBuilder();
        bool bol = false;
        DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, "select top 10 Id,Title,Author,Content,CreateDate,linkpic,picture from news where parid=54 order by id desc", null).Tables[0];
        string title = "";
        //sbr.Append("<table><tr>");
        foreach (DataRow dr in dt.Select())
        {
            title = Convert.ToString(dr["Title"]);
            if (title.Length > 8)
            {
                title = title.Substring(0, 8) + "...";
            }

            //sbr.Append(@"<td><div class='cenul2_div'> <ul ><li class='cenul2_div_li1'><a href='productlist.aspx?pid=" + dr["id"] + "'title='" + dr["ProName"] + "'><img src='pic/ss" + dr["PictureS"] + "' onerror='pic/nopic.jpg'  /></a></li><li><a href='productlist.aspx?pid=" + dr["id"] + "'title='" + dr["ProName"] + "'>" + title + "</a></li></ul></div></td> ");
            sbr.Append(@"<li><a href='caseshow.aspx?ac=1&key=54&nid=" + dr["id"] + @"' title='" + dr["title"] + "' target='_self'><img src='pic/" + dr["picture"] + "' alt='" + dr["Title"] + @"'/><br>
                		" +title+@"</a></li>   ");
            // sbr.Append("<li><a href='productlist.aspx?pid=" + dr["id"] + "'title='" + dr["ProName"] + "'>" + title + "</a></li>");
            //sbr.Append("<li><div class='pic'><a href='productlist.aspx?pid=" + dr["id"] + "'title='" + dr["ProName"] + "'><img src='pic/ss" + dr["PictureS"] + "' onerror='pic/nopic.jpg'  /></a></div><div class='title'><a href='productlist.aspx?pid=" + dr["id"] + "'title='" + dr["ProName"] + "'>" + title + "</a></div></li>");


        }
        return sbr.ToString();


    }

    public string indexNews()
    {

        StringBuilder sbr = new StringBuilder();
        bool bol = false;
        DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, "select top 6 id, title,content from news where parid=26 order by id desc", null).Tables[0];
        string title = "";
        //sbr.Append("<table><tr>");
        foreach (DataRow dr in dt.Select())
        {
            title = Convert.ToString(dr["title"]);
            if (title.Length > 22)
            {
                title = title.Substring(0, 22) + "...";
            }

            //sbr.Append(@"<td><div class='cenul2_div'> <ul ><li class='cenul2_div_li1'><a href='productlist.aspx?pid=" + dr["id"] + "'title='" + dr["ProName"] + "'><img src='pic/ss" + dr["PictureS"] + "' onerror='pic/nopic.jpg'  /></a></li><li><a href='productlist.aspx?pid=" + dr["id"] + "'title='" + dr["ProName"] + "'>" + title + "</a></li></ul></div></td> ");
           // sbr.Append("<li><a href='productlist.aspx?pid=" + dr["id"] + "'title='" + dr["ProName"] + "'>" + title + "</a></li>");
            sbr.Append("<li>·<a href='newshow.aspx?ac=1&key=26&nid="+dr[0]+"' target='_blank'>"+title+"</a></li>");
            //sbr.Append("<li><div class='pic'><a href='productlist.aspx?pid=" + dr["id"] + "'title='" + dr["ProName"] + "'><img src='pic/ss" + dr["PictureS"] + "' onerror='pic/nopic.jpg'  /></a></div><div class='title'><a href='productlist.aspx?pid=" + dr["id"] + "'title='" + dr["ProName"] + "'>" + title + "</a></div></li>");


        }
        return sbr.ToString();


    }

    public string indexCase()
    {

        StringBuilder sbr = new StringBuilder();
        bool bol = false;
        DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, "select top 6 id, title,content from news where parid=79 order by id desc", null).Tables[0];
        string title = "";
        //sbr.Append("<table><tr>");
        foreach (DataRow dr in dt.Select())
        {
            title = Convert.ToString(dr["title"]);
            if (title.Length > 22)
            {
                title = title.Substring(0, 22) + "...";
            }

            //sbr.Append(@"<td><div class='cenul2_div'> <ul ><li class='cenul2_div_li1'><a href='productlist.aspx?pid=" + dr["id"] + "'title='" + dr["ProName"] + "'><img src='pic/ss" + dr["PictureS"] + "' onerror='pic/nopic.jpg'  /></a></li><li><a href='productlist.aspx?pid=" + dr["id"] + "'title='" + dr["ProName"] + "'>" + title + "</a></li></ul></div></td> ");
            // sbr.Append("<li><a href='productlist.aspx?pid=" + dr["id"] + "'title='" + dr["ProName"] + "'>" + title + "</a></li>");
            sbr.Append("<li>·<a href='newshow.aspx?ac=1&key=26&nid=" + dr[0] + "' target='_blank'>" + title + "</a></li>");
            //sbr.Append("<li><div class='pic'><a href='productlist.aspx?pid=" + dr["id"] + "'title='" + dr["ProName"] + "'><img src='pic/ss" + dr["PictureS"] + "' onerror='pic/nopic.jpg'  /></a></div><div class='title'><a href='productlist.aspx?pid=" + dr["id"] + "'title='" + dr["ProName"] + "'>" + title + "</a></div></li>");


        }
        return sbr.ToString();


    }
}