<?php

$dsn = "mysql:host=localhost;dbname=nguoichoi";
$user = 'root';
$pass = '';
$db = new PDO($dsn, $user, $pass);

$sql = "SELECT * FROM player";

$ketqua = $db->query($sql);

while($row=$ketqua->fetch())
{
    printf("%s-%s-%s-%s-%s-",$row[0],$row[1],$row[2],$row[3],$row[4]);
    print(",");
    // echo $row[0];
}

?>