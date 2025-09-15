let numbers = [1, 6, 8, 4, 2, 7, 10, 3, 5];

let maximo = numbers[0];
for (let i = 0; i <= numbers.length; i++){
  if (numbers[i] >  maximo) {
    maximo = numbers[i];
  }
}
console.log(maximo) ;
//console.log('El numero mayor es: ', numbers[i])