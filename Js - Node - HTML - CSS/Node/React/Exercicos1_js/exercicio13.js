function semana(dia) {
    switch (dia) {
        case 1:
            console.log("Fim de semana")
            break
        case 2: case 3 : case 4: case 5: case 6:
            console.log("Dia util") 
            break
        case 7:
            console.log("Fim de semana")
            break
        default:
            console.log("Dia inválido")
    }   

}

semana(5)
semana(7)
semana(9)
semana(3)