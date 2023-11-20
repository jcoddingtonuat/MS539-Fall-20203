function func1()
{
    alert("your first function");
}

function playAGame()
{
    var random1 = Math.ceil(Math.random() *10);
    var random2 = Math.ceil(Math.random() *10);

    //DO NOT DO THIS!!!!!
    //document.write(random1);
    document.getElementById("rand1").innerHTML = "1st random num = " + random1;
    document.getElementById("rand2").innerHTML = "1st random num = " + random2;

    var sum = random1+random2;
    if ((sum == 13) || (random1 !=6))
    {
        document.getElementById("result").innerHTML = "You are a Winner - you got 13 or no 6's!";
    }
    else if ((sum < 12)  && (random2 !=4))
    {
        document.getElementById("result").innerHTML = "LOW #s this time - and with a 4 in rand2";
    }
    else
    {
        document.getElementById("result").innerHTML = "Average - blah";
    }

}


function average(num1, num2)
{
    var result = (num1+num2)/2.0;
    document.getElementById("average").innerHTML = "Average of 2 nums is " +result;
}