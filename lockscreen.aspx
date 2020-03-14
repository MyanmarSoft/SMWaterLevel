<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="lockscreen.aspx.cs" Inherits="SMWaterLevel.lockscreen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta charset="utf-8"/>
  <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <title>Lockscreen | SMWaterLevel</title>
      <link rel="icon" href="AdminLTE/favicon.ico" type="image/x-icon" />
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport"/>
  <!-- Bootstrap 3.3.6 -->
  <link rel="stylesheet" href="AdminLTE/bootstrap/css/bootstrap.min.css"/>
  <!-- Font Awesome -->
  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.5.0/css/font-awesome.min.css"/>
  <!-- Ionicons -->
  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/ionicons/2.0.1/css/ionicons.min.css"/>
  <!-- Theme style -->
  <link rel="stylesheet" href="AdminLTE/dist/css/AdminLTE.min.css"/>
  <link rel="stylesheet" href="AdminLTE/plugins/pace/pace.min.css"/>


  <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
  <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
  <!--[if lt IE 9]>
  <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
  <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
  <![endif]-->
  
</head>
<body class="hold-transition lockscreen">
    <form id="form1" runat="server">
    <div class="lockscreen-wrapper">
  <div class="lockscreen-logo">
    <a href="#"><img src="AdminLTE/dist/img/logo.png"/></a>
  </div>       
  <div class="lockscreen-name">
        <asp:Literal ID="ltlMessage" runat="server"></asp:Literal>
        <asp:Literal ID="ltlName" runat="server">John Doe</asp:Literal></div>
  <div class="lockscreen-item">
    <div class="lockscreen-image">
        <asp:Image ID="imgUserImage" runat="server" alt="User Image" ImageUrl="~/AdminLTE/dist/img/userprofile.png"/>
    </div>
    <div class="lockscreen-credentials">
      <div class="input-group">
          <asp:TextBox ID="txtPassword" runat="server" class="form-control" TextMode="Password" placeholder="password" AutoPostBack="true" OnTextChanged="txtPassword_TextChanged"></asp:TextBox>
        <span class="input-group-btn">
          <asp:LinkButton ID="btnSignin" runat="server" CssClass="btn" OnClick="btnSignin_Click"><i class="fa fa-arrow-right text-muted"></i></asp:LinkButton>
        </span>
      </div>
    </div>

  </div>
  <div class="help-block text-center">
    Enter your password to retrieve your session
  </div>
  <div class="text-center">
     <asp:LinkButton ID="btnSigninDifferentUser" runat="server" OnClick="btnSigninDifferentUser_Click">Or sign in as a different user</asp:LinkButton>
  </div>
  <div class="lockscreen-footer text-center">
    Copyright &copy; 2014-2019 <b><a href="http://softwaremyanmar.com" class="text-black">Software Myanmar</a></b><br/>
    All rights reserved
  </div>
</div>
    </form>
    <script src="../AdminLTE/plugins/pace/pace.min.js"></script>
     <script>
     $(document).ajaxStart(function () { Pace.restart(); });
       $('.ajax').click(function () {
           $.ajax({
               url: '#', success: function (result) {
                   $('.ajax-content').html('<hr>Ajax Request Completed !');
               }
           });
       });
    </script>
</body>
         

</html>
