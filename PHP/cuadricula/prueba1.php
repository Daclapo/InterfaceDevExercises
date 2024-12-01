<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Pick Color</title>
    <style>
        .color-box {
            width: 2px;
            height: 2px;
            float: left;
        }
        .container {
            width: 512px;
            height: 512px;
            overflow: hidden;
            position: relative;
        }
        .color-box:hover::after {
            content: attr(data-rgb);
            position: absolute;
            background: #fff;
            border: 1px solid #000;
            padding: 2px;
            font-size: 10px;
        }
    </style>
</head>
<body>
    <div class="container">
        <?php
        function drawColorGrid() {
            $r = 255;
            $g = 255;
            $b = 255;
            for ($y = 0; $y < 256; $y++) {
                for ($x = 0; $x < 256; $x++) {
                    $color = sprintf("#%02x%02x%02x", $r, $g, $b);
                    $rgb = "rgb($r, $g, $b)";
                    echo "<div class='color-box' style='background-color: $color;' data-rgb='$rgb'></div>";
                    $r = max(0, $r - 1);
                    $b = max(0, $b - 1);
                }
                $g = max(0, $g - 1);
            }
        }

        drawColorGrid();
        ?>
    </div>
</body>
</html>
