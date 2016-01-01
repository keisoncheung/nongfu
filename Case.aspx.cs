using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Text;
using DLL;

public partial class Case : System.Web.UI.Page
{
    public string request_str;
    private string page_text = "";
    private string title_new = null;
    private int RecordPerPage;//每页显示行数
    protected System.Web.UI.HtmlControls.HtmlTableRow ttr;
    public string left_news = string.Empty;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            this.ViewState["CurrentPg"] = 1;

            if (Request["key"] != null)
            {
                request_str = Request["key"] + "";
                RecordPerPage = 20;
                index_news(request_str);

            }

            if (Request.QueryString["nid"] != null)
            {
                this.Page.Title += OleDbHelper.ExecuteScalar(OleDbHelper.Conn, "select Title from news where id=" + Request.QueryString["nid"], null).ToString();
            }
        }


    }

    public void index_news(string par)
    {
        StringBuilder sbr = new StringBuilder();
        bool bol = false;
        DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, "select top 20 id, title,parid,linkpic,createdate from news where parid=" + request_str + " order by id desc", null).Tables[0];
        string title = "";
        foreach (DataRow dr in dt.Select())
        {
            title = Convert.ToString(dr["title"]);
            if (title.Length > 22)
            {
                title = title.Substring(0, 22) + "...";
            }
            sbr.Append(" <dt ><img src='images/stgray.gif' style='margin-right:10px;*margin-top:10px;' /><a href='news.aspx?key=" + par + "&nid=" + dr["id"] + "' title='" + dr["title"] + "'>" + title + "</a></dt>");
        }
        left_news = sbr.ToString();
    }



    public string stitle()
    {
        string str = OleDbHelper.ExecuteScalar(OleDbHelper.Conn, "select ClsName1 from NewType where id=" + request_str + "") + "";
        return str;
    }

    private string Ini()
    {
        string webstr = null;

        webstr = "<tr><td><ul class='index_img_list_ul2'>";


        string nid = Request["nid"] + "";
        string ntype = Request["key"] + "";

        if (nid.Length <= 0) //新闻列表
        {
            if (Request["dao"] != null)
            {
                string sql = "select top 1 Id,Title,Author,Content,CreateDate,linkpic,picture from news where parid=" + ntype + " order by id desc ";
                DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, sql, null).Tables[0];
                if (dt.Rows.Count >= 1)
                {
                    webstr = "<tr><td style='font-size:18px; height:20px; ' align=center><STRONG><Font>" + dt.Rows[0]["Title"] + "</font></STRONG><br><hr width=100% size=1 color=#c0c0c0 noshade></td></tr><tr><td style='padding:0px 0px 0px 0px;'><div id='page' style=''>" + dt.Rows[0]["Content"] + "</div> </td></tr>";
                }
                else
                {
                    webstr = "<tr><td style='text-indent:20px;'>暂无信息!</td></tr>";
                }
            }
            else
            {

                string where = " where languageId=1 and  parid=" + request_str;
                if (ntype.Length > 1)
                {
                    where = " where languageId=1 and  parid=" + ntype + "";
                }
                ViewState["max_c"] = OleDbHelper.ExecuteScalar(OleDbHelper.Conn, "select count(Id) from news" + where, null);
                ViewState["MaxPg"] = Convert.ToString(System.Math.Ceiling(Convert.ToDouble(Convert.ToInt32(Convert.ToString(ViewState["max_c"])) / Convert.ToDouble(this.RecordPerPage))));
                tpate();
                int StartNum = Convert.ToInt32(ViewState["CurrentPg"]) * RecordPerPage;
                int intTemNum = StartNum - RecordPerPage;
                string sql = "select * from (select top " + StartNum + " Id,Title,CreateDate,parid,linkpic,picture from news " + where + " order by Id desc) a where a.Id not in (Select top " + intTemNum + "  Id from news " + where + " order by Id desc)";
                if (intTemNum <= 0)
                {
                    sql = "select top " + RecordPerPage + " Id,Title,CreateDate,parid,linkpic,picture from news " + where + " order by Id desc";
                }
                DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, sql, null).Tables[0];
                foreach (DataRow dr in dt.Select())
                {
                    string title = Convert.ToString(dr["Title"]);
                    //webstr += "<dl><dt>·<a target='_blank' href='news.aspx?ac=1&key=" + request_str + "&nid=" + dr["id"] + "' title='" + dr["title"] + "'>" + title + "</a></dt><dd></dd></dl>";
                    //webstr += "<li><span class='lr'>【新闻中心】 <a href='caseshow.aspx?ac=1&key=" + request_str + "&nid=" + dr["id"] + "' title='" + dr["title"] + "' target='_blank'>" + title + "</a></span><span class='time'>" + Convert.ToDateTime(dr["CreateDate"]).ToString("yyyy-MM-dd") + "</span></li>";
                    webstr += " <div class='main_pro_con'><a href='caseshow.aspx?ac=1&key=" + request_str + "&nid=" + dr["id"] + "' title='" + dr["title"] + "' target='_blank'><img src='pic/" + dr["picture"] + "' width='165' height='100'><br>" + title + " </a> </div>";

                }
                dt.Dispose();
            }
        }
        else//新闻详细信息
        {
            string sql = "select Id,Title,Author,Content,CreateDate from news where id=" + nid;
            DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, sql, null).Tables[0];
            if (dt.Rows.Count >= 1)
            {
                webstr = "<tr><td style='font-size:18px; height:20px; width:100%; text-aligen:center; ' align=center><STRONG><Font>" + dt.Rows[0]["Title"] + "</font></STRONG><br><hr size=1 color=#c0c0c0 noshade></td></tr><tr><td style='padding:0px 0px 0px 0px;'><div id='page' style=''>" + dt.Rows[0]["Content"] + "</div> </td></tr>";
            }
            else
            {
                webstr = "<tr><td style='text-indent:20px;'>暂无信息!</td></tr>";
            }
        }
        return webstr;
    }
    private string roadNewType(string tid)
    {
        return OleDbHelper.ExecuteScalar(OleDbHelper.Conn, "select ClsName from NewType where id=" + tid, null) + "";
    }
    #region 分页显示
    private void tpate()
    {
        string control = Convert.ToString(this.Request["pg"]);
        ViewState["CurrentPg"] = control;
        int pg, p, n = 0;
        switch (control)
        {
            case "f":
                ViewState["CurrentPg"] = 1;
                break;
            case "n":
                ViewState["CurrentPg"] = Convert.ToInt32(ViewState["CurrentPg"]) + 1;
                break;
            case "p":
                ViewState["CurrentPg"] = Convert.ToInt32(ViewState["CurrentPg"]) - 1;
                break;
            case "l":
                ViewState["CurrentPg"] = ViewState["MaxPg"];
                break;
        }
        if (Convert.ToInt32(ViewState["CurrentPg"]) < 1)
        {
            ViewState["CurrentPg"] = 1;
        }
        string urlq = turnQ();
        if (Convert.ToInt32(ViewState["MaxPg"]) > 1)
        {
            pg = Convert.ToInt32(ViewState["CurrentPg"]);
            p = ((pg - 1) >= 1) ? (pg - 1) : 1;
            n = ((pg + 1) <= Convert.ToInt32(ViewState["MaxPg"])) ? (pg + 1) : Convert.ToInt32(ViewState["MaxPg"]);
            page_text = "<div  style='text-align:right; width:580px;'><table border='0' cellspacing='0' cellpadding='0' width='40%'><tr>" +
                "<td><a style='' href='" + urlq + "&pg=1'>首页</a></td> " +
                "<td><a style='' href='" + urlq + "&pg=" + p + "'>上一页</a></td> " +
                "<td><a style='' href='" + urlq + "&pg=" + n + "'>下一页</a></td> " +
                "<td><a style='' href='" + urlq + "&pg=" + ViewState["MaxPg"] + "'>尾页</a></td> " +
                "<td>页次：<span style='font-weight:bold;'>" + ViewState["CurrentPg"] + "/" + ViewState["MaxPg"] + "</span>页</td> " +
                "<td width='10'></td>" +
                "</tr></table></div>";

            //     <div class='sabrosus'><span class='disabled'> &lt; </span><span class='current'>1</span><a href='#?page=2'>2</a><a href='#?page=3'>3</a><a href='#?page=4'>4</a><a href='#?page=5'>5</a><a href='#?page=6'>6</a><a href='#?page=7'>7</a>...<a href='#?page=199'>199</a><a href='#?page=200'>200</a><a href='#?page=2'> &gt; </a></div>
            //</div>

        }
    }
    private string turnQ()
    {
        string urls = Request.Url.Query;
        string url = "";
        if (urls.IndexOf("?") >= 0)
        {
            urls = urls.Replace("?", "");
            foreach (string u in urls.Split('&'))
            {
                if (u.IndexOf("pg") == -1)
                {
                    url += "&" + u;
                }
            }
        }
        return Request.Url.AbsolutePath + "?" + url.Substring(1);
    }
    public string Page_Text
    {
        get
        {
            return (page_text != null) ? page_text : "";
        }
    }
    public string New_list
    {
        get
        {
            return Ini();
        }
    }
    #endregion
}
