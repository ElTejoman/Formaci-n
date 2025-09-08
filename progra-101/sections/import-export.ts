//export function greet(name: string = 'Alberto') {
//  console.log('Hola !' ,name);
//}
//let firstName = 'Roberto'
//greet('Alejandro');



import { addTwoNumbers, subTwoNumbers,timesTwoNumbers, divTwoNumbers } from "../helpers/math-helpers";



let num1 = 50;
let num2 = 100

let total1: number = addTwoNumbers(num1, num2);
let total2: number = subTwoNumbers(num1, num2);
let total3: number = timesTwoNumbers(num1, num2);
let total4:number = divTwoNumbers(num1, num2);

console.log('add', total1 + 10);
console.log('substract', total2 + 10);
console.log('times', total3 + 10);
console.log('divide', total4 + 10);