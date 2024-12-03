<?php
if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $columnas = isset($_POST['columnas']) ? (int)$_POST['columnas'] : 0;
    $filas = isset($_POST['filas']) ? (int)$_POST['filas'] : 0;

    // Validar que se hayan proporcionado datos
    if (empty($columnas) || empty($filas)) {
        echo 'No hay datos';
        exit;
    }

    // Validar límites
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
        <div id="contenedorPrincipal">
            <textarea readonly style="width: 300px; height: 150px; resize: none; margin-bottom: 20px;">Texto bloqueado</textarea>
            <div id="contenedor" style="display: grid; grid-template-columns: repeat(<?php echo $columnas; ?>, auto); gap: 5px;">
                <?php
                // Generar los botones dinámicamente
                for ($i = 1; $i <= $filas; $i++) {
                    for ($j = 1; $j <= $columnas; $j++) {
                        echo '<button style="padding: 10px; border: none; color: #fff; background-color: #007BFF; cursor: pointer;">[' . $i . ',' . $j . ']</button>';
                    }
                }
                ?>
            </div>
        </div>
        <script>
            // Agregar eventos a los botones
            document.addEventListener('DOMContentLoaded', () => {
                const buttons = document.querySelectorAll('button');
                buttons.forEach(button => {
                    button.addEventListener('click', () => {
                        alert(`Button ${button.textContent} clicked`);
                    });
                    button.addEventListener('mouseover', () => {
                        button.style.backgroundColor = '#FF5722';
                    });
                    button.addEventListener('mouseout', () => {
                        button.style.backgroundColor = '#007BFF';
                    });
                });
            });
        </script>
    </body>
    </html>
    <?php
}
?>
