<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FilmotekaWebApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>FILMOTEKA</h1>
    </div>

    <div class="row">
        <div class="col-md-4">
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <asp:Button ID="Button1" runat="server" Text="Sortuj według roku"  OnClick="Button1_Click"/>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Sortuj według kraju" Width="187px" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Sortuj według tytułu" />
            <br />
            <div>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Szukaj" />
            </div>
            <br />
            <asp:FormView ID="FormView1" runat="server">
            </asp:FormView>
            <br />
            <br />
        </div>
    </div>

</asp:Content>
