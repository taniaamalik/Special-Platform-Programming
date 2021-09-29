<?php   

    REQUIRE_ONCE('koneksi.php');

    $QUERY = MYSQLI_QUERY($conn,"SELECT Jurusan, COUNT(Fakultas) as Jumlah FROM MAHASISWA GROUP BY Jurusan");
    
    WHILE($ROW = MYSQLI_FETCH_ASSOC($QUERY)){
    $mhs = new stdClass;
    $mhs-> Jurusan = $ROW['Jurusan'];
    $mhs-> Jumlah = $ROW['Jumlah'];
    $datamhs[] = $mhs;
    }

    $jmlhJurusan = Array($datamhs[1], $datamhs[0]);
    ECHO JSON_ENCODE($jmlhJurusan);

    MYSQLI_CLOSE($conn); 
    
?>