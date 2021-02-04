<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<link rel="stylesheet" type="text/css" href="css/topnav.css"/>
<link rel="stylesheet" type="text/css" href="css/slideshow.css"/>
<link rel="stylesheet" type="text/css" href="css/imageAndContainer.css"/>
<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.5.0/css/all.css" integrity="sha384-B4dIYHKNBt8Bc12p+WXckhzcICo0wtJAoU8YZTY5qE0Id1GSseTk6S+L3BlXeVIU" crossorigin="anonymous">
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<link rel="stylesheet" type="text/css" href="css/topnav.css"/>
<link rel="stylesheet" type="text/css" href="css/InputBox-and-submit.css"/>
<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.5.0/css/all.css" integrity="sha384-B4dIYHKNBt8Bc12p+WXckhzcICo0wtJAoU8YZTY5qE0Id1GSseTk6S+L3BlXeVIU" crossorigin="anonymous">
<link rel="stylesheet" type="text/css" href="css/table.css"/>
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<link rel="stylesheet" type="text/css" href="css/loader.css"/>

<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Order history</title>

</head>

<body onload="myFunction()" style="margin:0;">

<div id="loader"></div>
<div style="display:none;" id="myDiv" class="animate-bottom">


<div class="navbar">
  <a href="home-customer.php"><i class="fa fa-home"></i>   Home</a>
  <a href="aboutus - Customer.php">About</a>
  <a href="index.php">Order Food</a>
  <a href="customer-history.php">Order History</a>
  <a href="cpass-customer.php">Change Password</a>
   <a href="logout-customer.php"><i class="fa fa-power-off" style="font-size:15px"></i>  Logout</a>
</div>
<center><h1>Your Order History</h1></center>
  <?php 
session_start();
$con = mysqli_connect('localhost','root','','project');
$cname = $_SESSION['name'];
$res = mysqli_query($con,"SELECT * FROM customerorder WHERE customer_name='$cname';");
//echo '<table id="table"> 
	      //<tr>
          //<th>Order ID</th><th>Customer Name</th><th>Quantity</th><th>Price</th><th>Time of order</th>
          //</tr>
		  //</table>';
while ($row = mysqli_fetch_array($res))
{
echo     '<table id="table"> 
		  <tr>
		  <tr>
          <th>Order ID</th><th>Customer Name</th><th>Quantity</th><th>Price</th><th>Time of order</th>
          </tr>
		  <td>'.$row["order_id"].'</td> <td>'.$row["customer_name"].'</td> <td>'.$row["Quantity"].'</td> <td>$'.$row["price"].'</td> <td>'.$row["dateandtime"].'</td>
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