using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MidTermExam2024
{
    public partial class Index : System.Web.UI.Page
    {
        SaladClass saladClass = new SaladClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                rptOrder.DataSource = saladClass.CustomerSelect();
                rptOrder.DataBind();

                rptSalad.DataSource = saladClass.SaladSelect();
                rptSalad.DataBind();
            }
        }

        protected void rptOrder_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if(e.CommandName == "SelectUser")
            {
                int row = Convert.ToInt32(e.CommandArgument);

               //int row
                //saladClass.SaladInsert(radSaladSelection.SelectedValue.ToString(), ddlDressing.SelectedValue.ToString(),row, ckbAddon.SelectedValue.ToString());

                ///rptSalad.DataSource = saladClass.SaladSelect();
                //rptSalad.DataBind();


                saladClass.CustomerUpdate(row, radComplete.SelectedValue.ToString());

                rptOrder.DataSource = saladClass.CustomerSelect();
                rptOrder.DataBind();
            }
        }

        protected void btnAddSalad_Click(object sender, EventArgs e)
        {
            saladClass.SaladInsert(radSaladSelection.SelectedValue.ToString(), ddlDressing.SelectedValue.ToString(), ckbAddon.SelectedValue.ToString());


            rptSalad.DataSource = saladClass.SaladSelect();
            rptSalad.DataBind();
        }

        protected void btnSubmitCustomer_Click(object sender, EventArgs e)
        {
            string waiting = "Waiting";
            saladClass.CustomerInsert(txtCustomerName.Text.ToString(), DateTime.Now.ToString(), waiting);
            rptOrder.DataSource = saladClass.CustomerSelect();
            rptOrder.DataBind();

        }

        //saladClass.SaladInsert(radSaladSelection.SelectedValue.ToString(), ddlDressing.SelectedValue.ToString(), ckbAddon.SelectedValue.ToString);

    }
}