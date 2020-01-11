<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConvertProject.aspx.cs" Inherits="Base64ToConvertProject.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div class="row">
        <h1 style="text-align:center; color:#ff6666 " >Convert Project</h1>
    <form id="form1" runat="server">
        
       <div class="col-md-6">

          <h4 style="color: #81d8d0 ">Yüklenecek olan dosyayı PDF formatında seçiniz: </h4>
   
       <asp:FileUpload id="FileUpload1"                 
           runat="server">
       </asp:FileUpload>
            
       <br /><br />
       
       <asp:Button id="UpLoadButton" 
           Text="Dosya Yükleyiniz"
           OnClick="UploadButton_Click"
           runat="server">
       </asp:Button> 

        <br /><br />
        
         <h4 style="color: #67363a ">Pdf Convert Base64</h4>
        <br />
           
          <asp:TextBox width="50%" height="150px" runat="server" ID="txbLabel"></asp:TextBox>    
           

       <hr />

       <asp:Label id="UploadStatusLabel" runat="server">
       </asp:Label> 
       </div>
        <br />
        <br />

         <div class="col-md-6">
             <h4 style="color: #67363a"> Base64 Convert PDF</h4>

               <div id="deneme" runat="server">
                   <object  id="obj1" data="data:application/pdf;base64,pdfBase64" type="application/pdf">
                        
                   </object>
               </div>
             
             
        
         
         
             
         </div>  
        <div>
       
            

        </div>

    
    </form>

</body>
</html>
