export function printMultiplicationTable(
  base: number,
  limit: number = 10) {

  for (let i = 1; i <= limit; i++) {
    
    console.log(base + "x" + i + "=" + base * i) ;
    }
    
}

