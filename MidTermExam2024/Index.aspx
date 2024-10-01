<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="MidTermExam2024.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>CIS3342 - Midterm Exam</h1>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCustomerName" runat="server" Text="Name: "></asp:Label>
            <asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnSubmitCustomer" runat="server" Text="submit" OnClick="btnSubmitCustomer_Click" />

            <asp:Label ID="lblSaladselections" runat="server" Text="Selection: "></asp:Label>
            <asp:RadioButtonList ID="radSaladSelection" runat="server">
                <asp:ListItem>iceberg lettuce</asp:ListItem>
                <asp:ListItem>mixed greens</asp:ListItem>
                <asp:ListItem>baby spinach</asp:ListItem>
            </asp:RadioButtonList>

            <asp:Label ID="lblDressing" runat="server" Text="Dressing: "></asp:Label>
            <asp:DropDownList ID="ddlDressing" runat="server">
                <asp:ListItem>BBQ</asp:ListItem>
                <asp:ListItem>Ranch</asp:ListItem>
                <asp:ListItem>Ketchup</asp:ListItem>
                <asp:ListItem>Water</asp:ListItem>
                <asp:ListItem>SoySauce</asp:ListItem>
                <asp:ListItem>Others</asp:ListItem>

            </asp:DropDownList>

            <asp:Label ID="lblAddons" runat="server" Text="addOns: "></asp:Label>
            <asp:CheckBoxList ID="ckbAddon" runat="server">
                <asp:ListItem>Ham</asp:ListItem>
                <asp:ListItem>Greens</asp:ListItem>
                <asp:ListItem>Bacon</asp:ListItem>
                <asp:ListItem>eggs</asp:ListItem>
                <asp:ListItem>meatball</asp:ListItem>
                <asp:ListItem>cheese</asp:ListItem>
                <asp:ListItem>icecream</asp:ListItem>
                <asp:ListItem>rice</asp:ListItem>
                <asp:ListItem>turkey</asp:ListItem>
                <asp:ListItem>Chicken</asp:ListItem>

            </asp:CheckBoxList>


            <asp:Label ID="lblComplete" runat="server" Text="Complete: "></asp:Label>
            <asp:RadioButtonList ID="radComplete" runat="server">
                <asp:ListItem>Waiting to be built</asp:ListItem>
                <asp:ListItem>Completed</asp:ListItem>
            </asp:RadioButtonList><br />

            <asp:Repeater ID="rptOrder" runat="server" OnItemCommand="rptOrder_ItemCommand">
                <ItemTemplate>
                    <div>
                        <asp:Label ID="lblCustomerName" runat="server" Text="Name"></asp:Label>
                        <asp:Label ID="lblDisplayCustomerName" runat="server" Text='<%#Eval("CustomerName") %>'></asp:Label><br />

                         <asp:Label ID="lblDate" runat="server" Text="Date and time:"></asp:Label>
                        <asp:Label ID="lblDisplayDate" runat="server" Text='<%#Eval("Date") %>'></asp:Label><br />


                        <asp:Label ID="lblStatus" runat="server" Text="Status:"></asp:Label>
                        <asp:Label ID="lblDisplayStatus" runat="server" Text='<%#Eval("Status") %>'></asp:Label><br />

                        <asp:Button ID="SelectUser" runat="server" CommandName ="SelectUser" CommandArgument='<%# ("CustomerId") %>' />
                    </div>
                </ItemTemplate>
            </asp:Repeater>       

            <asp:Repeater ID="rptSalad" runat="server" OnItemCommand="rptOrder_ItemCommand">
                <ItemTemplate>
                    <div>
                        <asp:Label ID="lblSaladSelection" runat="server" Text="Name"></asp:Label>
                        <asp:Label ID="lblDisplaySelection" runat="server" Text='<%#Eval("SaladSelection") %>'></asp:Label><br />

                         <asp:Label ID="lblSaladDressing" runat="server" Text="Date and time:"></asp:Label>
                        <asp:Label ID="lblDisplaySaladDressing" runat="server" Text='<%#Eval("SaladDressing") %>'></asp:Label><br />


                        <asp:Label ID="lblSaladAddOns" runat="server" Text="Status:"></asp:Label>
                        <asp:Label ID="lblDisplaySaladAddOns" runat="server" Text='<%#Eval("SaladAddOns") %>'></asp:Label><br />

                        <asp:Button ID="SelectUser" runat="server" Text='<%# ("CustomerId") %>' />
                        <asp:Button ID="Modify" runat="server" Text='<%# Eval("CustomerName") %>' />
                    </div>
                </ItemTemplate>
            </asp:Repeater>       
                        <asp:Button ID="btnAddSalad" runat="server" Text="submit" OnClick="btnAddSalad_Click" />

        </div>
    </form>
</body>
</html>
