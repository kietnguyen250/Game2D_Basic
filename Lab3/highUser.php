<?php

$dsn = "mysql:host=localhost;dbname=dot2game";
$user = 'root';
$pass = '';
$db = new PDO($dsn, $user, $pass);

$sql = "SELECT * FROM user ORDER BY `level` DESC LIMIT 1;";

$ketqua = $db->query($sql);

while($row=$ketqua->fetch())
{
    printf("%s-%s-%s-",$row[0],$row[1],$row[2]);
    print(",");
    // echo $row[0];
}

?>