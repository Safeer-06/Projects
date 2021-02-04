<?php
session_start();
require_once("dbcontroller.php");
$db_handle = new DBController();
if(!empty($_GET["action"])) {
switch($_GET["action"]) {
	case "add":
		if(!empty($_POST["quantity"])) {
			$productByitemcode = $db_handle->runQuery("SELECT * FROM item WHERE itemcode='" . $_GET["itemcode"] . "'");
			$itemArray = array($productByitemcode[0]["itemcode"]=>array('itemname'=>$productByitemcode[0]["item_name"], 'itemcode'=>$productByitemcode[0]["itemcode"], 'quantity'=>$_POST["quantity"], 'price'=>$productByitemcode[0]["price"]));
			
			if(!empty($_SESSION["cart_item"])) {
				if(in_array($productByitemcode[0]["itemcode"],array_keys($_SESSION["cart_item"]))) {
					foreach($_SESSION["cart_item"] as $k => $v) {
							if($productByitemcode[0]["itemcode"] == $k) {
								if(empty($_SESSION["cart_item"][$k]["quantity"])) {
									$_SESSION["cart_item"][$k]["quantity"] = 0;
								}
								$_SESSION["cart_item"][$k]["quantity"] += $_POST["quantity"];
							}
					}
				} else {
					$_SESSION["cart_item"] = array_merge($_SESSION["cart_item"],$itemArray);
				}
			} else {
				$_SESSION["cart_item"] = $itemArray;
			}
		}
	break;
	case "remove":
		if(!empty($_SESSION["cart_item"])) {
			foreach($_SESSION["cart_item"] as $k => $v) {
					if($_GET["itemcode"] == $k)
						unset($_SESSION["cart_item"][$k]);				
					if(empty($_SESSION["cart_item"]))
						unset($_SESSION["cart_item"]);
			}
		}
	break;
	case "empty":
		unset($_SESSION["cart_item"]);
	break;	
}
}
?>
<HTML>
<HEAD>
<link rel="stylesheet" type="text/css" href="css/topnav.css"/>
<link rel="stylesheet" type="text/css" href="css/InputBox-and-submit.css"/>
<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.5.0/css/all.css" integrity="sha384-B4dIYHKNBt8Bc12p+WXckhzcICo0wtJAoU8YZTY5qE0Id1GSseTk6S+L3BlXeVIU" crossorigin="anonymous">
<link rel="stylesheet" type="text/css" href="css/table.css"/>
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<link rel="stylesheet" type="text/css" href="css/indexcss.css">
<TITLE>Simple PHP Shopping Cart</TITLE>

</HEAD>
<BODY>
<body>




<!-- header start-->
  <div class="navbar">
  <a href="home-customer.php"><i class="fa fa-home"></i>   Home</a>
  <a href="aboutus - Customer.php">About</a>
  <a href="index.php">Order Food</a>
  <a href="customer-history.php">Order History</a>
  <a href="cpass-customer.php">Change Password</a>
   <a href="logout-customer.php"><i class="fa fa-power-off" style="font-size:15px"></i>  Logout</a>
</div>
 <!-- header Finsih-->

 
 <form method="post" action="index.php">
<div id="shopping-cart">
<div class="txt-heading">Shopping Cart <a id="btnEmpty" href="index.php?action=empty">Empty Cart</a></div>
<?php
if(isset($_SESSION["cart_item"])){
    $item_total = 0;
?>	
<table cellpadding="10" cellspacing="1">
<tbody>
<tr>
<th style="text-align:left;"><strong>Name</strong></th>
<th style="text-align:left;"><strong>Itemcode</strong></th>
<th style="text-align:right;"><strong>Quantity</strong></th>
<th style="text-align:right;"><strong>Price</strong></th>
<th style="text-align:center;"><strong>Action</strong></th>
</tr>	

<?php
	$totalquantity=0;
    foreach ($_SESSION["cart_item"] as $item){
		$totalquan = 0;
		
		?>
				<tr>
				<td style="text-align:left;border-bottom:#F0F0F0 1px solid;"><strong><?php echo $item["itemname"]; ?></strong></td>
				<td style="text-align:left;border-bottom:#F0F0F0 1px solid;"><?php echo $item["itemcode"]; ?></td>
				<td style="text-align:right;border-bottom:#F0F0F0 1px solid;"><?php echo $item["quantity"]; ?></td>
				<td style="text-align:right;border-bottom:#F0F0F0 1px solid;"><?php echo "$".$item["price"]; ?></td>
				<td style="text-align:center;border-bottom:#F0F0F0 1px solid;"><a href="index.php?action=remove&itemcode=<?php echo $item["itemcode"]; ?>" class="btnRemoveAction">Remove Item</a></td>
				</tr>
				<?php
        $item_total += ($item["price"]*$item["quantity"]);
		$totalquantity += $totalquan +  $item["quantity"];
		}
		$itemname = $item["itemname"];
		$quantity = $item["quantity"];
		
		?>

<tr>
<td colspan="5" align=right><strong>Total:</strong> <?php echo "$".$item_total; ?></td></tr><tr>
<td colspan="5" align=right><strong>Total Quantity:</strong> <?php echo "".$totalquantity; ?> </td>
</tr>
</tbody>
</table> <br>	
<center>

<input type="submit" name="Order" value="Order"/>
</form>
 </center>	
  <?php
  $con = mysqli_connect('localhost','root','','project');
  if(isset($_POST['Order']))
  {
$custname = $_SESSION['name'];
$quantity = "$totalquantity";
$total = "$item_total";

$query= "INSERT INTO `customerorder` (`customer_name`,`Quantity`,`price`,`dateandtime`) VALUES ('$custname','$quantity','$total',NOW())";
$run = mysqli_query($con,$query);
if($run==true)
{
	//echo "<script> alert('Record inserted');
	header("Location:invoice-customer.php");
	}
else{
	echo "<script> alert('Record not inserted'); </script>";
	}	
	  }
}
?>
</div>

<div id="product-grid">
	<div class="txt-heading">Products</div>
	<?php
	$product_array = $db_handle->runQuery("SELECT * FROM item ORDER BY id ASC");
	if (!empty($product_array)) { 
		foreach($product_array as $key=>$value){
	?>
		<div class="product-item">
			<form method="post" action="index.php?action=add&itemcode=<?php echo $product_array[$key]["itemcode"]; ?>">
			
			<div><strong><?php echo $product_array[$key]["item_name"]; ?></strong></div>
			<div class="product-price"><?php echo "$".$product_array[$key]["price"]; ?></div>
			<div><input type="text" name="quantity" value="1" size="2" /><input type="submit" value="Add to cart" class="btnAddAction" /></div>
			</form>
		</div>
	<?php
			}
	}
	?>
</div>


</BODY>
</HTML>