// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
let a2 = false;
let a4 = false;
let a6 = false;
let a8 = false;
let a10 = false;
let b2= false;
let b4 = false;
let b6 = false;
let b8 = false;
let b10 = false;
let c2 = false;
let c4 = false;
let c6 = false;
let c8 = false;
let c10 = false;
let d2 = false;
let d4 = false;
let d6 = false;
let d8 = false;
let d10 = false;
let e2 = false;
let e4 = false;
let e6 = false;
let e8 = false;
let e10 = false;
let f2 = false;
let f4 = false;
let f6 = false;
let f8 = false;
let f10 = false;

$(document).ready(function() {
    
    console.log("Hello there")
    console.log(a2);
    $(".cella2").click(function(e){
        a2 = true;
        console.log(a2);
        if (a2 === true){
            $(e.target).hide();
        }
        
    })
    if (a2 === true){
        $(e.target).hide();
    }
})