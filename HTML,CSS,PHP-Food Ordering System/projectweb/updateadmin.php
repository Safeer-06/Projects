<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<link rel="stylesheet" type="text/css" href="css/topnav.css"/>
<link rel="stylesheet" type="text/css" href="css/slideshow.css"/>
<link rel="stylesheet" type="text/css" href="css/imageAndContainer.css"/>
<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.5.0/css/all.css" integrity="sha384-B4dIYHKNBt8Bc12p+WXckhzcICo0wtJAoU8YZTY5qE0Id1GSseTk6S+L3BlXeVIU" crossorigin="anonymous">
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<link rel="stylesheet" type="text/css" href="css/header&navbar.css"/>
<head>
<link rel="stylesheet" type="text/css" href="css/topnav.css"/>
<link rel="stylesheet" type="text/css" href="css/InputBox-and-submit.css"/>
<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.5.0/css/all.css" integrity="sha384-B4dIYHKNBt8Bc12p+WXckhzcICo0wtJAoU8YZTY5qE0Id1GSseTk6S+L3BlXeVIU" crossorigin="anonymous">
<link rel="stylesheet" type="text/css" href="css/loader.css"/>
<link rel="stylesheet" type="text/css" href="css/table.css"/>
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<head><script src="validation.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Untitled Document</title>
</head>

<body onload="myFunction()" style="margin:0;">

<div id="loader"></div>

<div style="display:none;" id="myDiv" class="animate-bottom">

<div class="navbar">
  <a href="home-admin.php"><i class="fa fa-home"></i>   Home</a>
  <a href="aboutus.php">About</a>
  <div class="dropdown">
    <button class="dropbtn">Manage Item
       <i class="fa fa-caret-down"></i>
    </button>
    <div class="dropdown-content">
      <a href="add- admin.php">Add Item</a>
      <a href="search-item.php">Search Item</a>
      <a href="updateitem.php">Edit Item</a>
       <a href="deleteitem.php">Delete Item</a>
    </div>
  </div> 
  <div class="dropdown">
    <button class="dropbtn">Manage admins
       <i class="fa fa-caret-down"></i>
    </button>
    <div class="dropdown-content">
      <a href="deleteadmin.php">Delete admin</a>
      <a href="updateadmin.php">Update admin</a>
    </div>
  </div> 
  <a href="allorders-admin.php">Manage orders</a>
  <a href="cpass-admin.php">Change Password</a>
 <?php 
session_start();
//echo "Welcome back " . $_SESSION['name'] . "!";
?>  
   <a href="logout.php"><i class="fa fa-power-off" style="font-size:15px"></i>  Logout</a>
</div>
<form form name="myform" method="post"  action="updateadmin.php" onSubmit="return(VData())" >
<center>
<h2>Edit Admin:</h2></center>
<hr><br>
<table>
<tr>
<td><label><strong>Username: </strong></label></td>

<td><input type="text" name="name"   required/></td>
</tr>
<tr><td>
<label><strong>Email:</strong> </label></td><td>
<input type="text" name="email" required /></td></tr>
<tr><td>
<label><strong>Mobile no: </strong></label></td><td>
<input type="text" name="mblno"required /></td></tr>
<tr><td>
<label><strong>Password: </strong></label></td><td>
<input type="password" name="pass" minlength="5" maxlength="15" required/></td></tr>
<tr><td>
<label><strong>ID of admin: </strong></label></td><td>
<input type="number" name="IDD" required/></td></tr></table><br />

<input type="submit" value="Update admin" name="update" /><br>
<?php
$con= mysqli_connect('localhost','root','','project');
if(isset($_POST['update']))
{
$namey = $_POST['name'];
$emaily = $_POST['email'];
$mblnoy = $_POST['mblno'];
$pass3 = $_POST['pass'];
$IDofadmin = $_POST['IDD'];
if (mysqli_query($con,"UPDATE admin SET name = '$namey',email ='$emaily',mblNo = '$mblnoy',Password = '$pass3' WHERE id = '$IDofadmin'")) {
    echo " admin details have been updated";

}
else{

    echo " admin details have not been updated";

}

}
?>
<?php

$res = mysqli_query($con,"SELECT * FROM admin;");
echo "Current admins:";
while ($row = mysqli_fetch_array($res))
{
echo     '<table id="table"> 
	      <tr>
          <th>ID</th><th>Name</th><th>Email</th><th>Mobile No.</th><th>Password</th>
          </tr>
		  <tr>
		  <td>'.$row["id"].'</td> <td>'.$row["name"].'</td> <td>'.$row["email"].'</td> <td>'.$row["mblNo"].'</td> <td>'.$row["Password"].'</td>
		  </tr>
	 </table>';
	
	}
?>
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
</div>
</body>
</html>