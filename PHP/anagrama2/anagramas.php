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
		echo "faltan parametros en la consulta";
	}else{
        $a = $_REQUEST['a'];
        $b = $_REQUEST['b'];
        if(sonAnagramas($a,$b)){
            echo "<span>$a & $b</span><b> son </b> anagramas";
        }else{
            echo "<span>$a & $b</span><b> no son </b> anagramas";
        }
    }
    ?>
</body>
</html>