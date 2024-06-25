<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="oxo.aspx.cs" Inherits="OX001.oxo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick">
            </asp:Timer>
            <br />
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    You are :<br />
                    <asp:Image ID="Image1" runat="server" Height="100px" ImageUrl="~/Buttom_O.png" Width="100px" />
                    <br />
                    <br />
                    Turn:&nbsp;<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                    <br />
                    <br />
                    <asp:Image ID="winImg" runat="server" Height="200px" ImageUrl="~/Win.png" Visible="False" Width="200px" />
                    <asp:Image ID="loseImg" runat="server" Height="200px" ImageUrl="~/Lose.png" Visible="False" Width="200px" />
                    <asp:Image ID="tieImg" runat="server" Height="150px" ImageUrl="~/tie.png" Visible="False" Width="300px" />
                    <br />
                    <br />
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="50px" ImageUrl="~/Buttom_.png" OnClick="ImageButton1_Click" Width="50px" />
                    <asp:ImageButton ID="ImageButton2" runat="server" Height="50px" ImageUrl="~/Buttom_.png" OnClick="ImageButton2_Click" Width="50px" />
                    <asp:ImageButton ID="ImageButton3" runat="server" Height="50px" ImageUrl="~/Buttom_.png" OnClick="ImageButton3_Click" Width="50px" />
                    <br />
                    <asp:ImageButton ID="ImageButton4" runat="server" Height="50px" ImageUrl="~/Buttom_.png" OnClick="ImageButton4_Click"  Width="50px" />
                    <asp:ImageButton ID="ImageButton5" runat="server" Height="50px" ImageUrl="~/Buttom_.png" OnClick="ImageButton5_Click"  Width="50px" />
                    <asp:ImageButton ID="ImageButton6" runat="server" Height="50px" ImageUrl="~/Buttom_.png" OnClick="ImageButton6_Click"  Width="50px" />
                    <br />
                    <asp:ImageButton ID="ImageButton7" runat="server" Height="50px" ImageUrl="~/Buttom_.png" OnClick="ImageButton7_Click"  Width="50px" />
                    <asp:ImageButton ID="ImageButton8" runat="server" Height="50px" ImageUrl="~/Buttom_.png" OnClick="ImageButton8_Click"  Width="50px" />
                    <asp:ImageButton ID="ImageButton9" runat="server" Height="50px" ImageUrl="~/Buttom_.png" OnClick="ImageButton9_Click"  Width="50px" />
                    <br />
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
                </Triggers>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
