<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="addDoctor.aspx.cs" Inherits="MPMI.addDoctor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
      $(document).ready(function () {
      
          //$(document).ready(function () {
              //$('.table').DataTable();
         // });
      
          $(".mytable").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
          //$('.table1').DataTable();
      });
    </script>
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
                           <h4>Doctor Registration</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                           <img width="100px" src="imgs/doctor.png" />
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
                        <label>Doctor Name</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Doctor Name"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                 
                  
                <div class="row">
                     <div class="col-md-12">
                        <label>Doctor Qualification</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Doctor qualification"></asp:TextBox>
                        </div>
                     </div>
                  </div>


                  <div class="row">
                     <div class="col-md-12">
                        <label>Speciality</label>
                         <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataTextField="departmentName" DataValueField="departmentName" DataSourceID="SqlDataSource2"></asp:DropDownList>
                         <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:MPMIConnectionString %>" SelectCommand="SELECT DISTINCT([departmentName]) FROM [departments]"></asp:SqlDataSource>
                     </div>
                  </div>
                  
                  <div class="row">
                     <div class="col-md-12">
                        <label>Hospital Name</label>
                         <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" DataTextField="hospitalName" DataValueField="hospitalName" DataSourceID="SqlDataSource3"></asp:DropDownList>
                         <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:MPMIConnectionString %>" SelectCommand="SELECT DISTINCT([hospitalName]) FROM [hospitals]"></asp:SqlDataSource>
                     </div>
                  </div>

                  <div class="row">
                     <div class="col-md-6">
                        <label>Visiting day</label>
                         <asp:CheckBoxList ID="CheckBoxList1" runat="server" Visible="true" RepeatDirection="Vertical" Height="249px" Width="212px" >
                             
                             <asp:ListItem>Monday</asp:ListItem>
                             <asp:ListItem>Tuesday</asp:ListItem>
                             <asp:ListItem>Wednesday</asp:ListItem>
                             <asp:ListItem>Thursday</asp:ListItem>
                             <asp:ListItem>Friday</asp:ListItem>
                             <asp:ListItem>Saturday</asp:ListItem>
                             <asp:ListItem>Sunday</asp:ListItem>
                         </asp:CheckBoxList>
                     </div>
                  </div>

                   <div class="row">
                     <div class="col-md-6">
                        <label>Visiting Time from</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="from" TextMode="Time"></asp:TextBox>
                        </div>
                     </div>

                      <div class="col-md-6">
                        <label>Visiting Time to</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" placeholder="to" TextMode="Time"></asp:TextBox>
                        </div>
                     </div>
                  </div>

                   <div class="row">
                     <div class="col-md-12">
                        <label>Password</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
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
                   <div class="row">

                       <div class="col-4">
                           <label>Doctor ID</label>
                       </div>
                       <div class="col-md-4">
                            <div class="form-group">
                               <asp:TextBox class="form-control" ID="TextBox9" runat="server" placeholder="Enter Doctor ID"></asp:TextBox>
                            </div>
                        </div>
                       <div class="col-md-4">
                            <asp:Button ID="Button3" class="btn btn-lg btn-block btn-danger" runat="server" Text="Delete" OnClick="Button3_Click" />
                       </div>
                   </div>

               </div>
            </div>
            <a href="homepage.aspx"><< Back to Home</a><br>
            <br>
         </div>

          <%-- GRID VIEW --%>
          <div class="row">
         <div class="col-md-12">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Doctor List</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row"> 
                      <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MPMIConnectionString %>" SelectCommand="SELECT doc.docId,doc.docuser,doc.docName,doc.qualification,dep.departmentName,hos.hospitalName,doc.visitingDay,doc.visitingTime,doc.password FROM [doctors] as doc,[departments] as dep,[hospitals] as hos WHERE doc.hospitalId = hos.hospitalId AND doc.departmentId=dep.departmentId AND doc.role='D'"></asp:SqlDataSource>
                     <div class="col">
                        <asp:GridView class="table mytable table-striped table-bordered" ID="GridView1" runat="server" DataSourceID="SqlDataSource1">
                            <%--<Columns>
                                       <asp:BoundField DataField="departmentId" HeaderText="Department ID" InsertVisible="False" ReadOnly="True" SortExpression="departmentId" />
                                        <asp:BoundField DataField="departmentName" HeaderText="Department Name" SortExpression="departmentName" />
                            </Columns>--%>
                        </asp:GridView>
                     </div>
                  </div>
               </div>
            </div>
         </div>
        </div>
      </div>
   </div>
</asp:Content>
