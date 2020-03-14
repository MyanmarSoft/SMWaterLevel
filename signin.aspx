<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signin.aspx.cs" Inherits="SMWaterLevel.signin" %>
<html>
<head runat="server">
   <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <title>Sign in | SMWaterLevel</title>
    <link rel="icon" href="AdminLTE/favicon.ico" type="image/x-icon" />
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport" />
    <!-- Bootstrap 3.3.6 -->
    <link rel="stylesheet" href="AdminLTE/bootstrap/css/bootstrap.min.css" />
    <!-- Font Awesome -->
    <link rel="stylesheet" href="AdminLTE/bower_components/font-awesome/css/font-awesome.min.css" />
    <!-- Ionicons -->
    <link rel="stylesheet" href="AdminLTE/bower_components/Ionicons/css/ionicons.min.css" />
    <!-- Theme style -->
    <link rel="stylesheet" href="AdminLTE/dist/css/AdminLTE.min.css" />
    <!-- iCheck -->
    <link rel="stylesheet" href="AdminLTE/plugins/iCheck/square/blue.css" />
      <link rel="stylesheet" href="AdminLTE/plugins/pace/pace.min.css"/>

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
  <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
  <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
  <![endif]-->
    <!-- Google Font -->
  <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600,700,300italic,400italic,600italic">
  <style>
   
    .example-modal .modal {
      position: relative;
      top: auto;
      bottom: auto;
      right: auto;
      left: auto;
      display: block;
      z-index: 1;
      
    }

    .example-modal .modal {
      background: transparent !important;
    }

  </style>

</head>
<body class="hold-transition login-page" <%--style="background-image:url(AdminLTE/dist/img/background.jpg);background-repeat:repeat;--%>">
    <form id="form1" runat="server">
        

        <div class="login-box">
            <div class="login-logo">
                <a href="#"><img src="AdminLTE/dist/img/logo.png"/></a>
            </div>
            <!-- /.login-logo -->
            <div class="login-box-body">
                 <asp:Literal ID="ltlMessage" runat="server"></asp:Literal>
                <p class="login-box-msg">Sign in to start your session</p>

                <div class="form-group has-feedback">
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="Enter Username"></asp:TextBox>
                    <span class="glyphicon glyphicon-envelope form-control-feedback"></span>
                </div>
                <div class="form-group has-feedback">
                    <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" placeholder="Password" TextMode="Password" OnTextChanged="txtPassword_TextChanged" AutoPostBack="true"></asp:TextBox>
                    <span class="glyphicon glyphicon-lock form-control-feedback"></span>
                </div>
                <div class="row">
                    <div class="col-xs-8">
                        <div class="checkbox icheck">
                            <label>
                                <asp:CheckBox ID="chbRememberMe" runat="server" Text="Remember Me"/>
                            </label>
                        </div>
                    </div>
                    <div class="col-xs-4">
                        <asp:LinkButton ID="btnSignin" runat="server" data-toggle="modal" data-target="#modal-primary" CssClass="btn btn-primary btn-block btn-flat ajax" OnClick="btnSignin_Click" title="Ajax Request"><i class="glyphicon glyphicon-log-in"></i> Sign in</asp:LinkButton>
                    </div>
                </div>
                <a href="forgotpassword.aspx">I forgot my password</a><br/>
                <a href="signup.aspx" class="text-center">Sign Up</a>
                <!-- /.modal -->
                
       <%-- <div class="modal modal-primary fade" id="modal-primary">
          <div class="modal-dialog">
            <div class="modal-content">
              <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                  <span aria-hidden="true">&times;</span></button>
                <h4 class="modal-title">Default Modal</h4>
              </div>
              <div class="modal-body">
                <p>Thank for using our System !&hellip;</p>
              </div>
              <div class="modal-footer">
                <button type="button" class="btn btn-default pull-left" data-dismiss="modal">Close</button>
              </div>
            </div>
            <!-- /.modal-content -->
          </div>
          <!-- /.modal-dialog -->
        </div>--%>
        <!-- /.modal -->
            </div>
            <div class="lockscreen-footer text-center">
    Copyright &copy; 2014-2019 <b><a href="http://softwaremyanmar.com" class="text-black">Software Myanmar</a></b><br/>
    All rights reserved
  </div>
        </div>
    </form>

    <script src="AdminLTE/bower_components/jquery/dist/jquery.min.js"></script>
<!-- Bootstrap 3.3.7 -->
<!-- FastClick -->
<script src="AdminLTE/bower_components/fastclick/lib/fastclick.js"></script>
<!-- AdminLTE App -->
<script src="AdminLTE/dist/js/adminlte.min.js"></script>
<!-- AdminLTE for demo purposes -->
<script src="AdminLTE/dist/js/demo.js"></script>
    <script src="AdminLTE/plugins/jQuery/jquery-2.2.3.min.js"></script>
    <!-- Bootstrap 3.3.6 -->
    <script src="AdminLTE/bootstrap/js/bootstrap.min.js"></script>
     <script src="AdminLTE/plugins/pace/pace.min.js"></script>
    <!-- iCheck -->
    <script src="AdminLTE/plugins/iCheck/icheck.min.js"></script>
    <script>
        $(function () {
            $('input').iCheck({
                checkboxClass: 'icheckbox_square-blue',
                radioClass: 'iradio_square-blue',
                increaseArea: '20%' // optional
            });
        });
       function SetTarget() {
           document.forms[0].target = "_blank";
       }

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
