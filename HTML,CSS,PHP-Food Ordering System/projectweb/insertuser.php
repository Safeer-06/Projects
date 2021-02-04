<?php
$error='';
if(isset($_POST['submit'])){
$name = $_POST['name'];
$email = $_POST['email'];
$mblno = $_POST['mblno'];
$pass = $_POST['pass'];
$pass1 = $_POST['pass1'];

$con = mysqli_connect('localhost','root','','project');

if($pass == $pass1){
$query="INSERT INTO `customer` (`name`,`email`,`mblNo`,`Password`) VALUES ('$name','$email','$mblno','$pass')";
$run = mysqli_query($con,$query);
if($run==true)
{
	echo "Record inserted Successfully";
	}
	else{
		echo "Record not inserted <br>";
		}	
}
else{
	$error = 'Password does not match';
	}
}
?>


