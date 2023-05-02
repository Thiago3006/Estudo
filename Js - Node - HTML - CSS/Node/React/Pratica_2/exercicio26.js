function  removerVogais(frase) {
    const vogais = ["a", "A", "e", "E", "i", "I", "o", "O", "u", "U"]

    vogais.forEach(vogal => frase = frase.replace(vogal, ''))

    return frase
}

console.log(removerVogais("Estica"))

function removerVogais2(frase) {
    return frase.replace(/[aeiou]/ig.compile, '')
}

console.log(removerVogais("Matrix"))