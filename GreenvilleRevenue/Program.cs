//Program written by Dan Plummer and Derek West
//1/.20.17
//CIS 2620 | Chapter 2 | Case Study #1

//2/15/17
//CIS 2620 | Chapter 4 | Case Study #1

//2/26/17
//CIS 2620 | Chapter 5 | Case Study #1

//3/15/2017 
//CIS 2620 | Chapter 6 | Case Study #1

using System;
using static System.Console;

class GreenvilleRevenue
{
    static void Main()
    {
        int lastYearNum, thisYearNum;
        string lastYear, thisYear;
        double admission = 25.00, revenue;
        



        Write("Enter the number of contestants in last year's competition: ");
        lastYear = ReadLine();
        lastYearNum = Int32.Parse(lastYear);

        while (lastYearNum < 0 || lastYearNum > 30)
        {
            Write("Invalid entry, please enter a number from 0 to 30: ");
            lastYear = ReadLine();
            lastYearNum = Int32.Parse(lastYear);
        }



        Write("Enter the number of contestants in this year's competition: ");
        thisYear = ReadLine();
        thisYearNum = Int32.Parse(thisYear);
        bool moreThisYear = thisYearNum > lastYearNum;
        revenue = thisYearNum * admission;

        while (thisYearNum < 0 || thisYearNum > 30)
        {
            Write("Invalid entry, please enter a number from 0 to 30: ");
            thisYear = ReadLine();
            thisYearNum = Int32.Parse(thisYear);
        }


        //Chapter 6 Addition Begin
        string[] contestantTalents = { "S", "D", "M", "O" };
        string[] currentNames = { };
        currentNames = new string[thisYearNum];
        string inputSkill, inputName;
        bool isValid = false;
        int x = 0;

        while( x < currentNames.Length)
            
        {
            Write("Please enter the name for Contestant #{0}: ", x + 1);
            inputName = ReadLine();
            Write("Please enter a skill, either S for singing, D for Dancing, M for Musical Intrument, or O for Other: ");
            inputSkill = ReadLine();
            

            while (isValid == false)
            {
                if (inputSkill == contestantTalents[x])
                    isValid = true;
                else
                    Write("Please enter a skill, either S for singing, D for Dancing, M for Musical Intrument, or O for Other: ");
                     inputSkill = ReadLine();

            }

            currentNames[x] = Convert.ToString(inputName);   
            contestantTalents[x] = Convert.ToString(inputSkill);
            x += 1;
            isValid = false;
 
            
        }
        //Chapter 6 Addition End      


        WriteLine();
        if (thisYearNum > (lastYearNum * 2))
            WriteLine("The Competition is more than twice as big this year!");
        else
            if (thisYearNum > lastYearNum)
            WriteLine("The competition is bigger than ever!");
        else
            if (thisYearNum < lastYearNum)
            WriteLine("A tighter race this year! Come out and cast your vote.");
        // WriteLine("There were {0} contestants last year, and {1} contestants this year.", lastYearNum, thisYearNum);
        // WriteLine("To say that there were more contestants this year than last would be {0}", moreThisYear);
        WriteLine();
        WriteLine("Expected revenue for this year's competition is: ${0}", revenue.ToString("F2"));
    }
}