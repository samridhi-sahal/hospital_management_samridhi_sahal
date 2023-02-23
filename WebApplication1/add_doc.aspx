<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="add_doc.aspx.cs" Inherits="WebApplication1.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .form-control {
            margin-left: 122px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
      <div class="row">
         <div class="col-md-6 mx-auto">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                    
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                           <h3>Add Doctor</h3>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <label>Doctor Name</label><asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Name" ></asp:TextBox>
                        &nbsp;<div class="form-group">
                        </div>
                          <label>Unique ID</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder=" ID"></asp:TextBox>
                        </div>
                        
                       
                        <div class="form-group">
                           <asp:Button class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Text="Done" OnClick="Button1_Click" />
                        </div>
                      
                     </div>
                  </div>
               </div>
            </div>
           
         </div>
      </div>
   </div>
    </form>
</body>
</html>
