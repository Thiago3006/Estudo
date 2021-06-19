function filtrarNumeros(array) {
    const resultado = []
    for (let item of array)
    if(typeof item === "number")
    resultado.push(item)

    return resultado
}

console.log(filtrarNumeros(["Thiago", "13", 666, " foda-se"]))

function filtrarNumeros(array) {
    return array.filter(item => typeof item === "number")
}

console.log(filtrarNumeros(["thiago", 333, "24"]))
