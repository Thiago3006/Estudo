//Resolução 1
function cumprimentar(nome) {
    const saudacao = "Olá"
    return [ saudacao, nome].join (', ').concat("!")
}

console.log(cumprimentar("Thiago"))

// Resolução 2
function cumprimentar (nome) {
    const saudacao = "Olá"
    return "Olá ," + nome + "!"
}

console.log(cumprimentar("Larissa"))

// Resolução 3
function cumprimentar(nome) {
    return `Olá, ${nome}!`
}

console.log(cumprimentar("Pai"))