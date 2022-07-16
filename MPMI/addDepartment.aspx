<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="addDepartment.aspx.cs" Inherits="MPMI.addDepartment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
      $(document).ready(function () {
      
          //$(document).ready(function () {
              //$('.table').DataTable();
         // });
      
          $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
          //$('.table1').DataTable();
      });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%--<div class="container-fluid">
      <div class="row">
         <div class="col-md-6 mx-auto">
            <div class="card">
               <div class="card-body">
              
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Register Department</h4>
                        </center>
                     </div>
                  </div>

                    <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>

                  <div class="row">
                     <div class="col">
                        <label>Department name</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="department name"></asp:TextBox>
                        </div>
                     </div>
                  </div>

                   <div class="row">
                     <div class="col-8 mx-auto">
                        <center>
                           <div class="form-group">
                              <asp:Button class="btn btn-primary btn-block btn-lg" ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
                           </div>
                        </center>
                     </div>
                  </div>
         
            </div>
            <a href="homepage.aspx"><< Back to Home</a><br><br>
         </div>
      </div>
    </div>--%>
    <div class="container">
        <div class="row">
            <div class="col-md-5">

                <div class="card">
                    <div class="card-body">

                        <div class="row">
                            <div class="col">
                                <center>
                                        <h4>Add Department</h4>
                                    </center>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <center>
                                        <img width="100px" src="imgs/department.png" />
                                    </center>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <hr>
                            </div>
                        </div>


                            <div class="col-md-8">
                                <label>Department Name</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Department Name"></asp:TextBox>

                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-6">
                                <asp:Button ID="Button1" class="btn btn-lg btn-block btn-success" runat="server" Text="Add" OnClick="Button1_Click"/>
                            </div>
                            <%--<div class="col-4">
                                <asp:Button ID="Button2" class="btn btn-lg btn-block btn-warning" runat="server" Text="Update" OnClick="Button2_Click" />
                            </div>--%>
                            <div class="col-6">
                                <asp:Button ID="Button3" class="btn btn-lg btn-block btn-danger" runat="server" Text="Delete" OnClick="Button3_Click" />
                            </div>
                        </div>
                        <br>
                        <a href="homepage.aspx"><< Back to Home</a>
                        <br>
                    </div>
                </div>
                
                
            

            <div class="col-md-7">

                <div class="card">
                    <div class="card-body">



                        <div class="row">
                            <div class="col">
                                <center>
                                        <h4>Department List</h4>
                                    </center>
                            </div>
                        </div>

                       

                        <div class="row">
                            <div class="col">
                                <hr>
                            </div>
                        </div>

                        <div class="row">
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MPMIConnectionString %>" SelectCommand="SELECT * FROM [departments]"></asp:SqlDataSource>
                            <div class="col">
                                <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="departmentId" DataSourceID="SqlDataSource1">
                                    <Columns>
                                        <asp:BoundField DataField="departmentId" HeaderText="Department ID" InsertVisible="False" ReadOnly="True" SortExpression="departmentId" />
                                        <asp:BoundField DataField="departmentName" HeaderText="Department Name" SortExpression="departmentName" />
                                    </Columns>
                                </asp:GridView>
                            </div>
                        </div>


                    </div>
                </div>


            </div>

        </div>
    </div>
</asp:Content>
