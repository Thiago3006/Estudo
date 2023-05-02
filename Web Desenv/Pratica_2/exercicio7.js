// resolução 1
function estaEntre(minimo, maximo, numero, inclusivo = false) {
    if(inclusivo) return numero >= minimo && numero <= maximo
    
    return numero > minimo && numero < maximo
}
 console.log(estaEntre(10, 100, 5))

 // resolução 2
 function estaEntre(minimo, maximo, numero, inclusivo = false) {
     return inclusivo ? numero >= minimo && numero <= maximo : numero > minimo && numero < maximo
 }

 console.log(estaEntre(50, 100, 11))