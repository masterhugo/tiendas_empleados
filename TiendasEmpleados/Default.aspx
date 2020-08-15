<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TiendasEmpleados._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <asp:ListBox id="ListBox1" 
           Width="100px"
           runat="server">

      </asp:ListBox>
        <asp:button id="Button1"
             Text="Filtro" 
             OnClick="SubmitBtn_Click" 
             runat="server" />
    </div>

</asp:Content>
