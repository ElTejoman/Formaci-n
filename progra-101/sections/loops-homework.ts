
export let base: number = 10;
export let limit: number = 50;


for (let i = 0; i <= limit; i++) {

  let result = base * i;
  console.log(base + "x"+i+"=", result)
  }

let i = 1;

while (i <= limit) {
  console.log(base + "x" + i + "=", base * i);
  i++;
}

//let i = 1;
do {
  console.log(base + "x" + i + "=", base * i);
  i++;
} while (i <= limit)