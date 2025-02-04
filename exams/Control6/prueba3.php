<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Control6</title>
    <link rel="stylesheet" href="https://unpkg.com/leaflet@1.7.1/dist/leaflet.css">
</head>
<body>

<script src="https://unpkg.com/leaflet@1.7.1/dist/leaflet.js"></script>

<script>
const container1 = document.createElement('div');
const container2 = document.createElement('div');

// Estilos para el primer contenedor
container1.style.width = "400px";
container1.style.height = "60px";
container1.style.border = "1px solid black";
container1.style.margin = "0 auto";
container1.style.display = "flex";
container1.style.justifyContent = "center";
container1.style.alignItems = "center";

// Estilos para el segundo contenedor
container2.style.width = "400px";
container2.style.height = "400px";
container2.style.border = "1px solid black";
container2.style.margin = "10px auto 0";
container2.style.display = "flex";
container2.style.flexDirection = "column"; 
container2.style.justifyContent = "flex-start";
container2.style.alignItems = "center";
container2.style.fontSize = "24px";
container2.style.fontFamily = "Comic Sans MS, Comic Sans, cursive";
container2.style.textAlign = "center";

// Texto inicial
const defaultText = document.createElement('div');
defaultText.textContent = "pulsa algún botón";
container2.appendChild(defaultText);

// Botones para el primer contenedor
const buttons = ["imagen", "texto", "xml", "mapa", "limpiar"];

buttons.forEach(label => {
    const button = document.createElement('button');
    button.textContent = label;
    button.style.backgroundColor = "#f0f0f0";
    button.style.border = "1px solid #ccc";
    button.style.borderRadius = "1px";
    button.style.width = "70px";
    button.style.padding = "5px 10px";
    button.style.cursor = "pointer";
    button.style.margin = "0";

    // Evento para cada botón
    button.addEventListener('click', () => {
        // Limpiar el contenido del segundo contenedor
        while (container2.firstChild) {
            container2.removeChild(container2.firstChild);
        }

        if (label === "imagen") {
            const img = document.createElement('img');
            img.src = "img.png";
            img.style.maxWidth = "100%";
            img.style.height = "auto";
            container2.appendChild(img);
        } else if (label === "texto") {
            const textNode = document.createElement('div');
            textNode.textContent = "soy un texto literal";
            textNode.style.paddingTop = "20px";
            container2.appendChild(textNode);
        } else if (label === "limpiar") {
            const clearText = document.createElement('div');
            clearText.textContent = "borrado, pulsa algún botón para continuar";
            container2.appendChild(clearText);
        } else if (label === "xml") {
            // Crear el contenedor del mapa
            const mapContainer = document.createElement('div');
            mapContainer.style.width = "100%";
            mapContainer.style.height = "100%";
            container2.appendChild(mapContainer);

            // Inicializar el mapa
            const map = L.map(mapContainer, {
                center: [55.7558, 37.6173], // Moscú
                zoom: 4
            });

            // Añadir capa base
            L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
                attribution: '&copy; OpenStreetMap contributors'
            }).addTo(map);

            // Añadir marcador con popup
            const marker = L.marker([55.7558, 37.6173]).addTo(map);
            marker.bindPopup("xml:zoom=4").openPopup();
        } else {
            container2.appendChild(defaultText);
        }
    });

    container1.appendChild(button);
});

// Añadir los contenedores al body
document.body.appendChild(container1);
document.body.appendChild(container2);
</script>

</body>
</html>
