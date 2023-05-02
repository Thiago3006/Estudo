function fruta (nome) {
    switch (nome) {
        case "Maça":
            console.log("Não vendemos está fruta aqui!")
            break
        case "Kiwi":
            console.log("Estamos com escassez de kiwi.")
            break
        case "Melancia":
            console.log("Aqui está, são 3 reais o quilo")
            break
        default:
            console.log("ERRO NO CONSOLE!!")
    }
}

fruta("Maça")
fruta("Kiwi")
fruta("Melancia")