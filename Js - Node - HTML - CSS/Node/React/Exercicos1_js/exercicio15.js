function veiculo(modelo) {
    switch (modelo) {
        case 'Moto':
            console.log('Tem certeza que não prefere este modelo?')
            break
        case 'Sedan':
            console.log('Tem certeza que não deseja este modelo?')
            break
        case 'Hatch':
            console.log('Compra efetuada com sucesso!')
            break
        case 'Caminhonete':
            console.log('Tem certeza que não deseja este modelo?')
            break
            default:
                console.log('Não trabalhamos com este tipo de automóvel')
    }
}

veiculo('Sedan')
veiculo('Conversivel')
veiculo('Caminhonete')
veiculo('Hatch')


// modelo do professor

/*function escolherCarro (modelo) {
    switch (modelo) {
        case 'hatch':
            return 'Compra efetuada com sucesso.'
        case 'sedan':
        case 'motocicleta':
        case 'caminhonete':
            return 'Tem certeza que não prefere este modelo?'
        default:
            return 'Não trabalhamos com este tipo de automóvel aqui.'
    }
}

console.log(escolherCarro('hatch'));
console.log(escolherCarro('motocicleta'));
console.log(escolherCarro('sedan'));
console.log(escolherCarro('caminhonete'));
console.log(escolherCarro('jetski'));
*/
