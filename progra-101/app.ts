



function heroesThatStartsWith(nameList: string[]) {
  
  letter = letter.toUpperCase();
  let newNameList: string[] = [];

  for (let i = 0; nameList.length; i++){
    let name = nameList[i];

    if (name.startsWith(letter)) {
      newNameList.push(name)
    }
  }

  return newNameList
}



let heroes = ['Doom', 'Dr. Strange', 'Hulk', 'She Hulk', 'Spiderman', 'Captain Marvel'];
let herosWithLetterS = heroesThatStartsWith( heroes, 'S' );







console.log(herosWithLetterS); // She Hulk, Spiderman