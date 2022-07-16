<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="viewBeds.aspx.cs" Inherits="MPMI.viewBeds" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
 
    <%--<div class="content-wrapper">
        
     <section class="content">

          <div class="row">
            <div class="col-md-12">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                    <asp:Label ID="lblTime" runat="server" />
       
                    <asp:Timer ID="Timer1" runat="server" OnTick="TimerTick" Interval="2000" />
                    
                    <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" RepeatDirection="Horizontal"  OnItemDataBound="OnItemDataBound" Width="100%" EnableViewState="true"  >
                        <ItemStyle  />
                        <ItemTemplate>
                        <div >
                          <asp:Image ID="Image12" runat="server" Width="150px" />
                        </div>
                    
                         <div >
                          Id:   <asp:Label ID="lblCustomerId" runat="server" Text=' <%#Eval("Id")%>' ></asp:Label>  
                          Name :     <asp:Label ID="Label1" runat="server" Text=' <%#Eval("Name")%>' ></asp:Label>  
                          Status        <asp:Label ID="Label2" runat="server" Text=' <%#Eval("Status")%>' ></asp:Label>  
                        </div>
                                                                


                        </ItemTemplate>
                    </asp:DataList>
                 </ContentTemplate>
            </asp:UpdatePanel>
                </div>
              </div>
         </section>
        </div>--%>
    <asp:DataList ID="DataList1" runat="server" DataKeyField="bedId" DataSourceID="SqlDataSource1" >
        <%--DataSourceID="SqlDataSource1"--%>
        <ItemTemplate>
            bedId:
            <asp:Label ID="bedIdLabel" runat="server" Text='<%# Eval("bedId") %>' />
            <br />
            hospitalId:
            <asp:Label ID="hospitalIdLabel" runat="server" Text='<%# Eval("hospitalId") %>' />
            <br />
            ward:
            <asp:Label ID="wardLabel" runat="server" Text='<%# Eval("ward") %>' />
            <br />
            bedStatus:
            <asp:Label ID="bedStatusLabel" runat="server" Text='<%# Eval("bedStatus") %>' />
            <br />
            <br />
        </ItemTemplate>
    </asp:DataList>
     <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MPMIConnectionString %>" SelectCommand="SELECT * FROM [rooms]"></asp:SqlDataSource>
</asp:Content>
