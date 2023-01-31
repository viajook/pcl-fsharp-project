// Introduction to F# programming
// ==============================

// A function to add 2 to a number
let square x = x * x

// This function uses the square function 
// to build a more complex function
let sumSqr(x,y) = square x + square y

