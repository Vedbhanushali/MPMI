<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="nursePanel.aspx.cs" Inherits="MPMI.nursePanel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
       <div class="container">

         <div class="row">
            <div class="col-md-3">
               <center>
                  <img width="150px" src="imgs/payment.jpg"/>
                  <h4>Payment</h4>
                   <div class="form-group">
                           <asp:Button class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Text="Payment" OnClick="Button1_Click" />
                   </div>
               </center>
            </div>
         </div>
        <div class="row">
            <div class="col-md-3">
               <center>
                  <img width="150px" src="imgs/user_image.png"/>
                  <h4>Register Patient</h4>
                   <div class="form-group">
                           <asp:Button class="btn btn-success btn-block btn-lg" ID="Button2" runat="server" Text="Register" OnClick="Button2_Click" />
                   </div>
               </center>
            </div>
         </div>

       </div>
    </section>
</asp:Content>
