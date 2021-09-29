<?php   

    header('Access-Control-Allow-Origin: *');
    REQUIRE_ONCE('koneksi.php');

    $QUERY = MYSQLI_QUERY($conn,"SELECT * FROM MAHASISWA");
    
    // while($ROW = MYSQLI_FETCH_ASSOC($QUERY)){
    // $mhs = new stdClass;
    // $mhs-> NIM = $ROW['NIM'];  
    // $mhs-> Nama = $ROW['Nama'];
    // $mhs-> Jurusan = $ROW['Jurusan'];
    // $mhs-> Fakultas = $ROW['Fakultas'];
    // $mhs-> Alamat = $ROW['Alamat'];
    // $mhs-> NoHp = $ROW['NoHp'];
    // $mahasiswa[] = $mhs;
    // }
    $ROW = MYSQLI_FETCH_ASSOC($QUERY);
    $mhs1 = new stdClass;
    $mhs1-> NIM = $ROW['NIM'];  
    $mhs1-> Nama = $ROW['Nama'];
    $mhs1-> Jurusan = $ROW['Jurusan'];
    $mhs1-> Fakultas = $ROW['Fakultas'];
    $mhs1-> Alamat = $ROW['Alamat'];
    $mhs1-> NoHp = $ROW['NoHp'];
    $ROW = MYSQLI_FETCH_ASSOC($QUERY);
    $mhs2 = new stdClass;
    $mhs2-> NIM = $ROW['NIM'];  
    $mhs2-> Nama = $ROW['Nama'];
    $mhs2-> Jurusan = $ROW['Jurusan'];
    $mhs2-> Fakultas = $ROW['Fakultas'];
    $mhs2-> Alamat = $ROW['Alamat'];
    $mhs2-> NoHp = $ROW['NoHp']; 
    $ROW = MYSQLI_FETCH_ASSOC($QUERY);
    $mhs3 = new stdClass;
    $mhs3-> NIM = $ROW['NIM'];  
    $mhs3-> Nama = $ROW['Nama'];
    $mhs3-> Jurusan = $ROW['Jurusan'];
    $mhs3-> Fakultas = $ROW['Fakultas'];
    $mhs3-> Alamat = $ROW['Alamat'];
    $mhs3-> NoHp = $ROW['NoHp']; 

    $semuaMhs[] = $mhs1;
    $semuaMhs[] = $mhs3;
    $semuaMhs[] = $mhs2;

    header('Content-Type:application/json;charset=utf-8'); 

    ECHO JSON_ENCODE($semuaMhs);

    MYSQLI_CLOSE($conn); 
    
?>