using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DLL;
using System.Text;
using System.Data;
using System.Web.UI.HtmlControls;


public partial class contact : System.Web.UI.Page
{
    public string title, content, left_intro;
    protected void Page_Load(object sender, EventArgs e)
    {
        return_intro();
        sintro();
        //pageTitle();
    }



    public void pageTitle()
    {
        StringBuilder sbr = new StringBuilder();
        if (Request["id"] != null)
        {

            DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, "select canshu,title from article where id=" + Request["id"], null).Tables[0];
            foreach (DataRow dr in dt.Select())
            {
                Page.Header.Title = Convert.ToString(dr[0]);
                HtmlMeta keywords = new HtmlMeta();
                keywords.Name = "keywords";
                keywords.Content = Convert.ToString(dr[0]);
                Page.Header.Controls.Add(keywords);
                HtmlMeta desc = new HtmlMeta();
                desc.Name = "description";
                desc.Content = Public2.webDescription(1);
                Page.Header.Controls.Add(desc);
            }
        }

    }

    public void return_intro()
    {

        StringBuilder sbr = new StringBuilder();
        DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, "select id,title,content1 from Article ", null).Tables[0];
        foreach (DataRow dr in dt.Select())
        {
            sbr.Append(@"<dt ><img src='images/stgray.gif' style='margin-right:10px;*margin-top:10px;' /><a href='aboutus.aspx?id=" + dr["id"] + "' title='" + dr["title"] + "'>" + dr["title"] + "</a></dt>");
        }
        left_intro = sbr.ToString();

    }


    public string sintro()
    {

        StringBuilder sbr = new StringBuilder();
        DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, "select title,content1 from Article Where Id=" + Request["id"], null).Tables[0];
        foreach (DataRow dr in dt.Select())
        {
            title = Convert.ToString(dr["title"]);
            content = Convert.ToString(dr["content1"]);
        }
        dt.Dispose();
        return sbr.ToString();
    }
}
