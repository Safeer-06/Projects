<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<?php
session_start();
?>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<style>
#container
{
width:800px;
height:500px;
margin-left:150px;
background-color:#FF;
position:fixed;

}
</style>
<link rel="stylesheet" type="text/css" href="css/topnav.css"/>
<link rel="stylesheet" type="text/css" href="css/loader.css"/>
<link rel="stylesheet" type="text/css" href="css/InputBox-and-submit.css"/>
<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.5.0/css/all.css" integrity="sha384-B4dIYHKNBt8Bc12p+WXckhzcICo0wtJAoU8YZTY5qE0Id1GSseTk6S+L3BlXeVIU" crossorigin="anonymous">
<link rel="stylesheet" type="text/css" href="css/table.css"/>
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">

<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Invoice</title>
</head>

<body onload="myFunction()" style="margin:0;">

<div id="loader"></div>

<div style="display:none;" id="myDiv" class="animate-bottom">

<!-- header start-->
  <div class="navbar">
  <a href="home-customer.php"><i class="fa fa-home"></i>   Home</a>
  <a href="#news">About</a>
  <a href="index.php">Order Food</a>
   <a href="logout.php"><i class="fa fa-power-off" style="font-size:15px;"></i>  Logout</a>
</div>
 <!-- header Finsih-->
 <center>
<h1>Estimated Recipt</h1></center><br />
<div id="container">
<?php

$name = $_SESSION['name'];

$con = mysqli_connect('localhost','root','','project');

	
$query = mysqli_query($con, "SELECT * FROM customerorder WHERE customer_name='$name'");
$row = mysqli_fetch_array($query);
if($name == $row["customer_name"])
{
	
	echo '
	<strong>Order no:</strong> '.$row["order_id"].'<br><strong>Customer Name:</strong> '.$row["customer_name"].'<br><strong>Date and Time: </strong>'.$row['dateandtime'].'<br>
	<table border=3 height=200 width=600 RULES=ROWS FRAME=BOX cellspacing="50" id="table"> 
	       <th style="text-align:left;">Item</th><th style="text-align:left;">Quantity</th><th style="text-align:left;">Price</th><tr>';
	foreach ($_SESSION["cart_item"] as $item){
		
	echo '<td style="text-align:left;">'
		.$item["itemname"].'</td><td style="text-align:left;">'.$item["quantity"].' pieces</td> '.'<td style="text-align:left;">Rs.'.$item["price"].'</td></tr>';
	}
	echo '<tr><td><strong>Total:</strong></td><td></td><td> Rs.'.$row["price"].'</td></tr></table>';
	}


?><br /><center>
<form method="post" action="invoice-customer.php">
<input type="submit" name="back" value="back" /></center>
</form>
<?php 
if(isset($_POST['back']))
{
	header("Location:home-customer.php");
	}
?>
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
</div>
</body>
</html>