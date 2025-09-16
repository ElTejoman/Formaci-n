
export let person = {
  name: 'Melissa',
  age: 30,
  isActive: true,
  hobbies: ['soccer', 'baseball'],
  toString() {
    let objectString = this.name + ' ' + this.age + ' ' + this.hobbies;
    console.log( objectString )
  }
}

//console.log(person.name.toUpperCase());
//person.toString();


let car = {
  color: 'red',
  numDoors: 5,
  extraTire: 1,
  dashCam: true,
  airBag: true,
  babySeat: false,
  year: 2024,
  brand: 'Ford',
  model: 'Bronco',
}

let smartTv = {
  sizeInches: 80,
  year: 2022,
  brand: 'Samsung',
  color: 'Platinium',
  smartTv: true,
  type: 'Led'
}

let youtubeVideo = {
  totalTime: '3.24min',
  lenght: 3600, //tiempo, puede ser en min y poner 1.5
  short: false,
  monetization: true,
  likes: 45678,
  comments: ['buen video', 'desagradable!', 'suber mas contenido'],
  dislikes: 545
}


console.log(car);
console.log(smartTv);
console.log(youtubeVideo);