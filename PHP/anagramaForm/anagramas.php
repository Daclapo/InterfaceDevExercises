<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Comparación de Strings</title>
</head>
<body>
    <?php
    if (isset($_REQUEST['param1']) && isset($_REQUEST['param2']) && !$_REQUEST) {
        $param1 = $_REQUEST['param1'];
        $param2 = $_REQUEST['param2'];

        $arr1 = str_split(strtolower(str_replace(" ", "", $param1)));
        $arr2 = str_split(strtolower(str_replace(" ", "", $param2)));

        sort($arr1);
        sort($arr2);

        $comp1 = implode($arr1);
        $comp2 = implode($arr2);

        $esAnagrama = false;
        if ($comp1 == $comp2) {
            $esAnagrama = true;
        }

        if ($esAnagrama) {
            echo "<span>$param1 & $param2</span><b> son </b> anagramas";
        } else {
            echo "<span>$param1 & $param2</span><b> NO son </b> anagramas";
        }

    } else {
        echo "<h3>Faltan parámetros. Asegúrate de pasar 'param1' y 'param2'.</h3>";
    }
    ?>
</body>
</html>