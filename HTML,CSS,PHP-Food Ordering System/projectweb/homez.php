<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<link rel="stylesheet" type="text/css" href="css/home.css"/>
<link rel="stylesheet" type="text/css" href="css/loader.css"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Food Ordering System</title>

</head>

<body onload="myFunction()" style="margin:0;">

<div id="loader"></div>

<div style="display:none;" id="myDiv" class="animate-bottom">
<div class="pic">
<form method="post" action="homez.php">
<nav>
<ul>
<li><a href="signin.php">Login as Admin</a></li>
<li><a href="signin-customer.php">Login as Customer</a></li>
</ul>
</nav>

<div id="content">
<h1>Food Ordering System</h1>
<h5>No compromise in taste</h5>
<center>
<table>
<tr>
<td><input type="submit" value="Register admin" name="admin" /></td><td></td><td></td><td></td><td><input type="submit" value="Register Customer" name="customer" /></td>
</tr>
</table>
</center>
</div>

<footer>
<div class="footerLeft">
<a href="#">Privacy</a>
<a href="#">Contact</a>
<a href="#">About</a>
</div>
<div class="footerRight">
All rights Reserved &copy; 2018
</div>
</footer>

<?php
if(isset($_POST['admin']))
{
	header("Location:signup.php");
	}
	
if(isset($_POST['customer']))
{
	header("Location:signup-customer.php");
	}	
?>
</form>
</div>
</div>
<script>
var myVar;

function myFunction() {
  myVar = setTimeout(showPage, 3000);
}

function showPage() {
  document.getElementById("loader").style.display = "none";
  document.getElementById("myDiv").style.display = "block";
}
</script>

</body>
</html>