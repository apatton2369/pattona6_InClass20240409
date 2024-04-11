using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pattona6_InClass20240409
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LbFruits.Items.Add("Banana");
            }
        }

        protected void LbFruits_SelectedIndexChanged(object sender, EventArgs e)
        {
            //shows the selected value
            LblChosenFruits.Text = LbFruits.SelectedValue;
        }
        //I need an event that will run when the user,
        //in the browser, selects a fruit from the list box
        //

    }
}