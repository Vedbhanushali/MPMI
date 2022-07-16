<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminPanel.aspx.cs" Inherits="MPMI.admin_panel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
   <section>
      <div class="container">
         <div class="row">
            <div class="col-12">
               <center>
                  <h2>Admin Panel</h2>
               </center>
            </div>
         </div>
         <div class="row">
            <div class="col-md-3">
               <center>
                  <img width="150px" src="imgs/department.png"/>
                  <h4>Department</h4>
                   <div class="form-group">
                           <asp:Button class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Text="add department" OnClick="Button1_Click" />
                   </div>
               </center>
            </div>
            <div class="col-md-3"> 
               <center>
                  <img width="200px" src="imgs/doctor.png"/>
                  <h4>Doctors</h4>
                 <div class="form-group">
                           <asp:Button class="btn btn-success btn-block btn-lg" ID="Button2" runat="server" Text="add doctor" OnClick="Button2_Click"  />
                   </div>
               </center>
            </div>
            <div class="col-md-3">
               <center>
                  <img width="150px" src="imgs/nurse.png"/>
                  <h4>Staff</h4>
                 <div class="form-group">
                           <asp:Button class="btn btn-success btn-block btn-lg" ID="Button3" runat="server" Text="add nurse-staff" OnClick="Button3_Click"  />
                   </div>
               </center>
            </div>
             <div class="col-md-3">
               <center>
                  <img width="150px" src="imgs/room.png"/>
                  <h4>Rooms</h4>
                 <div class="form-group">
                           <asp:Button class="btn btn-success btn-block btn-lg" ID="Button4" runat="server" Text="add Rooms" OnClick="Button4_Click"  />
                   </div>
               </center>
            </div>
             <div class="col-md-3">
               <center>
                  <img width="150px" src="imgs/hospital.png"/>
                  <h4>Hospitals</h4>
                 <div class="form-group">
                           <asp:Button class="btn btn-success btn-block btn-lg" ID="Button5" runat="server" Text="add Hospitals" OnClick="Button5_Click"  />
                   </div>
               </center>
            </div>
         </div>
      </div>
       
            
        
   </section>
   



         

</asp:Content>
