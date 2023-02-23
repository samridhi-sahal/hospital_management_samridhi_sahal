<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="WebApplication1.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>  
        <asp:DropDownList ID="DropDownList1" runat="server" >  
        </asp:DropDownList>  
        <asp:Label ID="Label1" runat="server" Text="Doctor Name"></asp:Label>  
        <br />  
        <br />  
        <asp:Button ID="Button3" runat="server" Text="Button" OnClick="Button1_Click1" Style="height: 26px" />  
        <br />  
        <br />  
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#999999"  
            BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical"  >  
            <AlternatingRowStyle BackColor="#DCDCDC" />  
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />  
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />  
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />  
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />  
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />  
            <SortedAscendingCellStyle BackColor="#F1F1F1" />  
            <SortedAscendingHeaderStyle BackColor="#0000A9" />  
            <SortedDescendingCellStyle BackColor="#CAC9C9" />  
            <SortedDescendingHeaderStyle BackColor="#000065" />  
        </asp:GridView>  
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:hospitalConnectionString %>" SelectCommand="SELECT [patient_name], [doc_registered], [date_registered] FROM [patient_list]"></asp:SqlDataSource>
    </div>  
    <div class="form-group">
    <asp:Button class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Text="Add Doctor" OnClick="Button1_Click"  />
                        </div>
     <div class="form-group">
     <asp:Button class="btn btn-success btn-block btn-lg" ID="Button2" runat="server" Text="Add patient" OnClick="Button2_Click" />
                        </div>
    <div class="form-group">
     <asp:Button class="btn btn-success btn-block btn-lg" ID="Button4" runat="server" Text="Edit/Delete patient" OnClick="Button3_Click" />
                        </div>

</asp:Content>
