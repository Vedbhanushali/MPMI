<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RazorpayCallback.aspx.cs" Inherits="MPMI.RazorpayCallback" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <div class="container">
            <h1 runat="server" id="h1Message"></h1>

            <p runat="server" id="pTxnId"></p>

            <p runat="server" id="pOrderId"></p>

            <p> click here to go to home</p>
            <p><a class="btn btn-primary btn-lg" href="RazorpayPayment.aspx" role="button">home</a></p>
        </div>
    
</asp:Content>
