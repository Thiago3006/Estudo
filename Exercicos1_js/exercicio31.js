function contador(vetor) {
    let negativo
    for(let i = 0; i < vetor.length; i++) {
        if( negativo === undefined) {
            negativo = vetor[i]
        } else {
            if(vetor[i] < 0) {
                negativo++
            }
        }
    }
    return negativo
}

vetor = [0, 1, 5, -5, -7, 22, -153, -15]

console.log(contador(vetor),'\n')

console.log( 'Resposta do professor, mais uma vez código curto e claro.', '\n')

function contador2(vetor2) {
     let negativo2 = 0
     for(i = 0; i < vetor2.length; i++) {
         if(vetor2[i] < 0) {
             negativo2++
         }
     }
     return negativo2
}

vetor2 = [ 134, -155, -200, 12, 11, - 154]

console.log(contador2(vetor2))