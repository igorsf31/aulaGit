using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Noticia : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            btListagem_Click(null, null);
        }
      

    }

    protected void btListagem_Click(object sender, EventArgs e)
    {

    }

    protected void btCadastro_Click(object sender, EventArgs e)
    {

    }

    protected void grdNoticia_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}