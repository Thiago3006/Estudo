function objetoParaArray(objeto) {
    const resultado = []

    for (let chave in objeto)
        resultado.push([ chave, objeto[chave] ])
        
    return resultado
}

console.log(objetoParaArray({nome: "MAria", profissão: "Desenvolvedora de software"}))

function objetoParaArray(objeto) {
        const chaves = Object.keys(objeto)
        const resultado = chaves.map( chave => [chave, objeto[chave]])

        return resultado
}

console.log(objetoParaArray({nome: "Thiago", profissão: "DEV"}))

function objetoParaArray(objeto) {
    return Object.entries(objeto)
}

console.log(objetoParaArray({ nome: "Larissa", profissão: "Farmaceutica"}))