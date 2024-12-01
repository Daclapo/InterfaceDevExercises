<?php
if ($_SERVER['REQUEST_METHOD'] === 'POST' && isset($_POST['celdas'], $_POST['color'], $_POST['radio'])) {
    $celdas = $_POST['celdas'];
    $color = $_POST['color'];
    $radio = $_POST['radio'];
} else {
    $celdas = $color = $radio = null;
}
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Formulario y Grid</title>
    <style>
        body {
            margin: 20px;
        }
        .form-container {
            margin-bottom: 20px;
        }
        .grid-container {
            display: grid;
            grid-gap: 6px;
        }
        .grid-item {
            width: 35px;
            height: 35px;
            display: flex;
            justify-content: center;
            align-items: center;
            background-color: <?= isset($color) ? htmlspecialchars($color) : '#ccc' ?>;
            border-radius: <?= isset($radio) ? intval($radio) . 'px' : '0px' ?>;
            color: black;
            font-weight: bold;
        }
        button {
            font-size: 14px;
            cursor: pointer;
        }
    </style>
</head>
<body>
<?php if ($celdas && $color && $radio): ?>
    <!-- Interfaz del con las div -->
    <div>
        <pre><?php var_dump($_POST); ?></pre>
        <button onclick="window.location.href='';">Volver</button>
        <p>datos recibidos : celdas=<?= htmlspecialchars($celdas) ?>, color=<?= htmlspecialchars($color) ?>, radio=<?= htmlspecialchars($radio) ?></p>
        <div class="grid-container" style="grid-template-columns: <?= str_repeat('35px ', intval($celdas)) ?>;">
            <!-- Utilizamos un unico for para crear todas estas divs, y luego ya separaran las filas -->
            <?php for ($i = 1; $i <= intval($celdas) * intval($celdas); $i++): ?>
                <div class="grid-item"><?= $i ?></div>
            <?php endfor; ?>
        </div>
    </div>

<?php else: ?>
    <!-- Interfaz del formulario -->
    <div class="form-container">
        <pre><?php var_dump($_POST); ?></pre>
        <h2>Completa los datos y pulsa enviar</h2>
        <form method="post">
            <input type="text" name="celdas" placeholder="celdas ?" required><br><br>
            <input type="text" name="color" placeholder="color ?" required><br><br>
            <input type="text" name="radio" placeholder="radio ?" required><br><br>
            <button type="submit">enviar</button>
        </form>
    </div>
    
<?php endif; ?>
</body>
</html>
