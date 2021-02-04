<html xmlns="http://www.w3.org/1999/xhtml">


<head>
<link rel="stylesheet" type="text/css" href="css/topnav.css"/>
<link rel="stylesheet" type="text/css" href="css/InputBox-and-submit.css"/>
<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.5.0/css/all.css" integrity="sha384-B4dIYHKNBt8Bc12p+WXckhzcICo0wtJAoU8YZTY5qE0Id1GSseTk6S+L3BlXeVIU" crossorigin="anonymous">
<link rel="stylesheet" type="text/css" href="css/table.css"/>
<link rel="stylesheet" type="text/css" href="css/loader.css"/>
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">

<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Search Items</title>
>

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
  

 <div align="center"><p style="font-size:30px; font-weight:300; margin-bottom:30px;">Search Menu Items</font></p></div>
 <br />
 <div class="w3-container">
 <?php
 
$con = mysqli_connect('localhost','root','','project');
$displayForm = True;  //variable used to hide form



if(isset($_POST['search'])){
	$id = $_POST["id"];
	$displayForm = False;
	$run = mysqli_query($con,"SELECT * FROM item WHERE id = $id");
	
	$row1 = mysqli_fetch_array($run);
	if($id == $row1["id"])
	{
		 echo '<table id="table"> 
	      <tr>
          <th>ID</th><th>Name</th><th>Item Code</th><th>price</th>
          </tr>
		  <tr>
		  <td>'.$row1["id"].'</td> <td>'.$row1["item_name"].'</td> <td>'.$row1["itemcode"].'</td> <td>$'.$row1["price"].'</td>
		  </tr>
	 </table>';
		}
		else{
			echo 'Item not Found';
			}
		
			
			
	}
	

?>
</div>

<div class="w3-container">
<?php	

if ($displayForm){
?>
<form action="search-item.php" method="post">
<center>
ID : <input type="text" name="id" required/><br><br>
<input type="submit" value="Search" name="search">
<hr>

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
	 </table>';
	
	}
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


	

 