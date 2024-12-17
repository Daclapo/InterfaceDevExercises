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
            font-family: Arial, sans-serif;
            margin: 20px;
        }
        .form-container {
            margin-bottom: 20px;
        }
        .grid-container {
            display: grid;
        }
        .grid-item {
            width: 25px;
            height: 25px;
            display: flex;
            justify-content: center;
            align-items: center;
            color: black;
            font-weight: bold;
        }
        button {
            padding: 10px 20px;
            font-size: 16px;
            cursor: pointer;
        }
    </style>
</head>
<body>
<?php if ($celdas && $color && $radio): ?>
    <!-- Interfaz del grid -->
    <div>
        <pre><?php var_dump($_POST); ?></pre>
        <button onclick="window.location.href='';">Volver</button>
        <p>datos recibidos : celdas=<?= htmlspecialchars($celdas) ?>, color=<?= htmlspecialchars($color) ?>, radio=<?= htmlspecialchars($radio) ?></p>
        <div class="grid-container" style="grid-template-columns: repeat(<?= intval($celdas) ?>, 1fr);">
            <?php for ($i = 1; $i <= intval($celdas) * intval($celdas); $i++): ?>
                <div class="grid-item" style="background-color: <?= htmlspecialchars($color) ?>; border-radius: <?= intval($radio) ?>px;">
                    <?= $i ?>
                </div>
            <?php endfor; ?>
        </div>
    </div>
<?php else: ?>
    <!-- Interfaz del formulario -->
    <div class="form-container">
        <pre>array(0) { }</pre>
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
