<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Control6</title>
    <link rel="stylesheet" href="https://unpkg.com/leaflet@1.7.1/dist/leaflet.css" />
</head>
<body>
<script src="https://unpkg.com/leaflet@1.7.1/dist/leaflet.js"></script>

<script>
const container1 = document.createElement('div');
const container2 = document.createElement('div');

container1.style.width = "400px";
container1.style.height = "60px";
container1.style.border = "1px solid black";
container1.style.margin = "0 auto";
container1.style.display = "flex";
container1.style.justifyContent = "center";
container1.style.alignItems = "center";

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
container2.style.paddingTop = "20px";

const defaultText = document.createElement('div');
defaultText.textContent = "pulsa algún botón";
container2.appendChild(defaultText);

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

    button.addEventListener('click', () => {
        container2.innerHTML = "";
        container2.appendChild(defaultText);

        if (label === "imagen") {
            const img = document.createElement('img');
            img.src = "img.png";
            img.style.maxWidth = "100%";
            img.style.height = "auto";
            container2.appendChild(img);
        } else if (label === "texto") {
            defaultText.textContent = "soy un texto literal";
        } else if (label === "limpiar") {
            defaultText.textContent = "borrado, pulsa algún botón para continuar";
        } else if (label === "xml") {
            const mapDiv = document.createElement('div');
            mapDiv.style.width = "100%";
            mapDiv.style.height = "100%";
            mapDiv.id = "mapid";
            container2.appendChild(mapDiv);

            const map = L.map(mapDiv).setView([55.7558, 37.6173], 4);
            L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
                attribution: '&copy; OpenStreetMap contributors'
            }).addTo(map);

            const marker = L.marker([55.7558, 37.6173]).addTo(map);
            marker.bindPopup('<b>xml:zoom=4</b>').openPopup();
        } else if (label === "mapa") {
            const mapDiv = document.createElement('div');
            mapDiv.style.width = "100%";
            mapDiv.style.height = "100%";
            mapDiv.id = "mapid";
            container2.appendChild(mapDiv);

            const map = L.map(mapDiv).setView([-62.9784, -60.651], 10);
            L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
                attribution: '&copy; OpenStreetMap contributors'
            }).addTo(map);

            const marker = L.marker([-62.9784, -60.651]).addTo(map);
            marker.bindPopup('<b>Isla Decepción</b><br>Antártida<br>nivel de zoom = 10').openPopup();
        } else {
            defaultText.textContent = "pulsa algún botón";
        }
    });

    container1.appendChild(button);
});

document.body.appendChild(container1);
document.body.appendChild(container2);
</script>

</body>
</html>
