function convenio(idade){
    if ( idade < 10){
        return 'O valor a ser pago é R$180.'
    }
    if((idade > 10) && (idade < 30)){
        return 'O valor a ser pago é R$150.'
    }
    if((idade > 30) && (idade < 60)) {
        return 'O valor a ser pago é R$195.'
    }
    if(idade > 60){
        return 'O valor a ser pago é R$230.'
    }
}   

console.log(convenio(45))
console.log(convenio(5))
console.log(convenio(22))
console.log(convenio(75),('\n'))


// modelo do professor

function calcularPreco(idade1) {
    if (idade1 < 10) {
        return 180
    } else if (idade1 < 30) {
        return 150
    } else if ( idade1 < 60) {
        return 195
    }else {
        return 230
    }
}

console.log(calcularPreco(9))
console.log(calcularPreco(22))
console.log(calcularPreco(48))
console.log(calcularPreco(75))