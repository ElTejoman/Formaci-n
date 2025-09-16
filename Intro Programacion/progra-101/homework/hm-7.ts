
export function max(a: number, b: number, c: number) {
  if (a> b && c ) {
    return a;
  }  if (b> a && c ) {
    return b;
  } else {
    return c;
  }
}


let maxValue = max(15, 65, 8);
console.log( maxValue ); 

