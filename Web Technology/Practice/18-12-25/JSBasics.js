// 1. find the greatest of 3 numbers
var a = 10;
var b = 25;
var c = 15;

var greatest;

if (a >= b && a >= c) {
    greatest = a;
} else if (b >= a && b >= c) {
    greatest = b;
} else {
    greatest = c;
}

document.write("1. Greatest of 3 numbers: " + greatest + "<br><br>");


// 2.  find Simple Interest
 var principal = 1000;
var rate = 5;
var time = 2;

var simpleInterest = (principal * rate * time) / 100;

document.write("2. Simple Interest: " + simpleInterest + "<br><br>");


// 3. Difference between a given number and 13
var num = 20;
var diff;

if (num > 13) {
    diff = (num - 13) * 2;
} else {
    diff = 13 - num;
}

document.write("3. Result of difference calculation: " + diff + "<br><br>");


// 4. for loop to check odd or even from 0 to 15
document.write("4. Odd or Even from 0 to 15:<br>");

for (var i = 0; i <= 15; i++) {
    if (i % 2 === 0) {
        document.write(i + " is Even<br>");
    } else {
        document.write(i + " is Odd<br>");
    }
}
