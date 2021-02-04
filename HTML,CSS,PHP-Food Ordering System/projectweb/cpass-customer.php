<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head><script src="validation.js"></script>
<link rel="stylesheet" type="text/css" href="css/topnav.css"/>
<link rel="stylesheet" type="text/css" href="css/InputBox-and-submit.css"/>
<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.5.0/css/all.css" integrity="sha384-B4dIYHKNBt8Bc12p+WXckhzcICo0wtJAoU8YZTY5qE0Id1GSseTk6S+L3BlXeVIU" crossorigin="anonymous">
<link rel="stylesheet" type="text/css" href="css/table.css"/>
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">

<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

<title>Add Items</title>
</head>

<body >

  
 <!-- header start-->
  <div class="navbar">
  <a href="home-customer.php"><i class="fa fa-home"></i>   Home</a>
  <a href="aboutus - Customer.php">About</a>
  <a href="index.php">Order Food</a>
  <a href="customer-history.php">Order History</a>
  <a href="cpass-customer.php">Change Password</a>
  <?php 
session_start();
//echo "Welcome back " . $_SESSION['name'] . "!";
?>
   <a href="logout-customer.php"><i class="fa fa-power-off" style="font-size:15px"></i>  Logout</a>
</div>
 <!-- header Finsih-->
<div class="w3-container"> 
<p style="font-size:30px; font-weight:300; margin-bottom:30px;">Change Password</font></p>
<h1>Input details</h1>
 <br />
 <form name="myform" method="post" action="cpass-customer.php">
 <table cellspacing="200px" id="tab">
 <tr>
 <td><div class="inputBox"><input type="text" name="name" required/><label>Your Name:</label></div></td>
 <td><div class="inputBox"><input type="password" name="password" minlength="5" maxlength="15" required/><label>New Password:</label></div></td>
  <td><div class="inputBox"><input type="password" name="cpass" minlength="5" maxlength="15" required/><label>Confirm Password:</label></div></td>
 </tr>
 </table><br />
 <center><input type="submit" value="Change Password" name="change" /></center>
<br />
 </form>
 </div>
<?php
$con = mysqli_connect('localhost','root','','project');
if(isset($_POST['change']))
{
$rilname=$_POST['name'];
$passi=$_POST['password'];
$cpass=$_POST['cpass'];
if($passi==$cpass && $rilname==$_SESSION['name'])
{
		$sql = "UPDATE customer SET Password = '$passi' WHERE name = '$rilname'";
		if (mysqli_query($con,$sql))
		{
			  # code...
    echo "Password has been changed";
		}
		else{
    		echo "Password not changed, some connection problem";
			}
	}
	else{
    echo "Password not changed, confirm password doesn't match or you are changing someone else's password";
}
}
?>

</div>
</body>
</html>