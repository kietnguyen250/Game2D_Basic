<?php



    // Connect to your database
    $dsn = "mysql:host=localhost;dbname=nguoichoi";
    $user = 'root';
    $pass = '';
    $db = new PDO($dsn, $user, $pass);

    $db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    // $id = $_POST['id'];
    // $usn = $_POST['ussername'];
    // $pwd = $_POST['password'];
    // $lv = $_POST['level'];
    // $pnt = $_POST['point'];

    

    // SQL
    $stmt = $db->prepare("SELECT * FROM player WHERE ussername LIKE 'Meliodas'"); 

    // Thực thi câu truy vấn
    $stmt->execute();
 
    // Khai báo fetch kiểu mảng kết hợp
    $stmt->setFetchMode(PDO::FETCH_ASSOC); 
     
    // Lấy danh sách kết quả
    $result = $stmt->fetchAll();
     
    // Lặp kết quả
    foreach ($result as $item){
        echo $item['$id'] . ' - '. $item['content'];
    }
// }
// catch(PDOException $e) {
//     echo "Lỗi: " . $e->getMessage();
// }

    // $SQL = "SELECT * FROM player WHERE ussername LIKE '$usn'";

    // $result = $db->query($SQL);

    // if($db->exec($SQL) == TRUE){
    //     echo "thanhcong";
    // }
    // else{
    //     echo "khong thanh cong";
    // }

?>