<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="addRooms.aspx.cs" Inherits="MPMI.addRooms" %>
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
                           <h4>Rooms</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                           <img width="100px" src="imgs/room.png" />
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
                        <label>hospital</label>
                         <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataTextField="hospitalName" DataValueField="hospitalName" DataSourceID="SqlDataSource2"></asp:DropDownList>
                         <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:MPMIConnectionString %>" SelectCommand="SELECT DISTINCT([hospitalName]) FROM [hospitals]"></asp:SqlDataSource>
                     </div>
                  </div>

                    <div class="row">
                     <div class="col-md-6">
                        <label>Ward</label>
                         <%--<asp:CheckBoxList ID="CheckBoxList1" runat="server" Visible="true" RepeatDirection="Vertical">
                             
                             <asp:ListItem>Male</asp:ListItem>
                             <asp:ListItem>Female</asp:ListItem>
                             <asp:ListItem>ICU</asp:ListItem>
                             <asp:ListItem>Gynae</asp:ListItem>
                             <asp:ListItem>private</asp:ListItem>
                             
                         </asp:CheckBoxList>--%>
                         <asp:RadioButtonList ID="RadioButtonList1" runat="server" Visible="true" RepeatDirection="Vertical">
                             <asp:ListItem>Male</asp:ListItem>
                             <asp:ListItem>Female</asp:ListItem>
                             <asp:ListItem>ICU</asp:ListItem>
                             <asp:ListItem>Gynae</asp:ListItem>
                             <asp:ListItem>private</asp:ListItem>
                   </asp:RadioButtonList>
                     </div>
                  </div>
                   
                  
                <div class="row">
                     <div class="col-md-12">
                        <label>number of beds</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="beds"></asp:TextBox>
                        </div>
                     </div>
                  </div>



                 


                   <br>

                   <div class="row">
                            <div class="col-12">
                                <asp:Button ID="Button1" class="btn btn-lg btn-block btn-success" runat="server" Text="Add" OnClick="Button1_Click"/>
                            </div>
                            <%--<div class="col-4">
                                <asp:Button ID="Button2" class="btn btn-lg btn-block btn-warning" runat="server" Text="Update" OnClick="Button2_Click" />
                            </div>--%>                        
                   </div>

                   <br>
                   

               </div>
            </div>
            <a href="homepage.aspx"><< Back to Home</a><br>
            <br>
         </div>

      </div>
   </div>
</asp:Content>
