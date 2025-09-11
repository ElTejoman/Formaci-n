export interface Person{
  name: string;
  age: number;
  isActive: boolean;
  address: {
    postalCode: string;
  }
}



let alejandro: Person = {
  name: 'Alejandro',
  age: 29,
  isActive: true,
  address: {
    postalCode: ""
  }
};

let katherinne: Person = {
  name: 'Katherinne',
  age: 33,
  isActive: false,
  address: {
    postalCode: ""
  }
};

let patricia: Person = {
  name: 'Patricia',
  age: 58,
  isActive: false,
  address: {
    postalCode: ""
  }
};

let people: Person [] = [alejandro, katherinne, patricia]


for (let i = 0; i < people.length; i++){
  let person = people[i];
  console.log(person.name + ' ' + person.age)
}