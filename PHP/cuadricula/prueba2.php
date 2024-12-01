<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Cuadricula Pick Color</title>
    <style>
        .color-grid {
            display: flex;
            flex-wrap: wrap;
            width: 512px;
            height: 512px;
        }
        .color-cell {
            width: 2px;
            height: 2px;
        }
        .color-cell:hover::after {
            content: attr(data-rgb);
            position: absolute;
            background: #000;
            color: #fff;
            padding: 2px;
            font-size: 10px;
            z-index: 10;
        }
    </style>
</head>
<body>
    <div class="color-grid">
        <?php
            function generateColorGrid() {
                $width = 256;
                $height = 256;
                $r = 255;
                $g = 255;
                $b = 255;

                for ($y = 0; $y < $height; $y++) {
                    for ($x = 0; $x < $width; $x++) {
                        $currentColor = "rgb($r, $g, $b)";

                        echo "<div class='color-cell' style='background-color: $currentColor' data-rgb='$currentColor'></div>";

                        // Se define el canal rojo decremental para cada columna (hacia la derecha) en la cuadricula
                        $r = max(0, $r - 1);
                    }

                    // Se define el canal verde decremental cada fila (hacia abajo) en la cuadricula
                    $g = max(0, $g - 1);

                    // Se define el canal azul decremental para cada fila impar (hacia abajo) en la cuadricula
                    if ($y % 2 == 1) {
                        $b = max(0, $b - 1);
                    }

                    // Reinicio del canal rojo.
                    $r = 255;
                }
            }
            generateColorGrid();
        ?>
    </div>
</body>
</html>
