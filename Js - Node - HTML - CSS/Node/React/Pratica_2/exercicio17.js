function somarNumeros(numeros) {
    const quantidadeDeNumeros = numeros.length

    return (quantidadeDeNumeros === 0) ? 0 : numeros[0] + somarNumeros(numeros.slice(1))
}

console.log(somarNumeros([1, 2, 3]))

function somarNumeros2(numeros) {
    let soma = 0
    numeros.forEach(numero => soma += numero)

    return soma
}

console.log(somarNumeros2([10, 5, 4]))

function somarNumeros3(numeros) {
    const soma = numeros.reduce( (acumulador, numeroAtual) => acumulador + numeroAtual, 0)

    return soma
}

console.log(somarNumeros3([15, 20, 1]))