<?php
if (($_POST[sender_name] == "") ||
	($_POST[sender_email] == "") ||
	($_POST[sender_message] == "")) {
	header("Location: contact.html");
	exit;}
	
$msg = "Email sent from the website\n";
$msg .="Sender's Name:      $_POST[sender_name]\n";
$msg .="Sender's Email:     $_POST[sender_email]\n";
$msg .="Sender's Message:   $_POST[sender_message]\n";

$to="info@healthcareaccessltd.co.uk";
$subject ="website feedback form";
$mailheaders ="From: info@healthcareaccessltd.co.uk <info@healthcareaccessltd.co.uk>\n";
$mailheaders .="Reply - to: $_POST [sender_email]\n";

mail($to, $subject, $msg, $mailheaders);
	
?>
<html>
</head>
<title>form submitted</title>
</head>
<body>
<p>
<h1>The following has been sent</h1>
<hr />

</p>
<a href="index.html"><h1>back to home page</h1></a>
<p />
<hr />

<p><strong> Your Name: </strong><br />
<?php echo "$_POST[sender_name]"; ?>
<p><strong> Your Email Address: </strong><br />
<?php echo "$_POST[sender_email]"; ?>
<p><strong> Your Message: </strong><br />
<?php echo "$_POST[sender_message]"; ?></p>


</body>
</html>