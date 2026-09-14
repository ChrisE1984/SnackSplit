# Debugging

## The Process
1. Read the error message. The whole thing.
2. Find the line it points to,
3. Figure out what caused it.
4. Fix it.
5. Run it again and check.

## Three kinds of problems
+ **Compile time error**: the compiler stops the program before it runs. Red squiggle. Usually a typo, missing semi
colon, or the wrong type
+ **Run time error**: The program compiled, ran, and crashed. also called an **exception**. Usually caused by data 
the program did not expect.
+ **Logic error**: the program compiled, ran, finished, and gave the wrong answer. Nothing catches this one but you.

## Reading the error message
+ Compiler: 'Program.cs(3.18): error (CS0029) words' means file, line 3, column 18, then explanation.
+ Runtime: the first line says what went wrong, the last line says "Program.cs:7'. Skip the middle.