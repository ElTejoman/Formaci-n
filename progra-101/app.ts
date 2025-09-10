
let people: string[] = ['Alejandro', 'YuMei', 'Mikasa']; //Arreglo de string
let flowers: string[] = ['Rosa', 'Girasol', 'Lirio'];

for (let i = 0; i <= 5; i++){
  
  if (flowers[i] === undefined) {
    console.log('espacios vacios en el arreglo')
  } else {
    console.log(flowers[i]);
  }
}
