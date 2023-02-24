# Assignment2_N01517224

This is a college assignment repo based on ASP.Net C# language.
 
 Consist of a controller named Assignment2 which contains code for three different problems:
 1. J1 Canadian Calorie Counting
 2. J2 Roll the Dice
 3. J3 Cell-Phone Messaging (not working code commented out, just trying some ways to do this problem)
 
 
 
 
 J1. Program for counting calories based on food selected by the user 
      GET /api/Assignment2/Menu/{burger}/{drink}/{side}/{dessert} , values in curly brackets{} indicated id which user entered in the url
      
      Example HTTP request                                  Example Response 
        GET ../api/J1/Menu/4/4/4/4(input from user)           Your total calorie count is 0(output)
        GET ../api/J1/Menu/1/2/3/4(input from user)           Your total calorie count is 691(output)
      
 J2. program for determines how many ways she can roll the value of 10
      GET /api/Assignment2/DiceGame/6/8  values in curly brackets{} indicated id which user entered in the url
      
      Example HTTP request                                Example Response
        GET ../api/J2/DiceGame/6/8(input from user)         There are 5 total ways to get the sum 10.(output)
        GET ../api/J2/DiceGame/12/4(input from user)        There are 4 ways to get the sum 10.(output)
        GET ../api/J2/DiceGame/3/3(input from user)         There are 0 ways to get the sum 10.(output)
        GET ../api/J2/Dicegame/5/5(input from user)         There is 1 way to get the sum 10.(output)
 
