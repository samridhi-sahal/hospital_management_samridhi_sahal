<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="WebApplication1.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
                           <h3>Patient Edit</h3>
             
                           <h3> give original details if want to delete record</h3>
                            <h3> give original id and enter  the details to be changed in corresponding textbox </h3>
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
                        <label>patient id</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="id"></asp:TextBox>
                        </div>
                        <label>patient name</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="name"></asp:TextBox>
                        </div>
                        <label>date </label>
                        <div class="form-group">
                            <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="date"></asp:TextBox>
                        </div>
                         </div>
                        <label>doctor registered </label>
                        <div class="form-group">
                            <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="name"></asp:TextBox>
                        </div>

                        <div class="form-group">
                           <asp:Button class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Text="Edit" OnClick="Button1_Click" />
                        </div>
                      <div class="form-group">
                           <asp:Button class="btn btn-success btn-block btn-lg" ID="Button2" runat="server" Text="Delete" OnClick="Button2_Click" />
                        </div>
                      
                     </div>
                  </div>
               </div>
            </div>
           
         </div>
      </div>
   </div>


</asp:Content>
