function salario(plano) {
    let valor = 1500
    switch(plano){
        case 'A': case 'a':
            return valor + (10/100 * valor)
        case 'B': case'b':
            return valor + (20/100 * valor)
        case 'C': case'c':
            return valor + (30/100 * valor)
        default:
            return 'Plano inválido'
    
    }
}

console.log(salario('A'))
console.log(salario('B'))
console.log(salario('c'))
console.log(salario('f'),("\n"))

console.log("Segundo teste para execução do exercício","\n")



function salario1(plano1, valor1){
    switch(plano1){
        case 'A': case'a':
            return valor1 + (10/100 * valor1)
        case 'B': case 'b':
            return valor1 + (20/100 * valor1)
        case 'C': case 'c':
            return valor1 + (30/100 * valor1)
        default:
            return 'Plano inválido'
    }
    
}

console.log(salario1('A', 1500))
console.log(salario1('b', 1000))
console.log(salario1('c', 1800))