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
public partial class caseshow : System.Web.UI.Page
{

    public string title = string.Empty, crdate = string.Empty, content = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["nid"] != null)
            getcontent();
    }

    public void getcontent()
    {
        string sql = "select Id,Title,Author,Content,CreateDate from news where id=" + Request["nid"];
        DataTable dt = OleDbHelper.ExecuteDataSet(OleDbHelper.Conn, sql, null).Tables[0];
        foreach (DataRow dr in dt.Rows)
        {
            title = Convert.ToString(dr["title"]);
            crdate = Convert.ToString(dr["createdate"]);
            content = Convert.ToString(dr["content"]);
        }
    }
}