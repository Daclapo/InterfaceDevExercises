
var nombre = "David Clarkson";
var altura = 190;

var concatenacion = nombre + " " + altura;



if(altura >= 190){
    datos.innerHTML = `<h1>Eres una persona ALTA</h1>`
}else{
    datos.innerHTML = `<h1>Eres una persona BAJA</h1>`
}

for(var i = 2000; i<2020; i++){
 
    datos.innerHTML += "<h2>Estamos en el año:"+i;
}

// Mostrar mi nombre
function MuestraMiNombre(nombre, altura){
    var misDatos = `
        <h1>Soy la caja de datos</h1>
        <h2>Mi nombre es: ${nombre}</h2>
        <h3>Mido: ${altura}</h3>
    `;
    return misDatos;
}
MuestraMiNombre("David Clarkson", 213);


function imprimir(){
    var datos = document.getElementById("datos");
    datos.innerHTML = MuestraMiNombre();
}

imprimir();

var nombres = ['David', 'Paco', 'Rigoberto'];

document.write('<h1>Listado de nombres</h1>');
/*
for(i = 0; i < nombres.length; i++){
    document.write(nombres[i] + '<br/>');
}
*/
nombres.forEach((nombre) => {
    document.write(nombre + '<br/>')
});



// Función para generar un número aleatorio entre un mínimo y un máximo, sin decimales
function getRandomInt(min, max) {
    return Math.floor(Math.random() * (max - min + 1)) + min;
}
// 7280184
function generarValores() {
    for (let i = 0; i < 10; i++) {
        let alto = getRandomInt(1, 10);
        let ancho = getRandomInt(1, 10);
        let fondo = getRandomInt(1, 10);

        let superficie = alto * ancho;
        let volumen = alto * ancho * fondo;

        let volumenEnPies = Math.floor(volumen * 35.3147);

        // Escribe directamente en el documento con document.write()
        document.write(`alto=${alto} ancho=${ancho} fondo=${fondo} superficie=${superficie} volumen=${volumen} volumen en pies=${volumenEnPies}<br>`);
    }
}
generarValores();









// Función para generar y mostrar las 10 líneas con los cálculos
/* function generarValores() {
    let resultado = '';
    for (let i = 0; i < 10; i++) {
        let alto = getRandomInt(1, 10);
        let ancho = getRandomInt(1, 10);
        let fondo = getRandomInt(1, 10);

        let superficie = alto * ancho;
        let volumen = alto * ancho * fondo;

        let volumenEnPies = Math.floor(volumen * 35.315);

        resultado += `alto=${alto} ancho=${ancho} fondo=${fondo} superficie=${superficie} volumen=${volumen} volumen en pies=${volumenEnPies}<br>`;
    }
    document.body.innerHTML = resultado;
}
generarValores();
*/
