<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head><script src="validation.js"></script>
<link rel="stylesheet" type="text/css" href="css/topnav.css"/>
<link rel="stylesheet" type="text/css" href="css/InputBox-and-submit.css"/>
<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.5.0/css/all.css" integrity="sha384-B4dIYHKNBt8Bc12p+WXckhzcICo0wtJAoU8YZTY5qE0Id1GSseTk6S+L3BlXeVIU" crossorigin="anonymous">
<link rel="stylesheet" type="text/css" href="css/table.css"/>
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<link rel="stylesheet" type="text/css" href="css/loader.css"/>

<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

<title>Add Items</title>
</head>

<body onload="myFunction()" style="margin:0;">

<div id="loader"></div>

<div style="display:none;" id="myDiv" class="animate-bottom">

  
 <!-- header start-->
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

 <!-- header Finsih-->
<div class="w3-container"> 
<p style="font-size:30px; font-weight:300; margin-bottom:30px;">Add Items</font></p>
 <br />
 <form name="myform" method="post" action="add- admin.php" onsubmit="return(Vadd())">
 <table cellspacing="200px" id="tab">
 <tr>
 <th>Name</th><th>Item Code</th><th>Price</th>
 </tr>
 <tr>
 <td><div class="inputBox"><input type="text" name="itemname" required/><label>Name</label></div></td>
 <td><div class="inputBox"><input type="text" name="itemcode" minlength="2" maxlength="8"  size="30" required/><label>Item Code</label></div></td>
 <td><div class="inputBox"><input type="text" name="price" maxlength="5" size="30" required /><label>Price</label></div></td>
 </tr>
 </table><br />
 <center><input type="submit" value="Add" name="add" /></center>
<br />
 </form>
 </div>
 
 
 
<!--
<form method="post" action="admin-manageitems.php">
<center>


<div class="textfield">
<input type="text" name="itemname" required/><label>Item Name</label>
</div><br>

<div class="textfield">
<input type="text" name="price" required/><label>Price</label>
</div><br>
<input type="submit" value="Add" name="add"/>
<hr />

</center>
</form>
-->
<?php

$con = mysqli_connect('localhost','root','','project');

if(isset($_POST['add'])){
	
$itemname = $_POST['itemname'];
$itemcode = $_POST['itemcode'];
$price = $_POST['price'];

$query= "INSERT INTO `item` (`item_name`,`itemcode`,`price`) VALUES ('$itemname','$itemcode','$price')";
$run = mysqli_query($con,$query);
if($run!=true)
{
	echo "<script> alert('Record Not inserted'); </script>";
	}

}
?>
<div class="w3-container"> 

<center><h2>Order Food</h2></center>
<?php

$res = mysqli_query($con,"SELECT * FROM item;");

while ($row = mysqli_fetch_array($res))
{
echo     '<table id="table"> 
	      <tr>
          <th>ID</th><th>Name</th><th>Item Code</th><th>Price</th>
          </tr>
		  <tr>
		  <td>'.$row["id"].'</td> <td>'.$row["item_name"].'</td> <td>'.$row["itemcode"].'</td> <td>$'.$row["price"].'</td>
		  </tr>
	 </table>
	 
	 
	';
	
	}
?>
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
</div>
</body>
</html>