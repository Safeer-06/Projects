<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<link rel="stylesheet" type="text/css" href="css/topnav.css"/>
<link rel="stylesheet" type="text/css" href="css/InputBox-and-submit.css"/>
<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.5.0/css/all.css" integrity="sha384-B4dIYHKNBt8Bc12p+WXckhzcICo0wtJAoU8YZTY5qE0Id1GSseTk6S+L3BlXeVIU" crossorigin="anonymous">
<link rel="stylesheet" type="text/css" href="css/table.css"/>
<link rel="stylesheet" type="text/css" href="css/loader.css"/>
<link rel="stylesheet" type="text/css" href="css/slideshow.css"/>
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">

<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>About us</title>
<style>
.container {
  position: relative;
  text-align: center;
  color: white;
}


.centered {
  position: absolute;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);}
  
  .container1
{
width:500px;
height:800px;
background-color:#FF;
position:fixed;
margin-left:160px;
margin-top:30px;
text-align:left;
}

.container2
{
width:500px;
height:800px;
background-color:#FF;
position:fixed;
margin-left:700px;
margin-top:30px;
}
  
  </style>
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
 
 <div class="container">
  <img src="img/table.jpg" alt="Snow" style="width:100%; height:250px;">
  <div class="centered"><p style="font-size:60px; font-style:oblique;">About Us</p></div>
</div>
 
<div class="container1">
<center>
<h1>Guesteu's</h1></center>
<p>Guesteu's is a contemporary fine dining Chinese restaurant that serves flavorful Chinese cuisine in a sleek and colorful environment.</p>
<p>Located in the popular upscale dining areas of Karachi, Gusteu's is an ideal choice for Authentic Chinese cuisine in elegant surroundings. As the “Extreme Chinese” name suggests, Ginsoy was created with an inspiration to bring unique, striking and flavorful Chinese cuisine to Pakistan.
</p>
<p>The menu is comprised of a variety special recipes which incorporate top quality ingredients, unique flavors, all with reasonable prices. Ginsoy specializes in offering classic recipes with a modern twist that incorporate many interesting and unique ingredients.</p>

<br />

</div>

<div class="container2">
<!--slideshow start -->
  
  <div class="slideshow-container">

<div class="mySlides fade">
  <img src="img/about/1.jpg" style="width:100%; height:400px;">
</div>

<div class="mySlides fade">
  <img src="img/about/2.jpg" style="width:100%; height:400px">
</div>

<div class="mySlides fade">
  <img src="img/about/3.jpg" style="width:100%; height:400px;">
</div>

<div class="mySlides fade">
  <img src="img/about/4.jpg" style="width:100%; height:400px;">
</div>


</div>
<br>

<div style="text-align:center">
  <span class="dot"></span> 
  <span class="dot"></span> 
  <span class="dot"></span> 
   <span class="dot"></span> 
</div> 


<br />
</div>
 <script>
 //slide show JS
	var slideIndex = 0;
showSlides();

function showSlides() {
  var i;
  var slides = document.getElementsByClassName("mySlides");
  var dots = document.getElementsByClassName("dot");
  for (i = 0; i < slides.length; i++) {
    slides[i].style.display = "none";  
  }
  slideIndex++;
  if (slideIndex > slides.length) {slideIndex = 1}    
  for (i = 0; i < dots.length; i++) {
    dots[i].className = dots[i].className.replace(" active", "");
  }
  slides[slideIndex-1].style.display = "block";  
  dots[slideIndex-1].className += " active";
  setTimeout(showSlides, 3500); // Change image every 2 seconds
}

  </script>
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