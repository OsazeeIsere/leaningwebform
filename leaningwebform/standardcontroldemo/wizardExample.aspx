<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wizardExample.aspx.cs" Inherits="leaningwebform.standardcontroldemo.wizardExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            background-color: #808000;
        }
        .auto-style2 {
            width: 100%;
            background-color: #00FFFF;
        }
        .auto-style3 {
            width: 100%;
            background-color: #FFFF00;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="3" BorderColor="#FF99CC" BorderStyle="Solid" Height="316px" Width="513px" OnFinishButtonClick="Wizard1_FinishButtonClick">
                <WizardSteps>
                    <asp:WizardStep runat="server" title="Academy Qualification">
                        <table border="5" class="auto-style1">
                            <tr>
                                <td>&nbsp;</td>
                                <td>
                                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>
                                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </asp:WizardStep>
                    <asp:WizardStep runat="server" title="Technical Qualification">
                        <table border="3" class="auto-style2">
                            <tr>
                                <td>&nbsp;</td>
                                <td>
                                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>
                                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </asp:WizardStep>
                    <asp:WizardStep runat="server" Title="Work Experience">
                        <table border="3" class="auto-style3">
                            <tr>
                                <td>&nbsp;</td>
                                <td>
                                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>
                                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </asp:WizardStep>
                    <asp:WizardStep runat="server" StepType="Finish" Title="Finish">
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                    </asp:WizardStep>
                </WizardSteps>
            </asp:Wizard>
        </div>
        <asp:Label ID="Label2" runat="server"></asp:Label>
    </form>
</body>
</html>
