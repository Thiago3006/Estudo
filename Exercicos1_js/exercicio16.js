function operacao ( valor1, sinal, valor2) {
    switch(sinal){
        case '+':
            return valor1 + valor2            
        case '-':
            return valor1 - valor2
        case '*':
            return valor1 * valor2
        case '/':
            return(valor1 / valor2).toFixed(2)
        default:
            return'Operação Inválida'

    }
}

console.log(operacao(1, '+', 2))
console.log(operacao(2, '*', 5))
console.log(operacao(5, '/', 2))
console.log(operacao(15, '-', 20))
console.log(operacao(2, '**', 2))