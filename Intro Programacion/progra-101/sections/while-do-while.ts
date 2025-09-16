/*

let gasTank: number = -2;

//while (true) {
  //ciclo infinito
//}

while (gasTank >= 0) {
  console.log('Gasolina restante', gasTank);

  gasTank--;
}

console.log('Ya no tiene gasolina');
*/

//Ciclo Do While

export let gasTank: number = 50;


do {
  console.log('Gasolina restante', gasTank);

  gasTank--;
} while (gasTank >= 0)

console.log('Ya no tiene gasolina');




//export let base: number = 10; //obligatoria
//export let limit: number = 50; //defecto 10
//let i = 1;

//while (i <= limit) {
//  console.log(base + "x" + i + "=", base * i);
//  i++;
//}

//let i = 1;
//do {
//  console.log(base + "x" + i + "=", base * i);
//  i++;
//} while (i <= limit)