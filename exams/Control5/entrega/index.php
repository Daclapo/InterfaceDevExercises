<?php
if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $columnas = isset($_POST['columnas']) ? (int)$_POST['columnas'] : 0;
    $filas = isset($_POST['filas']) ? (int)$_POST['filas'] : 0;

    if (empty($columnas) || empty($filas)) {
        echo 'No hay datos';
        exit;
    }

    if ($columnas > 7 || $filas > 12) {
        echo 'Máximo 7 x 12';
        exit;
    }
    ?>
    <!DOCTYPE html>
    <html>
    <head>
        <title>Tablero Dinámico</title>
    </head>
    <body>
        <?php
        echo '<div id="contenedorPrincipal" ';
        echo 'style="text-align: center; margin-top: 20px;">';

        echo '<textarea id="status" readonly ';
        echo 'style="width: 300px; height: 150px; resize: none; margin-bottom: 20px;">Texto bloqueado</textarea>';

        echo '<div id="contenedor" ';
        echo 'style="display: grid; grid-template-columns: repeat(' . $columnas . ', auto); gap: 5px; margin: 0 auto;">';

        $indice = 1;
        for ($i = 1; $i <= $filas; $i++) {
            for ($j = 1; $j <= $columnas; $j++) {
                echo '<div class="botones" ';
                echo 'style="width: 50px; height: 50px; background-color: #007BFF; color: white; display: flex; align-items: center; justify-content: center; cursor: pointer;" ';
                echo 'data-fila="' . $i . '" data-columna="' . $j . '" data-indice="' . $indice . '">' . $indice . '</div>';
                $indice++;
            }
        }

        echo '</div>';
        echo '</div>';
        ?>
        <script>
            document.addEventListener('DOMContentLoaded', () => {
                const textarea = document.getElementById('status');
                const divs = document.querySelectorAll('#contenedor .botones');

                divs.forEach(div => {
                    const indice = div.getAttribute('data-indice');
                    const fila = div.getAttribute('data-fila');
                    const columna = div.getAttribute('data-columna');

                    div.addEventListener('mouseover', () => {
                        textarea.value = `over ${indice}`;
                    });

                    div.addEventListener('click', () => {
                        textarea.value = `cilc F${fila} C${columna}`;
                    });
                });
            });
        </script>
    </body>
    </html>
    <?php
}
?>
