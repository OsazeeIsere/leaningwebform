<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BulkinsertDemo.aspx.cs" Inherits="leaningwebform.Ado.NetDemos.BulkinsertDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" Width="264px">
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
                <Columns>
                    <asp:TemplateField HeaderText="Name">
                        
                        <ItemTemplate>
                            <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                            </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Position">
                        
                        <ItemTemplate>
                            <asp:TextBox ID="txtposition" runat="server"></asp:TextBox>
                            </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="City">
                           <ItemTemplate>
                               <asp:TextBox ID="txtcity" runat="server"></asp:TextBox> 
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="State">
                          <ItemTemplate>
                              <asp:TextBox ID="txtstate" runat="server"></asp:TextBox> 
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="Tan" />
                <HeaderStyle BackColor="Tan" Font-Bold="True" />
                <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                <SortedAscendingCellStyle BackColor="#FAFAE7" />
                <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                <SortedDescendingCellStyle BackColor="#E1DB9C" />
                <SortedDescendingHeaderStyle BackColor="#C2A47B" />
            </asp:GridView>
                <br />
                <br />
                <br />
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Do  Bulk Insert" Width="148px" />
        <p>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
