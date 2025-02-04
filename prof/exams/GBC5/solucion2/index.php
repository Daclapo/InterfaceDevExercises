<?php
function pinta($m,$n){ 
	if ($m=='' or $n==''){
		return "no hay datos";
	}
	if (intval($m)>7 or intval($n)>12){
		return "máximo 7 x 12";
	}

	$cadena="<div id='pp'>";
	$cadena.="<textarea id='caja'>BUSCA EVENTOS</textarea><br/>\n";
	$c=0;
	for($i=1;$i<=$n;$i++){
		for($j=1;$j<=$m;$j++){
			$c++;
			//$z=$i+$j; // suma de enteros 
			$id = "F$i C$j"; // reemplazo de variables
			$nombreBoton= "$c";
			$cadena.="\t\t<button id='$id'>$nombreBoton</button>\n";
		}
		$cadena.="\t\t<br/>\n";
	}
	$cadena.="</div>";
	return $cadena;
}
?>
<!DOCTYPE HTML>
<html>
<head>
	<title>app</title>
	<meta charset="UTF-8">
<script>
var color=['#ddd','#999','pink'];
function app(){
	var eles=document.getElementsByTagName('button');
	console.log(eles);
	for (let i = 0; i < eles.length; i++) {
		//const x1 = Math.floor(i/3);
		const x2 = i % 3;
		//console.log( 'div ',x1,x2 );
		eles[i].style.backgroundColor=color[i%3];
		eles[i].addEventListener('mouseover',sobre);
		eles[i].addEventListener('click',clk);
		eles[i].style.width='70px';
		eles[i].style.margin='0px 0px 4px 0px';
		eles[i].style.padding='4px';
	}
	var ele=document.getElementById('caja');
	ele.style.width='134px';
	ele.style.height='15px';
	ele.style.resize='none';
	ele.readOnly='true';
	ele.style.padding='4px';
	ele.style.margin='0px 0px 5px 0px';	
	var ele=document.getElementById('pp');
	ele.style.width='521px';
	ele.style.height='402px';
	ele.style.border='1px solid black';
	ele.style.backgroundColor='lightgreen';
	ele.style.margin='auto';
	ele.style.padding='4px';
}
function clk(){
	console.log('click',this.id);
	document.getElementById('caja').innerHTML='click '+this.id;
}
function sobre(){
	document.getElementById('caja').innerHTML='over '+this.innerHTML;
	// este codigo se podria meter en el evento de html pero generamos mas codigo
}			
window.onload=app;
</script> 
</head>
<body>
	<?php
		echo pinta($_REQUEST['columnas'],$_REQUEST['filas'],); 
	?>
</body>
</html>