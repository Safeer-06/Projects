<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<link rel="stylesheet" type="text/css" href="css/topnav.css"/>
<link rel="stylesheet" type="text/css" href="css/loader.css"/>
<link rel="stylesheet" type="text/css" href="css/slideshow.css"/>
<link rel="stylesheet" type="text/css" href="css/imageAndContainer.css"/>
<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.5.0/css/all.css" integrity="sha384-B4dIYHKNBt8Bc12p+WXckhzcICo0wtJAoU8YZTY5qE0Id1GSseTk6S+L3BlXeVIU" crossorigin="anonymous">
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">

<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Order History</title>
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
<!--navbar finish -->


<div class="w3-container">
<h3>All Orders</h3>
<p style="font-size:16px">List of all orders by customer</p><br />

<?php
$con = mysqli_connect('localhost','root','','project');
$res = mysqli_query($con,"SELECT * FROM customerorder;");

while ($row = mysqli_fetch_array($res))
{
echo     '<table id="table"> 
	      <tr><td>
		  <strong>Order No: '.$row["order_id"].'</strong><br><strong>Date: </strong>'.$row["dateandtime"].
		  '<br><strong>Payment Type: </strong>Cash on Delievery </td>
		  </tr>
		  <tr>
		  <td><strong>Customer Name:</strong> '.$row['customer_name'].'</td>
		  </tr>
		  <tr>
		  <td><strong>Quantity:</strong> '.$row['Quantity'].'</td>
		  </tr>
		  <tr>
		  <td><strong>Total:</strong> Rs. '.$row['price'].'</td>
		  </tr><hr>
		  </table>
          
	 
	 
	';
	
	}
?>
</div>
<h1>Enter the No. of the order that you wish to remove</h1>
<br /><br />
<form method="post" action="allorders-admin.php">
<label>No. of order:</label>
<input type="text" name="id"  required="" /><br>
<br /><br />
<input type="submit" value="Delete Order" name="deletion"/><br /><br />
<?php 
$con= mysqli_connect('localhost','root','','project');
if(isset($_POST['deletion']))
{
$ID = $_POST['id'];
if (mysqli_query($con,"DELETE FROM customerorder WHERE order_id='$ID'")) {
    echo " deleted";

}
else{

    echo " not deleted";

}

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