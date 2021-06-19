// resolução 1
function multiplicar(numeroA, numeroB) {
    let resultado = 0
    
    /* a otimização feita para diminuir a quantidade de chamadas recursiva pode ser realizada  aqui para diminuir a quantidade de loops */
    for( let i = 0; i < numeroB; i++)
    resultado += numeroA
    
    return resultado
}

console.log(multiplicar(5, 5))

// resolução 2
function multiplicar(numero, multiplicador){
    if ( numero  === 0 || multiplicador === 0) return 0

    return multiplicador === 1 ? numero : numero + multiplicar(numero, multiplicador - 1)
}

console.log(multiplicar(10, 2))

// Resolução 3
function multiplicar(numeroA, numeroB) {
    if(numeroA === 0 || numeroB === 0) return 0

    const maiorNumero = Math.max(numeroA, numeroB)
    const menorNumero = Math.min(numeroA, numeroB)

    function multiplicarRecursivamente(numero, multiplicador) {
        return (
            multiplicador === 1 ? numero: numero + multiplicarRecursivamente(numero, multiplicador - 1)
            )
    }
    //nessa versão, garantimos que o multiplicador será o menor número, portanto haverá o minímo de chamadas recursivas 
    return multiplicarRecursivamente(maiorNumero, menorNumero)
}

console.log(multiplicar(3, 4))