<?php
$error1='';
if(isset($_POST['submit']))
{
		$name = $_POST['name1'];
		$pass = $_POST['pass1'];
		
		
		$conn = mysqli_connect('localhost','root','','project');
		$query = mysqli_query($conn, "SELECT * FROM customer WHERE Password='$pass' AND name='$name'");
		 
		$rows = mysqli_num_rows($query);
		if($rows == 1){
			//echo "<h1>Hello ".$name."</h1>";
			if(isset($_POST['remember']) )
			{
				setcookie('name', $name, time()+60*60*7);
			}
			
			session_start();
			$_SESSION['name']=$name;
			
			header("Location:home-customer.php");
			}
			
			else{
				$error1 = 'Username or Password is invalid';
				echo 'error';
				}
				
		
	}
?>