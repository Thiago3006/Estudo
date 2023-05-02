// Resolução 1
function repetir(item, quantidade) {
    let resultado =  []
    for (let i = 0; i < quantidade ; i++)
    resultado.push(item)
    
    return resultado
}

console.log(repetir(8, 3))

//Resolução 2
function repetir(item, quantidade) {
    return Array(quantidade).fill(item)
}

console.log(repetir(5, 10))