function checarAnoBissexto(ano) {
    const divisivelPorQuatro = ano % 4 == 0
    const divisivelPorCem = ano % 100 == 0
    const divisivelPorQuatrocentos = ano % 400 == 0

    return(divisivelPorQuatro && divisivelPorCem) || divisivelPorQuatrocentos
}

console.log(checarAnoBissexto(2416))

function checarAnoBissexto2(ano) {
    return new Date( ano, 1, 29).getDate() === 29
}

console.log(checarAnoBissexto2(2420))