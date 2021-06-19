function menorNumero(numeros) {
    let menor = numeros[0]

    for (let i in numeros)
    if (numeros[i] < menor)
    menor = numeros[i]

    return menor
}

console.log(menorNumero([10, -2, 3, 5]))

function menorNumero2(numeros) {
    return numeros.reduce((anterior, atual) => anterior < atual ? anterior : atual)
}

console.log(menorNumero2([1, 0, 3]))

function menorNumero3(numeros) {
    return  Math.min(...numeros)
}

console.log(menorNumero3([1, 5, 3]))