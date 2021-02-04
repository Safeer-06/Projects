<html xmlns="http://www.w3.org/1999/xhtml">
<head><script src="validation.js"></script>
<link rel="stylesheet" type="text/css" href="css/style.css">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Signin Form</title>
<style>
input[type=submit]
{
	
	background: transparent;
	border:none;
	outline:none;
	color:#fff;
	background:#03a9f4;
	padding:10px 20px;
	cursor:pointer;
	border-radius:5px;
	
	}
</style>
</head>

<body>
<div class="box"><center>
<img src="img/men.png"/><br><h2>Admin</h2></center>
<form method="post" action="getdataAdmin.php" onSubmit="return(Vsignin())">
<br />
<div class="inputBox">
<input type="text" name="name1"  required="" /><label>Username</label>
</div><br>
<div class="inputBox">
<input type="password" name="pass1" minlength="5" maxlength="15"  required=""/><label>Password</label></div>
<br>
<div class="inputBox">
<input type="checkbox" value="remember" name="remember"/><label>Remember me</label></div>
<input type="submit" value="Login" name="submit"/><br /><br />
<?php
include 'getdataAdmin.php';?>
<?php echo $error1; ?><br><br>

<font color="#FFFFFF">Don't have a account?</font> <a href="signup.php">Signup</a>
<br>
<a href="homez.php"> Go back to home screen</a><br>
</div>

</form>
</div>
</body>
</html>