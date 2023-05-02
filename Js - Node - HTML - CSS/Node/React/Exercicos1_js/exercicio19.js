function cardapio(codigo, qtd){
    switch(codigo){
        case 100:
            let valor1 = 3.00
            return `Seu pediu, ${qtd}x Cachorro Quente. O total a pagar é R$${(valor1 * qtd).toFixed(2)}`
        case 200:
            let valor2 = 4.00
            return `Seu pediu, ${qtd}x Hambúrguer Simples. O total a pagar é R$${(valor2 * qtd).toFixed(2)}`
        case 300:
            let valor3 = 5.50
            return `Seu pediu, ${qtd}x Cheeseburguer. O total a pagar é R$${(valor3 * qtd).toFixed(2)}`
        case 400:
            let valor4 = 7.50
            return `Seu pedido, ${qtd}x Bauru. O total a pagar é R$${(valor4 * qtd).toFixed(2)}`
        case 500:
            let valor5 = 3.50
            return `Seu pedido, ${qtd}x Refrigerante. O total a pagar é R$${(valor5 * qtd).toFixed(2)}`
        case 600:
            let valor6 = 2.80
            return `Seu pedido, ${qtd}x Suco. O total a pagar é R$${(valor6 * qtd).toFixed(2)}`
        default:
            return 'Este produto não existe'
    }   
    
}

console.log(cardapio(100, 3))
console.log(cardapio(200, 2))
console.log(cardapio(300, 4))
console.log(cardapio(400, 8))
console.log(cardapio(500, 2))
console.log(cardapio(600, 1))
console.log(cardapio(700, 3))