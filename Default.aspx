<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_14FebbraioEs._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container-fluid">
        <div class="row justify-content-center">
            <div class="col-auto">
                <div class="container-fluid p-3 bg-light rounded-3">

                    <asp:Label ID="Label1" runat="server" Text="Nome"></asp:Label>
                    <asp:TextBox ID="Nome" runat="server" class="form-control mb-2"></asp:TextBox>



                    <asp:Label ID="Label2" runat="server" Text="Cognome"></asp:Label>
                    <asp:TextBox ID="Cognome" runat="server" class="form-control mb-2"></asp:TextBox>


                    <asp:Label ID="Label3" runat="server" Text="Sala"></asp:Label>
                    <asp:DropDownList ID="SalaDropDown" runat="server" CssClass="form-control mb-2">
                        <asp:ListItem Text="Sala nord" Value="nord"></asp:ListItem>
                        <asp:ListItem Text="Sala sud" Value="sud"></asp:ListItem>
                        <asp:ListItem Text="Sala est" Value="est"></asp:ListItem>
                    </asp:DropDownList>

                    <asp:Label ID="Label4" runat="server" Text="Tipologia biglietto"></asp:Label>
                    <asp:DropDownList ID="BigliettoDropDown" runat="server" CssClass="form-control mb-2">
                        <asp:ListItem Text="Intero" Value="intero"></asp:ListItem>
                        <asp:ListItem Text="Ridotto" Value="ridotto"></asp:ListItem>
                    </asp:DropDownList>


                    <asp:Button ID="SubmitButton" runat="server" Text="Submit" CssClass="btn btn-primary" OnClick="SubmitButton_Click" />




                </div>

            </div>
            <div class="col-auto">
                <div class="container-fluid p-3 bg-light rounded-3">
                    <h4>Prenotazioni</h4>
                    <ul id="prenotazioni" runat="server">
                </div>


                </ul>

            </div>
        </div>
    </div>


</asp:Content>
