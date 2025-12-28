 
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ElectricityBoardBilling.Login" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <style>
         body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background: #f0f4f8;  
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
        }

         .login-wrapper {
            display: flex;
            justify-content: center;
            align-items: center;
            width: 100%;
            height: 100%;
        }

         .login-container {
            background-color: white;
            padding: 40px 30px;
            border-radius: 12px;
            box-shadow: 0 5px 15px rgba(0,0,0,0.1);
            width: 350px;
            text-align: center;
        }

         .login-container h3 {
            margin-bottom: 25px;
            color: #333;
            font-size: 24px;
        }

         .login-container label {
            display: block;
            text-align: left;
            margin-bottom: 5px;
            font-weight: bold;
            color: #555;
        }

         .login-container input[type="text"],
        .login-container input[type="password"] {
            width: 100%;
            padding: 10px;
            margin-bottom: 15px;
            border: 1px solid #ccc;
            border-radius: 8px;
            box-sizing: border-box;
            font-size: 14px;
        }

         .login-container button,
        .login-container input[type="submit"] {
            width: 100%;
            padding: 12px 0;
            background-color: #2196F3;  
            color: white;
            border: none;
            border-radius: 8px;
            font-size: 16px;
            cursor: pointer;
            transition: 0.3s;
            margin-top: 10px;
        }

        .login-container button:hover,
        .login-container input[type="submit"]:hover {
            background-color: #1e88e5;
        }

         .login-container .error-label {
            color: red;
            font-size: 13px;
            margin-top: 5px;
            display: block;
        }

         @media(max-width: 400px) {
            .login-container {
                width: 90%;
                padding: 30px 20px;
            }
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
         <div class="login-container">
            <h3>Admin Login</h3>

            <label for="txtUser">Username:</label>
            <asp:TextBox ID="txtUser" runat="server" CssClass="input-field" />

            <label for="txtPass">Password:</label>
            <asp:TextBox ID="txtPass" runat="server" TextMode="Password" CssClass="input-field" />

            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />

            <asp:Label ID="lblMsg" runat="server" CssClass="error-label" />
        </div>
 
    </form>
</body>
</html>
