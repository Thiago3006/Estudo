function calcularMedia(numeros) {
    const quantidadeDeNumeros = numeros.length
    let somaTotal = 0

    for(numero of numeros) {
        somaTotal += numero
    }
    return somaTotal / quantidadeDeNumeros
}

console.log(calcularMedia([50, 5]))

function calcularMedia2(numeros) {
    const quantidadeDeNumeros = numeros.length
    const somaTotal = numeros.reduce((numeroA, numeroB) => numeroA + numeroB)

    return somaTotal / quantidadeDeNumeros
}

console.log(calcularMedia2([10, 30]))
