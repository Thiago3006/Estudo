function jurosSimples(capitalInicial, juros, tempo){
    return capitalInicial + (capitalInicial * juros * tempo)
}

function jurosComposto(capitalInicial, juros, tempo){
    return capitalInicial * (1 + juros) ** tempo
}

console.log(jurosSimples(100,5/100,5))
console.log(jurosComposto(100, 5/100, 5).toFixed(2))