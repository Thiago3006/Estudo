function maiorMenor(vetor) {
    let maior
    let menor 
    for(let i = 0; i < vetor.length; i++) {
        if(maior === undefined && menor === undefined) {
            maior = vetor[i]
            menor = vetor[i]
        }else {
            if(vetor[i] > maior) {
                maior = vetor[i]
            }
            if(vetor[i] < menor) {
                menor = vetor[i]
            }
        }
    }
    return[maior, menor]
}

vetor = [ 2, 3, 5, 67, 1, 22, 153, 0]

console.log(maiorMenor(vetor))