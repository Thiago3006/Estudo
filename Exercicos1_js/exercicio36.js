let vetor = [ 1, 2, 3, 4, 5]

function multiplicaVetor(vetor, multiplicador) {
    let vetorResultado = []
    vetor.forEach(element => {
        vetorResultado.push(element * multiplicador)
    });

    return vetorResultado
}

console.log(multiplicaVetor(vetor, 3))