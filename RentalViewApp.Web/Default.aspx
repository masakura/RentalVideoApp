<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RentalViewApp.Web.Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div>
            <asp:DropDownList runat="server" ID="VideoList"/>
            を
            <asp:TextBox runat="server" ID="Number"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="Number" Display="Dynamic" EnableClientScript="True"></asp:RequiredFieldValidator>
            <asp:RangeValidator runat="server" ControlToValidate="Number" MinimumValue="1" MaximumValue="20" Type="Integer" Display="Dynamic" EnableClientScript="True"></asp:RangeValidator>
            日借りたらいくらになるか
            <asp:Button runat="server" ID="Calculate" Text="計算する" OnClick="Calculate_Click"/>
        </div>
        <div>
            <asp:TextBox runat="server" ID="Price" ReadOnly="True"></asp:TextBox>円
        </div>
    </div>
</asp:Content>