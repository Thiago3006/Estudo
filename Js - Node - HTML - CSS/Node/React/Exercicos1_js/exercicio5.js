function formatarValor(valor) {
    valorEmReais = `R$ ${valor.toFixed(2)}`
    console.log(valorEmReais)
}

formatarValor(0.1 + 0.2)

function decimal(valor2) {
    format = valor2.toFixed(2)
    console.log(format)
       
}
decimal(0.1 + 0.2)


/*function formatarValorDecimal(valorDecimal) {
    valorEmReais = `R$ ${valorDecimal.toFixed(2).toString().replace(".", ",")}`
    console.log(valorEmReais)
}

formatarValorDecimal(0.1 + 0.2) */