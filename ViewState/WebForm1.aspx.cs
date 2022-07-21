using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewState
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int i = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                ViewState["data"] = i;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            i = (int)ViewState["data"];
            Label1.Text = (++i).ToString();
            ViewState["data"] = i;
        }
    }
}