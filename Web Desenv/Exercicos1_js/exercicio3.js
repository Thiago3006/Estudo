function potencia(a, b) {
    return (Math.pow(a, b))
}

console.log(potencia(3 , 3))

/* verificando a resposta do professor foi identifcado duas resposta -- segue as respostas consultada*/

function potencia(a,b) {
    // modelo antigo
    let resultado = Math.pow(a, b)

    // modelo novo
    resultado = a ** b

    return resultado
}

console.log(potencia(2, 3))