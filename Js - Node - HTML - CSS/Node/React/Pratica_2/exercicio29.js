function segundoMaior(numeros) {
    let indiceDoMaior = 0
    let segundoMaior

    numeros.forEach( (numero, indice) => {
        if( numero > numeros[indiceDoMaior])
        indiceDoMaior = indice
    })

    numeros.splice(indiceDoMaior, 1)
    segundoMaior = numeros[0]

    numeros.forEach(numero => {
        if(numero > segundoMaior)
        segundoMaior = numero
    })

    return segundoMaior
}

console.log(segundoMaior([12, 22, 15, 1]))

function segundoMaior2(numeros) {
    const maiorNumero = Math.max(...numeros)
    numeros = numeros.filter(numero => numero != maiorNumero)
    const segundoMaior2 = Math.max(...numeros)

    return segundoMaior2
}

console.log(segundoMaior2([2, 3, 5]))

function segundoMaior3(numeros) {
    const numerosOrdenados = numeros.sort((numeroA, numeroB) => numeroB - numeroA)
    const segundoMaior3 = numerosOrdenados[1]

    return segundoMaior3
}

console.log(segundoMaior3([1, 4, 2, 3]))