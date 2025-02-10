let x = 10
let y = 20

let swap x y = 
    let temp = x
    x, y <- y, temp //Correct way to swap

let (x1, y1) = swap x y
printf "%d %d" x1 y1 //this will print 20 10

//Another solution
let swap2 x y = (y,x) 
let (x2, y2) = swap2 x y
printf "%d %d" x2 y2 // this will also print 20 10

//avoid mutable variables when possible for clarity and preventing subtle bugs
