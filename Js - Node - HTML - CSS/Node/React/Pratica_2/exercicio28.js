function filtrarPorQuantidadeDeDigitos(numeros, quantidadeDesejada) {
    let resultado = []
    for ( numero of numeros) {
        const quantidadeDeDigitos = String(numero).length

        if (quantidadeDeDigitos === quantidadeDesejada)
            resultado.push(numero)
    
    }

    return resultado
}

console.log(filtrarPorQuantidadeDeDigitos([11, 23, 2, 5], 2))

function filtrarPorQuantidadeDeDigitos2(numeros, quantidadeDesejada) {
    return numeros.filter(numero => {
        const quantidadeDeDigitos = String(numero).length

        return quantidadeDeDigitos === quantidadeDesejada
    })
}

console.log(filtrarPorQuantidadeDeDigitos([13, 2, 234, 543],3))