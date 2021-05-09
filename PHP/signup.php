<?php



    // Connect to your database
    $dsn = "mysql:host=localhost;dbname=nguoichoi";
    $user = 'root';
    $pass = '';
    $db = new PDO($dsn, $user, $pass);

    $id = $_POST['id'];
    $usn = $_POST['username'];
    $pwd = $_POST['password'];
    $lv = $_POST['level'];
    $pnt = $_POST['point'];

    // SQL

    $SQL = "INSERT INTO player VALUES('$id', '$usn', '$pwd', $lv, $pnt)";

    if($db->exec($SQL) == TRUE){
        echo "thanhcong";
    }
    else{
        echo "khong thanh cong";
    }

?>