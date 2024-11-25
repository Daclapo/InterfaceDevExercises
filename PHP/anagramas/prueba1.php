<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Comparación de Strings</title>
</head>
<body>
    <?php
    if (isset($_REQUEST['param1']) && isset($_REQUEST['param2'])) {
        $param1 = $_REQUEST['param1'];
        $param2 = $_REQUEST['param2'];

        $arr1 str_split($param1);
        $arr2 str_split($param2);

        sort($arr1);
        sort($arr2);

        $esAnagrama = false;
        if ($arr1 == $arr2) {
            $esAnagrama = true;
        }

        if ($esAnagrama) {
            echo "SI";
        } else {
            echo "NO";
        }



    } else {
        echo "Faltan parámetros. Asegúrate de pasar 'param1' y 'param2'.";
    }
    ?>
</body>
</html>
