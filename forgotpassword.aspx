<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="forgotpassword.aspx.cs" Inherits="SMWaterLevel.forgotpassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <title>Forgot Password | SMWaterLevel</title>
    <link rel="icon" href="AdminLTE/favicon.ico" type="image/x-icon" />
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport" />
    <!-- Bootstrap 3.3.6 -->
    <link rel="stylesheet" href="AdminLTE/bootstrap/css/bootstrap.min.css" />
    <!-- Font Awesome -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.5.0/css/font-awesome.min.css" />
    <!-- Ionicons -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/ionicons/2.0.1/css/ionicons.min.css" />
    <!-- Theme style -->
    <link rel="stylesheet" href="AdminLTE/dist/css/AdminLTE.min.css" />
    <!-- iCheck -->
    <link rel="stylesheet" href="AdminLTE/plugins/iCheck/square/green.css" />
    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
  <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
  <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
  <![endif]-->
</head>
<body class="hold-transition login-page">
    <form id="form1" runat="server">
        <div class="login-box">
            <div class="login-logo">
                <a href="#"><img src="AdminLTE/dist/img/alltimetop_logo.png"/></a>
            </div>
            <!-- /.login-logo -->
            <div class="login-box-body">
                <asp:Literal ID="ltlMessage" runat="server"></asp:Literal>
                <p class="login-box-msg">Get help logging in to SMWaterLevel</p>
                <div class="form-group has-feedback">
                    <label>We'll send you a password reset code</label>
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="Enter username"></asp:TextBox>
                    <span class="glyphicon glyphicon-envelope form-control-feedback"></span>
                </div>
                <div class="row">
                     <div class="col-xs-6">
                         <a href="signin.aspx">Back to Login</a>
                      </div>
                    <div class="col-xs-6">
                        <asp:LinkButton ID="btnResetPassword" runat="server" CssClass="btn btn-primary btn-block btn-flat" OnClick="btnResetPassword_Click"><i class="glyphicon glyphicon-lock"></i> Reset Password</asp:LinkButton>
                    </div>
                </div>
            </div>
            <div class="lockscreen-footer text-center">
    Copyright &copy; 2014-2019 <b><a href="http://softwaremyanmar.com" class="text-black">Software Myanmar</a></b><br/>
    All rights reserved
  </div>
        </div>
    </form>
    <script src="AdminLTE/plugins/jQuery/jquery-2.2.3.min.js"></script>
    <!-- Bootstrap 3.3.6 -->
    <script src="AdminLTE/bootstrap/js/bootstrap.min.js"></script>
    <!-- iCheck -->
    <script src="AdminLTE/plugins/iCheck/icheck.min.js"></script>
    <script>
        $(function () {
            $('input').iCheck({
                checkboxClass: 'icheckbox_square-green',
                radioClass: 'iradio_square-green',
                increaseArea: '20%' // optional
            });
        });
    </script>
</body>
</html>

