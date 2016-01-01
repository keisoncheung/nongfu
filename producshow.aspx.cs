using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using DLL;

public partial class producshow : System.Web.UI.Page
{
    public string pics, links;
    protected void Page_Load(object sender, EventArgs e)
    {

    }




    //public string stype2()
    //{



    //    string sql = "";
    //    //int i = 1;
    //    //StringBuilder sbr = new StringBuilder();
    //    //DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, "select id, ClsName,SortId from productType where parid=0  order by sortid desc", null).Tables[0];
    //    //foreach (DataRow dr in dt.Select())
    //    //{
    //    //    sbr.Append("<li class='btype" + i + "'><a href='javascript:protype_func(\"" + i + "\")' >" + dr["clsname"] + "</a><ul id='ChildMenu" + i + "' class='collapsed'>");
    //    //    dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, "select id, ClsName,SortId from productType where parid=" + dr["id"] + " and parid<>0  order by sortid desc", null).Tables[0];
    //    //    foreach (DataRow dr2 in dt.Select())
    //    //    {
    //    //        sbr.Append("<li class='stype" + i + "'><a href='product.aspx?id=" + dr2["id"] + "'>" + dr2["clsname"] + "</a></li>");
    //    //    }
    //    //    sbr.Append("</ul></li>");
    //    //    i++;
    //    //}
    //    //if (Request["dti"] != null)
    //    //{
    //    //    sbr.Append("<script LANGUAGE=\"JavaScript\">displaydl(\"dti" + Request["dti"] + "\")</script>");
    //    //}
    //    return sbr.ToString();

    //}

    public string sintro()
    {
        string pid = "";
        if ((Request["pid"] + "").Length > 0)
        {
            pid = Request["pid"];
        }
        else
        {
            Response.Redirect(Request.UrlReferrer.ToString());
        }
        StringBuilder sbr = new StringBuilder();
        DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, "select * from Product Where Id=" + pid, null).Tables[0];
        foreach (DataRow dr in dt.Select())
        {
            string type = Convert.ToString(OleDbHelper.ExecuteScalar(OleDbHelper.Conn, "select ClsName from productType where id=" + dr["ParId"] + "", null));
            sbr.Append("<div style=' margin:5px auto; text-align:center; width:300px;clear:both;'><br><font style='font-size:20px;font-weight:800; font-family:微软雅黑'>" + dr["ProName"] + "</font></div>");
            //sbr.Append("<div style='margin:5px auto;clear:both; text-align:center;'><a target='_blank' href='pic/" + dr["PictureB"] + "'><img alt='" + dr["ProName"] + "' style=' border:0px;padding:2px;margin-bottom:5px; ' src='pic/s" + dr["PictureS"] + "' alt=''></a></div>");

            sbr.Append("<div style='width:100%;margin-top:0px; clear:both;'><hr><p style='font-size:13px;font-weight:800;margin-left:30px;'>" + dr["Content"] + "</p></div>");
        }
        dt.Dispose();
        return sbr.ToString();
    }
}
