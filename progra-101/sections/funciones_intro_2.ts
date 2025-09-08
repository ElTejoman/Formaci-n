export function sumar(a: number, b: number) {
  return a + b;
}

let total: number = sumar(863, 5);

console.log(total)

function greet(name:string) {
  console.log("Hola " + name);
}

let firstName = 'Rafael'
greet(firstName);