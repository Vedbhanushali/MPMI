<%@ Page Title="" Language="C#"  AutoEventWireup="true" CodeBehind="RazorpayCheckout.aspx.cs" Inherits="MPMI.RazorpayCheckout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--<form action="RazorpayCallback.aspx" method="post">--%>
        <script
            src="https://checkout.razorpay.com/v1/checkout.js"
            data-key="rzp_test_IJR5v0qaw8DDoY"
            data-amount="<%=amount%>"
            data-name="<%=name%>"
            data-description="<%=product%>"
            data-order_id="<%=orderId%>"
            data-image="https://razorpay.com/favicon.png"
            data-buttontext="Pay with Razorpay"
            data-prefill.name="<%=name%>"
            data-prefill.email="<%=email%>"
            data-prefill.contact="<%=contact%>"
            data-theme.color="#F37254">
        </script>
    <%--</form>--%>
</asp:Content>
