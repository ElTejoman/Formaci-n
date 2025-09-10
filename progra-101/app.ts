
let people: string[] = ['Alejandro', 'YuMei', 'Mikasa', 'Ruberto']; //Arreglo de string
let salaries : number[] = [15000, 2000 ,2500]
//let flowers: string[] = ['Rosa', 'Girasol', 'Lirio','Margarita', 'Tulipan'];

//for (let i = 0; i <= 5; i++){
  
//  if (flowers[i] === undefined) {
//    console.log('espacios vacios en el arreglo')
//  } else {
//    console.log(flowers[i]);
//  }
//}


for (let i = 0; i < people.length; i++){
  if (salaries[i] === undefined) {
    console.log(people[i] + " aún no tiene salario");
  } else {
    console.log(people[i] +' tiene un salario de '+ salaries[i]);
  }
}