<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<link rel="stylesheet" type="text/css" href="css/topnav.css"/>
<link rel="stylesheet" type="text/css" href="css/slideshow.css"/>
<link rel="stylesheet" type="text/css" href="css/imageAndContainer.css"/>
<link rel="stylesheet" type="text/css" href="css/loader.css"/>
<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.5.0/css/all.css" integrity="sha384-B4dIYHKNBt8Bc12p+WXckhzcICo0wtJAoU8YZTY5qE0Id1GSseTk6S+L3BlXeVIU" crossorigin="anonymous">
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">

<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Home</title>



</head>

<body onload="myFunction()" style="margin:0;">

<div id="loader"></div>

<div style="display:none;" id="myDiv" class="animate-bottom">

<!--Nav bar with side nav
<nav class="header">
    <span class="open-slide">
      <a href="#" onclick="openSlideMenu()"> 
        <svg width="30" height="30">
            <path d="M0,5 30,5" stroke="#fff" stroke-width="5"/>
            <path d="M0,14 30,14" stroke="#fff" stroke-width="5"/>
            <path d="M0,23 30,23" stroke="#fff" stroke-width="5"/>
        </svg>
      </a>
    </span>

    <ul class="navbar-nav">
      <li><a href="home-admin.php">Gusteau's</a></li>
    </ul>
    
    <ul class="navbar-nav">
      <li><a href="home-admin.php"></a></li>
    </ul>
    
  </nav>
  
   <div id="side-menu" class="side-nav">
    <a href="#" class="btn-close" onclick="closeSlideMenu()">&times;</a>
    <a href="#">Home</a>
    <a href="#">About</a>
    <a href="#">Services</a>
    <a href="#">Contact</a>
  </div>
  
  <div id="main">
   -->
  
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

?>  
   <a href="logout.php"><i class="fa fa-power-off" style="font-size:15px"></i>  Logout</a>
</div>


  
  <!--Main area -->
    
  
  
  <!--slideshow start -->
  
  <div class="slideshow-container">

<div class="mySlides fade">
  <img src="img/slideshow images/1.png" style="width:100%">
</div>

<div class="mySlides fade">
  <img src="img/slideshow images/2.jpg" style="width:100%">
</div>

<div class="mySlides fade">
  <img src="img/slideshow images/three.jpg" style="width:100%">
</div>

<div class="mySlides fade">
  <img src="img/slideshow images/44.jpg" style="width:100%">
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

<div style="background-color:#666; color:#FFF; height:55px; padding:20px 13px 23px; font-size:25px;"><strong>Featured</strong></div><br /><br />
<center>
<!--Image 1-->
<div class="gallery">

<img src="img/slideshow images/tandoori.jpg" style="height:180px;">
<div class="desc"><h4>Chicken Tandoori</h4><p>Tandoori chicken is chicken dish prepared by roasting chicken marinated in yoghurt and spices in a tandoor.</p></div>
</div>

<!--Image 2-->
<div class="gallery">
<img src="img/slideshow images/tikka.jpg" style="height:180px;">
<div class="desc"><h4>Chicken Tandoori</h4><p>Chicken tikka is a chicken dish originating in the Punjab region in the northern part of the Indian subcontinent</p></div>
</div>

<!--Image 3-->
<div class="gallery">
<img src="img/slideshow images/manchorian.jpg" style="height:180px;">
<div class="desc"><h4>Chicken Manchurian</h4><p>In addtion in today being the first day i can wake up early for self initiated work</p></div>
</div>

<!--Image 4-->
<div class="gallery">
<img src="img/slideshow images/thai chips.jpg" style="height:180px;">
<div class="desc"><h4>Thai Finger Chips</h4><p>Add endless style to your wardrobe by getting this thick blue coloured dress by VERO MODA. This flare...</p></div>
</div>
</center>

 
 
  <script>   <!--For opening and closing side navbar -->
    function openSlideMenu(){
      document.getElementById('side-menu').style.width = '250px';
      document.getElementById('main').style.marginLeft = '250px';
    }

    function closeSlideMenu(){
      document.getElementById('side-menu').style.width = '0';
      document.getElementById('main').style.marginLeft = '0';
    }
	
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