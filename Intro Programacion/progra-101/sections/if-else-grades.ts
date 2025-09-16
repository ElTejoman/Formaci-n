
/*
Realizar un programa que muestre la nota del alumno como :  A, B , C, D, F 
donde:

A >= 90
B >= 80
C >= 70
D >= 600
F < 60
*/

export let nota: number = 10;

if (nota >= 90) {
  console.log('Sacaste A!');
} else if (nota >= 80) {
  console.log('Sacaste B!');
} else if (nota >= 70) {
  console.log('Sacaste C!');
} else if (nota >= 60) {
  console.log('Sacaste D');
} else {
  console.log('Desaprobado!')
}