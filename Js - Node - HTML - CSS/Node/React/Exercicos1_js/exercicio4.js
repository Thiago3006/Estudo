function divisor(a, b) {
    console.log(` A divisão entre ${a} e ${b} é`,a / b,'\n',`O resto da divisão entre ${a} e ${b} é`, a % b)
}

divisor(4,2)

/* verificando a resposta do professor, abaixo vou colocar seu código, realmente está mais limpo e facil de ler e modificar se for preciso */

function divisor2(a,b) {
    console.log("Resultado: "+ Math.floor(a / b));
    console.log(`Resto: ${a % b}`)
}

divisor2(5,2)