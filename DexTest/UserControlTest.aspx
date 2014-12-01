<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserControlTest.aspx.cs" Inherits="DexTest.UserControlTest" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Content/Css/Monitor.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
    <div style="width: 80%; text-align: center; margin: 0 auto">
    <div class ="leftDash">
        <uc:callbackdashboard runat="server" id="CallBackDashBoard1" InitValue="-24"  DashBoardSource="DexTest.DashBoards.DashboardRegisterTendency"/>
     </div>  
    <div class="rightDash">  
         <uc:callbackdashboard runat="server" id="CallBackDashBoard2" InitValue="-24" OnFresh="OnDashBoard2Fresh" DashBoardSource="DexTest.DashBoards.DashboardRegisterIncrease"/>
    </div>
    </div>
    </form>
</body>
</html>
