function contarCaractere(caractereBuscado, frase) {
    let contador = 0

    for (let i = 0; i < frase.length; i++)
    if (frase.charAt(i)=== caractereBuscado)
        contador ++
    
        return contador
}

console.log(contarCaractere("a", "a maça"))

function contarCaractere2(caractereBuscado, frase) {
    return [...frase].filter(caractere => caractere === caractereBuscado).length
}

console.log(contarCaractere2("r", "rapadura raspada"))