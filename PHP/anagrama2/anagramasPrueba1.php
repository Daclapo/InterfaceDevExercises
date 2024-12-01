<?php

function sonAnagramas($a,$b){
    $a1=str_split(strtolower(str_replace(" ","",$a)));
    $b1=str_split(strtolower(str_replace(" ","",$b)));
    sort($a1);
    sort($b1);
    $a=implode($a1);
    $b=implode($b1);
    return ($a==$b);
}

?>


<!DOCTYPE html>
<html>
<head>
    <title>anagramas</title>
			<meta charset="UTF-8">
    <style>
        span{
            background-color:#DDD;
        }
    </style>
</head>
<body>
    <?php
    if(!$_REQUEST){ 
    ?>

    <form action="" method="get">
        <label for="a">Introduce la primera palabra:</label>
        <input type="text" name="a" id="a">
        <br>
        <label for="b">Introduce la segunda palabra:</label>
        <input type="text" name="b" id="b">
        <input type="submit" value="Enviar">
    </form>


    <?php
        exit;
    }else{
        $a = $_REQUEST['a'];
        $b = $_REQUEST['b'];

        if($a=="" || $b==""){
            echo "<h3>Debes introducir dos palabras</h3>";
            exit;
        }

        if(sonAnagramas($a,$b)){
            echo "<span>$a & $b</span><b> son </b> anagramas";
        }else{
            echo "<span>$a & $b</span><b> no son </b> anagramas";
        }
    }
    ?>
</body>
</html>