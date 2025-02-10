let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //this will print 20 20, as expected

let tupleSwap (x,y) = (y,x)

let a = 10
let b = 20

let (c,d) = tupleSwap (a,b) // this is fine

printf "%d %d" c d // this will print 20 10

let mutable x1 = 10
let mutable y1 = 20

let tupleSwapMutable (x,y) = 
    (x<-y; y<-x)

let (x2, y2) = tupleSwapMutable (x1, y1) // this will give a warning, but will print 20 20
printf "%d %d" x2 y2

//This is an example of a subtle error that's easy to miss. When using mutable variables and tuples, make sure you understand how the values are being passed around. In this case, the mutable variables are being passed by reference into the tupleSwapMutable function, and the assignments are taking place within the function. This means that the mutable variables are being modified in place, and the result is not what you might expect.
//This is a subtle bug that's often missed when working with mutable variables and tuples in F#. The mutable variables are passed by reference, so modifying them within the tupleSwapMutable function modifies them outside of the function as well.  This means that the values of x1 and y1 are also changed when tupleSwapMutable is called.
