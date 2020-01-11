using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Base64ToConvertProject
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void UploadButton_Click(object sender, EventArgs e)
        {
            string saveDir = @"C:\Users\SimgeSen\Desktop";
            string appPath = @"\";
            if (FileUpload1.HasFile)
            {

                string savePath = saveDir + appPath +
                    Server.HtmlEncode(FileUpload1.FileName);
                FileUpload1.SaveAs(savePath);
                // yüklenen pdfi tarayıcıda açıyor
                // System.Diagnostics.Process.Start(savePath);
                UploadStatusLabel.Text = "Your file was uploaded successfully.";
                UploadStatusLabel.ForeColor = System.Drawing.Color.Green;


                // Yüklenen verinin base64 e çevrilip txbLabel da gösterilmesi işlemini kapsar.
                byte[] pdfBytes = File.ReadAllBytes(savePath);
                string pdfBase64 = Convert.ToBase64String(pdfBytes);
                txbLabel.Text = pdfBase64;
                // var data = "application / pdf; base64,pdfBase64";
                
                HtmlGenericControl myObject = new HtmlGenericControl();
                myObject.TagName = "object";
                myObject.Attributes.Add("data", "data:application/pdf;base64," + pdfBase64);
                Page.FindControl("deneme").Controls.Add(myObject);
                




            }
            else
            {

                UploadStatusLabel.Text = "You did not specify a file to upload.";
                UploadStatusLabel.ForeColor = System.Drawing.Color.Red;
            }

        }

        protected void LinkButtonDownloadPdf_Click(object sender, EventArgs e)
        {
            // buradaki  data="data:application/pdf;base64,YOURBASE64DATA" bilgileri kullan...
        }







    }
}