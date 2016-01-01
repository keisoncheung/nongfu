using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using DLL;
using System.Data;

public partial class mar1 : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    public string sintro(int id)
    {

        StringBuilder sbr = new StringBuilder();
        DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, "select title,content1 from Article Where Id=" + id, null).Tables[0];
        foreach (DataRow dr in dt.Select())
        {
            sbr.Append(Convert.ToString(dr["content1"]));
        }
        dt.Dispose();
        return sbr.ToString();
    }

    public string protype()
    {
        StringBuilder sbr = new StringBuilder();
        string sql = "select id, clsname from productType where parid<>0 order by sortid,id";
        DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, sql, null).Tables[0];
        int i = 0;
        string disp = "none";
        foreach (DataRow dr in dt.Select())
        {
            sbr.Append(" <li><a href='proList.aspx?id=" + dr[0] + "'>" + Convert.ToString(dr["clsname"]) + "</a></li>");
        }
        return sbr.ToString();
    }
}
