// C# heel statisch heel strict qua types
// int getal = 4;
// getal = "qq";

let x: number | string = 14;
x = bla();

if (typeof x === "number") {
  console.log(x);
}
console.log(x);

function bla(): string | number {
  return 12;
}

// x = {};
// x = [];
// x = () => {};

// let obj = {x: 24, y: 'hoi' };
// console.log(obj);
// delete obj.x;
// console.log(obj);
// console.log('obj x', obj.x);

// function test(p1, p2) {

// }
