<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <title>AJAX Scenarios</title>
    <script>
        function runScenario(scenario) {
            let xhr = new XMLHttpRequest();
            let url = 'server.php';
            let params = 'param1=value1&param2=value2';
            let async = true;
            let method = 'GET';
            let responseType = 'text';

            switch (scenario) {
                case 1:
                    method = 'GET';
                    url += '?' + params;
                    async = true;
                    responseType = 'document';
                    break;
                case 2:
                    method = 'POST';
                    async = true;
                    responseType = 'text';
                    break;
                case 3:
                    method = 'GET';
                    url += '?' + params;
                    async = false;
                    responseType = 'json';
                    break;
                case 4:
                    method = 'POST';
                    async = false;
                    responseType = 'document';
                    break;
                case 5:
                    method = 'GET';
                    async = true;
                    responseType = 'text';
                    break;
                case 6:
                    method = 'POST';
                    url += '?' + params;
                    async = true;
                    responseType = 'text';
                    break;
                case 7:
                    method = 'POST';
                    async = true;
                    responseType = 'text';
                    break;
                case 8:
                    method = 'POST';
                    async = true;
                    responseType = 'document';
                    break;
            }

            xhr.open(method, url, async);
            xhr.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded');
            xhr.responseType = responseType;

            xhr.onreadystatechange = function() {
                if (xhr.readyState === 4 && xhr.status === 200) {
                    document.getElementById('result').innerHTML = xhr.responseText;
                    console.log(xhr.response);
                }
            };

            if (method === 'POST') {
                xhr.send(params);
            } else {
                xhr.send();
            }
        }
    </script>
</head>
<body>
    <h1>AJAX Scenarios</h1>
    <button onclick="runScenario(1)">Escenario 1</button>
    <button onclick="runScenario(2)">Escenario 2</button>
    <button onclick="runScenario(3)">Escenario 3</button>
    <button onclick="runScenario(4)">Escenario 4</button>
    <button onclick="runScenario(5)">Escenario 5</button>
    <button onclick="runScenario(6)">Escenario 6</button>
    <button onclick="runScenario(7)">Escenario 7</button>
    <button onclick="runScenario(8)">Escenario 8</button>
    <div id="result"></div>
</body>
</html>