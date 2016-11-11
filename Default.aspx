<%@ Page Title="Home Page -- Service Provider" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
 
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <center>
    <table>
    <tr>
    <td class="style2" colspan="2">
    
    <h2>
        Welcome Service Provider!
    </h2>
    
    </td>
    </tr>
    <tr>
    <td class="style2">
    <h2>
    FILTER DATA
    </h2>
        </td>
    <td class="style3">
    
        <asp:TextBox ID="TextBox1" runat="server" Width="198px" AutoPostBack="True" 
            ontextchanged="TextBox1_TextChanged"></asp:TextBox>
    
    </td>
    </tr>
    <tr>
    <td class="style2" colspan="2">
    
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    
        </td>
    </tr>
    <tr>
    <td class="style2" colspan="2">
    <div id="dvMap" style="width: 500px; height: 500px">
</div>
        &nbsp;</td>
    </tr>
    </table>
    </center>
    
</asp:Content>
