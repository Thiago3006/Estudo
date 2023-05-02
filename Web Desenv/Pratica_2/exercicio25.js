function buscarPalavrasSemelhantes (inicio, palavras) {
    const  resultado = []

    for (let palavra of palavras )
        if (palavra.includes(inicio))
        resultado.push(palavra)

        return resultado
}

console.log(buscarPalavrasSemelhantes("ari", ["aristoteles", "arara"]))

function buscarPalavrasSemelhantes2(inicio, palavras) {
    return palavras.filter(palavra => palavra.includes(inicio))
}

console.log(buscarPalavrasSemelhantes("dis", ["Distrtito", "distorcido"]))