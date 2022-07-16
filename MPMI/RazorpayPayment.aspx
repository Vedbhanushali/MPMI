<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RazorpayPayment.aspx.cs" Inherits="MPMI.RazorpayPayment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="container-fluid">
      <div class="row">
         <div class="col-md-5">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Payment</h4>
                        </center>
                     </div>
                  </div>
                  
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                   
                   <div class="row">
                     <div class="col-md-12">
                        <label>Hospital Name</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="Textname" runat="server" placeholder="Name"></asp:TextBox>
                        </div>
                     </div>
                  </div>

                  <div class="row">
                     <div class="col-md-12">
                        <label>Email</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="Textemail" runat="server" placeholder="Email"></asp:TextBox>
                        </div>
                     </div>
                  </div>

                   <%--TextMode="Number"--%>
                  <div class="row">
                     <div class="col-md-6">
                        <label>Contact number</label>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="Textnum" runat="server" placeholder="contact no" TextMode="Number"></asp:TextBox>
                        </div>
                     </div>

                     <div class="col-md-6">
                        <label>appointment doctor</label>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="Textdoc" runat="server" placeholder="doctor"></asp:TextBox>
                        </div>
                     </div>
                    </div>

                  <div class="row">
                     <div class="col-md-12">
                        <label>Enter amount</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="Textamount" runat="server" placeholder="amount"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                  
                  <div class="row">
                     <div class="col-6 mx-auto">
                        <center>
                           <div class="form-group">
                              <asp:Button class="btn btn-primary btn-block btn-lg" ID="Buttonpay" runat="server" Text="pay" OnClick="Button1_Click" />
                           </div>
                        </center>
                     </div>
                  </div>

                   
            <a href="homepage.aspx"><< Back to Home</a><br>
            <br>
         </div>
       </div>
      </div>
          </div>
        </div>
       
</asp:Content>
