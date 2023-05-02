function triangulo(a, b, c) {
   if (a == b && b == c){
       return(' É um triângulo equilatero')
   }else if (a == b || a == c){
       return(' É um triângulo isóseles')
   }if ((a != b) && (a != c)) {
       return(' É um triângulo escaleno')
   }
}
//não esqueça que a função em alguns casos tem que ter um return   

console.log(triangulo(2, 2, 2))
console.log(triangulo(2, 2, 3))
console.log(triangulo(1, 2, 3))