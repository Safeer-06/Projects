
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<link rel="stylesheet" type="text/css" href="css/style.css">
<script src="validation.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Signup Form</title>
<style>

input[type=submit]
{
	width:300px;
	background-color:#009;
	color:#fff;
	border:2px solid #86F;
	padding:17px;
	font-size:20px;
	cursor:pointer;
	border-radius:9px;
	margin-bottom:15px;
	
	}
</style>
</head>

<body>
<center>
<div class="box">
<form name="myform" method="post" action="signup-customer.php" onSubmit="return(Vdata())" >

<h2>REGISTER</h2>
<hr><br>
<div class="inputBox">
<input type="text" name="name"   required/><label>Username</label></div><br>
<div class="inputBox">
<input type="text" name="email" required /><label>Email</label></div><br>
<div class="inputBox">
<input type="text" name="mblno"required /><label>Mobile no</label></div><br>
<div class="inputBox">
<input type="password" name="pass" minlength="5" maxlength="15" required/><label>Password</label></div><br>
<div class="inputBox">
<input type="password" name="pass1" minlength="5" maxlength="15"  required/><label>Confirm password</label><br>

<br />
<input type="submit" value="Register" name="submit" /><br>
<?php
include 'insertuser.php';?>
<span style="color:#FFF;"><b><?php echo $error; ?>
</b></span>
<br /><br/>
<font color="#FFFFFF">Already a member?</p></font><a href="signin-customer.php"> login</a><br>
<br>
<a href="homez.php"> Go back to home screen</a><br>
</center>
</form>
</div>
</body>
</html>

