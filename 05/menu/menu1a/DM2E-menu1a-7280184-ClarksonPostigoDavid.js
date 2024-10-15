function getRandomInt(min, max) {
    return Math.floor(Math.random() * (max - min + 1)) + min;
}

function generarTextoAleatorio() {
    let texto = "";
    for (let i = 0; i < 80; i++) {
        let numeroAleatorio = getRandomInt(48, 57);
        texto += String.fromCharCode(numeroAleatorio);
    }
    return texto;
}

function crearCajas() {
    for (let i = 1; i <= 3; i++) { 
        var ele = document.createElement('div');
        document.body.appendChild(ele);
        ele.id = 'c' + i;
        ele.innerHTML = 'Caja ' + i;
        ele.style.backgroundColor = 'white';
        ele.style.border = '2px solid #000';
        ele.style.width = '100px';
        ele.style.height = '100px';
        ele.style.margin = '10px';
        ele.style.float = 'left';  
        ele.style.textAlign = 'center';
        ele.style.lineHeight = '100px';
        ele.style.cursor = 'pointer';
        ele.addEventListener('click', clickCaja);
    }

    var parrafo = document.createElement('p');
    parrafo.id = 'textoCaja';
    parrafo.style.clear = 'both'; 
    parrafo.style.position = 'left';
    document.body.appendChild(parrafo);
}

function clickCaja() {
    var textoAleatorio = generarTextoAleatorio(); 
    var parrafo = document.getElementById('textoCaja');  

    if (this.id === 'c1') {
        parrafo.innerHTML = 'Caja 1: ' + textoAleatorio;
    } else if (this.id === 'c2') {
        parrafo.innerHTML = 'Caja 2: ' + textoAleatorio;
    } else if (this.id === 'c3') {
        parrafo.innerHTML = 'Caja 3: ' + textoAleatorio;
    }
}

crearCajas();
window.onload = iniciar; 
