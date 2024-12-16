<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>AJAX Scenario Tester</title>
    <style>
        body { font-family: Arial, sans-serif; }
        .container { margin: 20px; }
        textarea { width: 100%; height: 150px; margin: 10px 0; }
        pre { background-color: #f4f4f4; padding: 10px; border: 1px solid #ccc; }
    </style>
</head>
<body>
    <div class="container">
        <h1>Probador de Solicitudes AJAX </h1>

        <form id="ajax-form">
            <label>
                Método HTTP:
                <select id="http-method">
                    <option value="GET">GET</option>
                    <option value="POST">POST</option>
                </select>
            </label>
            <br>
            <label>
                Ubicacion del Paŕámetro:
                <select id="param-location">
                    <option value="url">URL</option>
                    <option value="request">Request Body</option>
                    <option value="both">Both</option>
                </select>
            </label>
            <br>
            <label>
                Es Asincrono:
                <input type="checkbox" id="is-async" checked>
            </label>
            <br>
            <label>
                Tipo de Dato:
                <select id="data-type">
                    <option value="html">HTML</option>
                    <option value="text">Text</option>
                    <option value="json">JSON</option>
                    <option value="xmltext">XML (Texto)</option>
                    <option value="xmldata">XML (Data)</option>
                </select>
            </label>
            <br>
            <br>
            <button type="button" onclick="sendAjaxRequest()">Enviar Solicitud</button>
        </form>

        <br>
        <h2>Previsualizacion de la Solicitud:</h2>
        <pre id="request-preview"></pre>

        <br>
        <h2>Respuesta:</h2>
        <pre id="response-display"></pre>

        <br>
        <h2>Traza:</h2>
        <textarea id="console-trace" readonly></textarea>
    </div>

    <script>
        function sendAjaxRequest() {
            const method = document.getElementById('http-method').value;
            const paramLocation = document.getElementById('param-location').value;
            const isAsync = document.getElementById('is-async').checked;
            const dataType = document.getElementById('data-type').value;

            const url = 'ajax_handler.php';
            let params = "name=John&age=30";

            let fullUrl = url;
            if (paramLocation === 'url' || paramLocation === 'both') {
                fullUrl += `?${params}`;
            }

            const xhr = new XMLHttpRequest();

            xhr.open(method, fullUrl, isAsync);

            if (paramLocation === 'request' || paramLocation === 'both') {
                xhr.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded');
            }

            xhr.onreadystatechange = function () {
                if (xhr.readyState === 4) {
                    document.getElementById('response-display').textContent = xhr.responseText;
                    document.getElementById('console-trace').value += `\nResponse Received:\nStatus: ${xhr.status}\nResponse: ${xhr.responseText}`;
                }
            };

            xhr.send(paramLocation === 'request' || paramLocation === 'both' ? params : null);

            document.getElementById('request-preview').textContent = `Method: ${method}\nURL: ${fullUrl}\nAsync: ${isAsync}\nData Type: ${dataType}\nParams: ${paramLocation === 'request' ? params : 'None'}`;
            document.getElementById('console-trace').value += `\nRequest Sent:\nMethod: ${method}\nURL: ${fullUrl}\nAsync: ${isAsync}\nData Type: ${dataType}\nParams: ${params}`;
        }
    </script>
    <span>
    <br><br>
    ¿Se pueden enviar los parámetros en REQUEST en un GET? <br>
    No. En un GET los parámetros siempre van en la URL.<br><br>
 
    ¿Se pueden enviar los parámetros en URL en un POST?<br>
    Sí. Se pueden incluir parámetros en la URL. <br><br>
 
    ¿Se puede enviar datos XML como TEXTO?<br>
    Sí. Se puede enviar una cadena de texto con formato XML. <br><br>
 
    ¿Cómo recibo XML en JS?<br>
    Cuando servidor responde con XML, se puede parsear utiizando responseXML o un DOMParser para manipularlo como un documento XML. <br><br>
    </span>
</body>
</html>



