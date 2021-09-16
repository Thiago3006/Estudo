const botao = document.querySelector('button');

botao.onclick = function escolha() {

    const sabor = document.querySelector('input').value;

    if ((sabor === 'chocolate') || (sabor === 'Chocolate')) {
        alert('Acertou mizeravi!');
    } if (sabor === '') {
        alert('Escreva algum sabor, vamos lá!')
    } else {
        alert('Não desista!\nSe quiser peça ajuda!');

    }

}




function ajudar() {
    alert('Agora está fácil!');
     window.location.href = "../html/image.html"    
        
}

function voltar(){  
    alert('voltando');    
        window.location.href="../html/index.html"
        
        
      }
   


   


