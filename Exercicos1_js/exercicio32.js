function calculadora(vetor) {
    let soma = 0
    let qtd
    for (i = 0; i < vetor.length; i++) {
        soma = soma + vetor[i]
        if (qtd === undefined) {
            qtd = vetor[i]
        } else {
            if (qtd < vetor[i]) {
                qtd++
            }                        
        }
    }
        media = (soma / qtd).toFixed(2)
    return media
}

vetor = [ 1, 3, 5, 5]

console.log(calculadora(vetor),'\n')

console.log('Mais uma vez a resolução do professor se mostra superior e fácil de entender, um dia chego la "risos".','\n')

function calculadora2(vetor2) {
    let soma2 = 0
    for(i = 0; i < vetor2.length; i++) {
        soma2 += vetor2[i]
    }
    return (soma2/vetor2.length).toFixed(2)
}

vetor2 = [1, 2]

console.log(calculadora2(vetor2))