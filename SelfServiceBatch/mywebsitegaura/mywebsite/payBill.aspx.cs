using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mywebsite
{
    public partial class payBill : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string card = txtCard.Text;
            if (card.StartsWith("4"))
            {
                
                Image1.ImageUrl = @"C:\Users\admin\Desktop\mywebsite\mywebsite\Images\icon_visa.png";
            }

            else
                if (card.StartsWith("51") || card.StartsWith("52") || card.StartsWith("53") || card.StartsWith("54") || card.StartsWith("55"))
                {
                    
                    Image1.ImageUrl =@"C:\Users\admin\Desktop\mywebsite\mywebsite\Images\apps_mastercard.png";
                }
                else
                    if (card.StartsWith("34") || card.StartsWith("37"))
                    {
                        
                        Image1.ImageUrl = @"C:\Users\admin\Desktop\mywebsite\mywebsite\Images\download.jpg";
                    }

          
                  //  CustomValidator1.Validate();
            
            }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (Image1.ImageUrl == @"C:\Users\admin\Desktop\mywebsite\mywebsite\Images\icon_visa.png")
            {
                if ((txtCard.Text).Count() == 16 || (txtCard.Text).Count() == 13)
                    args.IsValid = true;
                else
                    args.IsValid = false;
            }
            else
                if (Image1.ImageUrl==@"C:\Users\admin\Desktop\mywebsite\mywebsite\Images\apps_mastercard.png")
                {
                    if ((txtCard.Text).Count() == 16)
                        args.IsValid = true;
                    else
                        args.IsValid = false;
                }
                else
                    if (Image1.ImageUrl == @"C:\Users\admin\Desktop\mywebsite\mywebsite\Images\download.jpg")
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

                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Payment has been made!');", true);

            }
        }
        }

        
        
    }
