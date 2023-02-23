<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="add_pat.aspx.cs" Inherits="WebApplication1.add_pat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
                          <label>Unique ID</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Member ID"></asp:TextBox>
                        </div>
                        <label>Patient Name</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Name"></asp:TextBox>
                        </div>
                        <label>Doctor Registered To</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Doctor Name"></asp:TextBox>
                        </div>
                        <label>Date Registered</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Password" TextMode="Date"></asp:TextBox>
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
