function VData() {
var rex_email=/[a-z0-9]{4,25}@[a-z]{4,9}.(com|net|org|info)/g;
var rex_username=/[a-zA-Z]{2,20}/g;
var rex_phonenum=/[0-9]{5,15}/g;
var eBool= new Boolean();
eBool=rex_email.test(document.myform.email.value); //document.write(eBool); 
var nBool= new Boolean();
nBool=rex_username.test(document.myform.name.value);
var pBool= new Boolean();
pBool=rex_phonenum.test(document.myform.mblno.value);
if(nBool) { 

 } else 
{ 
alert("please enter name in correct format");
return false; }
if(eBool) { 

 } else 
{ 
alert("please enter email in correct format");
return false; }
if(pBool) { 

 } else 
{ 
alert('please enter "phone number" in correct format');
return false; }
return true;
} 

function Vsignin() {
var rex_username=/[a-zA-Z]{2,20}/g;
var nBool= new Boolean();
nBool=rex_username.test(document.myform.name1.value);
if(nBool) { 

 } else 
{ 
alert("please enter name in correct format");
return false; }

} 
function Vadd() {
var rex_username=/[a-zA-Z]{2,20}/g;
var nBool= new Boolean();
nBool=rex_username.test(document.myform.itemname.value);
if(nBool) { 

 } else 
{ 
alert("please enter name in correct format");
return false; }
var rex_phonenum=/[0-9]/g;
var pBool= new Boolean();
pBool=rex_phonenum.test(document.myform.price.value);
if(pBool) { 

 } else 
{ 
alert('please enter price in correct format');
return false; }
return true;
} 