function despesasTotais(itens) {
    var total = 0

    for(let item of itens)
    total += item.preco

    return total
}

console.log(despesasTotais([
    {nome: "play4", categoria: "Eletronico", preco: 2000.00},
    {nome: "play5", categoria: "Eletronico", preco: 5000.00}
]))

function despesasTotais2(itens) {
    return itens
    .map(item => item.preco)
    .reduce((acumulador, valorAtual) => acumulador + valorAtual)
}

console.log(despesasTotais2([
    {nome: "notebook", categoria: "informatica", preco: 5000.00},
    {nome: "carro", categoria: "Automovel", preco: 12000.00}
]))

function despesasTotais3(itens) {
    return itens.reduce((acumulador, valorAtual) => acumulador + valorAtual.preco, 0)
}

console.log(despesasTotais3([
    {nome:"moto", categoria: "automovel", preco: 8000.00},
    {nome:"caminhão", categoria: "automovel", preco: 157000.00}
]))