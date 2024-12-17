<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>PHP + JS Layout</title>
</head>
<body>

<script>
// Crear los contenedores
const container1 = document.createElement('div');
const container2 = document.createElement('div');

// Aplicar estilos a los contenedores
container1.style.width = "400px";
container1.style.height = "60px";
container1.style.border = "1px solid black";
container1.style.margin = "0 auto";
container1.style.display = "flex";
container1.style.justifyContent = "flex-start"; // Cambiar alineación para que los botones se toquen
container1.style.alignItems = "center";

container2.style.width = "400px";
container2.style.height = "400px"; // Puedes ajustar esta altura según sea necesario
container2.style.border = "1px solid black";
container2.style.margin = "10px auto 0";
container2.style.display = "flex";
container2.style.justifyContent = "center";
container2.style.alignItems = "center";
container2.style.fontSize = "24px";
container2.style.textAlign = "center";
container2.textContent = "pulsa algún botón";

// Crear botones para el primer contenedor
const buttons = ["imagen", "texto", "xml", "mapa", "limpiar"];

buttons.forEach(label => {
    const button = document.createElement('button');
    button.textContent = label;
    button.style.backgroundColor = "#f0f0f0";
    button.style.border = "1px solid #ccc";
    button.style.borderRadius = "4px";
    button.style.padding = "5px 10px";
    button.style.cursor = "pointer";
    button.style.margin = "0"; // Eliminar separación horizontal

    // Añadir evento para cada botón
    button.addEventListener('click', () => {
        if (label === "imagen") {
            container2.innerHTML = "";
            const img = document.createElement('img');
            img.src = "img.png";
            img.style.maxWidth = "100%";
            img.style.height = "auto";
            container2.appendChild(img);
        } else if (label === "texto") {
            container2.textContent = "soy un texto literal";
        } else if (label === "limpiar") {
            container2.textContent = "borrado, pulsa algún botón para continuar";
        }
    });

    // Añadir el botón al contenedor1
    container1.appendChild(button);
});

// Añadir los contenedores al body
document.body.appendChild(container1);
document.body.appendChild(container2);
</script>

</body>
</html>
