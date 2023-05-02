//Resolução 1
function receberPrimeiroEUltimoElemento(elementos) {
    const primeiroElemento = elementos.shift()
    const ultimoElemento = elementos.pop()

    return [primeiroElemento, ultimoElemento]
}

console.log(receberPrimeiroEUltimoElemento(["idiota", "Inteligente", "Seu burro"]))

//Resolução 2
function receberPrimeiroEUltimoElemento(elementos) {
    const indiceDoPrimeiroElemento = 0
    const indiceDoUltimoElemento = elementos.length -1 
    const primeiroElemento = elementos[indiceDoPrimeiroElemento]
    const ultimoElemento = elementos[indiceDoUltimoElemento]

    return [primeiroElemento, ultimoElemento]
}

console.log(receberPrimeiroEUltimoElemento(["Você é", "top", "um nada"]))

// Resolução 3
function receberPrimeiroEUltimoElemento([primeiroElemento, ...elementosRestantes]) {
    const ultimoElemento = elementosRestantes.pop()

    return[primeiroElemento, ultimoElemento]
}

console.log(receberPrimeiroEUltimoElemento(["você não faz ideia de quanto é", "bom", "burro"]))