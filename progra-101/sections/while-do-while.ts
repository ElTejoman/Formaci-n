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