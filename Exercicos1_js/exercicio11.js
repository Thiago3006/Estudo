function bissexto(ano) {
    if (ano <= 0) {
        return false
    }else if (ano % 400 == 0) {
        return true
    }else if (ano % 100 == 0) {
        return false
    }else if (ano % 4 == 0){
        return true
    }else {
        return false
    }
}

console.log(bissexto(2011))
console.log(bissexto(2018))
console.log(bissexto(2024))