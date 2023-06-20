# Hello World Refuctoring

Welcome to the Mortgage Driven Development challenge.  

In this challenge, you'll be tasked with taking a clean, simple piece of code, and turning it into a complicated mess which only you can understand. 
Feel free to use any techniques you want in order to achieve this. 

## How to Play:

```
10 Fork this repo into your own personal space.  
20 At the start of the challenge you have 10 minutes to refuctor the Helloworld challenge in any way possible.   
30 At the end of the 10 minutes, confirm the say_hello_world test still passes. If this does not pass, you will be deemed to have failed and docked the relevant amount.   
40 If the test passes, commit your code.   
50 Move to the laptop to the left of you.   
60 You have 5 minutes to make a change on this solution.   
70 At the end of the 5 minutes, confirm the say_hello_world test still passes. If this does not pass, you will be deemed to have failed and docked the relevant amount.   
80 If the test passes, commit your code. If the test fails, revert to the last commit.   
90 GOTO 50  
RUN  
```

## Rules

1. Everyone starts with 10MDD! 1MDD is relevant to keeping your mortgage paid for a month.
2. You can use anything within your control to refuctor the code base.
3. The Expected Assert within [HelloWorldTests.cs](HelloWorld.Tests/HelloWorldTests.cs) test must not be changed. The test can only be changed to accomodate your implementation and must still pass.
4. If you hit 0MDD (or below) you may continue as you could make money back, but you'll never make it as a mercenary. 

## £$€₼¥₱₦ 

```
int MDD = 10
string initialCode;
string iChangedCodeLast;
bool iBrokeIt;

switch(refuctoring)
{
    case: (iBrokeIt = true && initalCode = `Line 30`)
        \\ Failing test on the intial code base when time runs out
        MDD = MDD - 10;
        break;
    case: (iBrokeIt = true && iChangedCodeLast = `Line 70`)
        \\ Failing test when time runs out on another persons laptop
        MDD = MDD - 1;
        break;
    case: (iBrokeIt = false && initialCode = 'Line 30`)
        \\ Your initial code base has successfully refuctored someone.
        MDD = MDD + 3;
        break;
    case: (iBrokeIt = false && iChangedCodeLast = `Line 70`
        \\ You changed code and have succesfully refuctored someone
        MDD = MDD + 1;
        break;
    default:
        break;
        \\ Move on!
}
```