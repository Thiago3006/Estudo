function anuidade(valor, mes){
    if (mes == 1){
        return `O valor a ser pago é ${valor.toFixed(2)}.`
    } else if ( mes == 2) {
        valor = (valor * (1 + 5/100)** 1).toFixed(2)
        return `O valor a ser pago é ${valor}.`
    } else if ( mes == 3) {
        valor = (valor * (1 + 5/100)** 2).toFixed(2)
        return `O valor a ser pago é ${valor}.`
    } else if ( mes == 4) {
        valor = (valor * (1 + 5/100)** 3).toFixed(2)
        return `O valor a ser pago é ${valor}.`
    }
    // parei no mes 4 uma vez que verifiquei a resposta do professor e tive uma resposta completa com uma grande subtração de linhas .      
    
}

console.log(anuidade(200, 1))
console.log(anuidade(100, 2))
console.log(anuidade(200, 3))
console.log(anuidade(100, 4),('\n'))

console.log('verificando a resposdo do professor, obtive um código menor.')
// verificando a resposta do professor obtive um código menor.

function calculadora(mes1, valor1) {
    if (mes1 >0 && mes1 < 13){
        atraso = mes1 - 1
        return 'O valor a ser pago é '+(valor1 *(1 + 5/100)**atraso).toFixed(2)
    }
}

console.log(calculadora(2, 100))
console.log(calculadora(5, 200))
console.log(calculadora(9, 250))