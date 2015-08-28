using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mywebsite
{
    public partial class payBillFinal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string card = txtCard.Text;
            if (card.StartsWith("4"))
            {

                Image1.ImageUrl ="Images/icon_visa.png";
            }

            else
                if (card.StartsWith("51") || card.StartsWith("52") || card.StartsWith("53") || card.StartsWith("54") || card.StartsWith("55"))
                {

                    Image1.ImageUrl = "Images/apps_mastercard.png";
                }
                else
                    if (card.StartsWith("34") || card.StartsWith("37"))
                    {

                        Image1.ImageUrl = "Images/download.jpg";
                    }

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (Image1.ImageUrl == "Images/icon_visa.png")
            {
                if ((txtCard.Text).Count() == 16 || (txtCard.Text).Count() == 13)
                    args.IsValid = true;
                else
                    args.IsValid = false;
            }
            else
                if (Image1.ImageUrl =="Images/apps_mastercard.png")
                {
                    if ((txtCard.Text).Count() == 16)
                        args.IsValid = true;
                    else
                        args.IsValid = false;
                }
                else
                    if (Image1.ImageUrl =="Images/download.jpg")
                    {
                        if ((txtCard.Text).Count() == 15)
                            args.IsValid = true;
                        else
                            args.IsValid = false;
                    }
                    else args.IsValid = false;
        }

        protected void btnPay_Click(object sender, EventArgs e)
        {
            

            if (CustomValidator1.IsValid)
            {
                ServiceReference1.ServerSendClient S = new ServiceReference1.ServerSendClient();
                string msg = S.updateTable(Int32.Parse("V4"), double.Parse(txtAmt.Text));
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Payment has been made!');", true);

            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtAmt.Text = "";
            txtCard.Text = "";
            txtCvv.Text = "";
            DropDownList1.Text = "mm";
            DropDownList2.Text = "yyyy";
            Image1.ImageUrl="Images/credit_card3-512.png";
        }


    }
}