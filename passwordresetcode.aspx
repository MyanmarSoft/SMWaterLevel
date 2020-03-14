<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="passwordresetcode.aspx.cs" Inherits="SMWaterLevel.passwordresetcode" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <title>Password Reset Code | SMWaterLevel</title>
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
                <a href="#"><img src="AdminLTE/dist/img/logo.png"/></a>
            </div>
            <!-- /.login-logo -->
            <div class="login-box-body">
                <label>It's password reset code. Please copy and Verify it.</label>
                <div class="form-group has-feedback">
                <asp:Literal ID="ltlResetCode" runat="server"></asp:Literal>
                </div>
                <div class="row">
                     <div class="col-xs-6">
                         <a href="forgotpassword.aspx">Resend Again?</a>
                      </div>
                    <div class="col-xs-6">
                        <asp:LinkButton ID="btnVerify" runat="server" CssClass="btn btn-success btn-block btn-flat" OnClick="btnVerify_Click"><i class="glyphicon glyphicon-ok"></i> Verify</asp:LinkButton>
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
