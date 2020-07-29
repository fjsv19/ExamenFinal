<%@ Page Title="" Language="C#" MasterPageFile="~/Usuario.Master" AutoEventWireup="true" CodeBehind="FormExamenDocente.aspx.cs" Inherits="CapaPresentacion.FormExamenDocente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">

        <section class="content-header">
        <h3 style="text-align:center"><b>EXAMEN</b></h3>
    </section>
    <section class="content" style="padding-bottom:276px;">
        <div class="row">
            <div class="col-md-6" style="margin-left:430px">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>PREGUNTA 1:</label>
                            <div class="form-group">
                                <asp:Label ID="pregunta1" runat="server" Text="" CssClass="form-control"></asp:Label>
                            </div>
                            <div class="form-group">
                                <asp:RadioButton ID="rpt1_1" runat="server" GroupName="pre1"/>
                            </div>
                            <div class="form-group">                                
                                <asp:RadioButton ID="rpt1_2" runat="server" GroupName="pre1"/>
                            </div>
                            <div class="form-group">                             
                                <asp:RadioButton ID="rpt1_3" runat="server" GroupName="pre1"/>
                            </div>
                            <div class="form-group">                             
                                <asp:RadioButton ID="rpt1_4" runat="server" GroupName="pre1"/>
                            </div>
                        </div>

                        <div class="form-group">
                            <label>PREGUNTA 2:</label>                            
                            <div class="form-group">
                                <asp:Label ID="pregunta2" runat="server" Text="" CssClass="form-control"></asp:Label>
                            </div>
                            <div class="form-group">
                                <asp:RadioButton ID="rpt2_1" runat="server" GroupName="pre2"/>
                            </div>
                            <div class="form-group">                                
                                <asp:RadioButton ID="rpt2_2" runat="server" GroupName="pre2"/>
                            </div>
                            <div class="form-group">                             
                                <asp:RadioButton ID="rpt2_3" runat="server" GroupName="pre2"/>
                            </div>
                            <div class="form-group">                             
                                <asp:RadioButton ID="rpt2_4" runat="server" GroupName="pre2"/>
                            </div>
                        </div>

                        
                        
                    </div>
                </div>
            </div>
        </div>
    </section>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
