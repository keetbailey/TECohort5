using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
        
            /*
            INSTRUCTIONS

            The primary purposes of these exercises are to practice: 
                    
                    1. declaring variables and using assignment statements
                    2. using variables, literals, and operators within arithmetic expressions
                    3. choosing meaningful variable names
                    4. choosing appropriate data types

            One of the hardest things about programming is choosing good names. Spend time
            to find good, meaningful, and descriptive names for your variables. Clarity and
            expressiveness is more important than brevity. Err on the side of longer, more 
            descriptive names over short, cryptic ones.

            Be consistent with your choice of datatypes, especially when it comes to 
            some values like money. There are many different ways to express money. Pick one, 
            and stick with it throughout these exercises.
            
            Keep your code consistent and well formatted. When code is poorly indented, 
            or lost in a flood of blank lines, it can make code difficult to read. 
            */

            /* 
            1. 4 birds are sitting on a branch. 1 flies away. How many birds are left on
            the branch? 
            */
            
            // ### EXAMPLE:  
            int initialNumberOfBirds = 4;
            int birdsThatFlewAway = 1;
            int remainingNumberOfBirds = initialNumberOfBirds - birdsThatFlewAway;

            int numOfBirds = 4;
            int flyAway = 1;
            int remainingBirds = numOfBirds - flyAway;
            Console.WriteLine(remainingBirds);
            /* 
            2. There are 6 birds and 3 nests. How many more birds are there than
            nests? 
            */
            
            // ### EXAMPLE: 
            int numberOfBirds = 6;
            int numberOfNests = 3;
            int numberOfExtraBirds = numberOfBirds - numberOfNests;

            int numsOfBirds = 6;
            int numsOfNests = 3;
            int birdsOverNests = numsOfBirds - numsOfNests;
            Console.WriteLine(birdsOverNests);

            /* 
            3. 3 raccoons are playing in the woods. 2 go home to eat dinner. How
            many raccoons are left in the woods? 
            */
            int numberOfRaccoons = 3;
            int dinnerRaccoons = 2;
            int remainingRaccoons = numberOfRaccoons - dinnerRaccoons;
            Console.WriteLine(remainingRaccoons);
            /* 
            4. There are 5 flowers and 3 bees. How many less bees than flowers? 
            */
            int numOfBees = 3;
            int numOfFlowers = 5;
            int beesLessFlowers = numOfFlowers - numOfBees;
              Console.WriteLine(beesLessFlowers);
            /* 
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now? 
            */
            int lonelyPigeon = 1;
            int lonelierPigeon = 1;
            int allTheLonelyPigeons = lonelyPigeon + lonelierPigeon;
            Console.WriteLine(allTheLonelyPigeons);
            /* 
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now? 
            */
            int firstOwls = 3;
            int newOwls = 2;
            int totalOwls = firstOwls + newOwls;
            Console.WriteLine(totalOwls);
            /* 
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home? 
            */
            int allBeavers = 2;
            int lessBeavers = 1;
            int newBeavers = allBeavers = lessBeavers;
            Console.WriteLine(newBeavers);
            /* 
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all? 
            */
            int initialToucans = 2;
            int newToucans = 1;
            int allToucans = initialToucans + newToucans;
            Console.WriteLine(allToucans);
            /* 
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts? 
            */
            int squirrels = 4;
            int nuts = 2;
            int squirrelsOverNuts = squirrels - nuts;
            Console.WriteLine(squirrelsOverNuts);
            /* 
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find? 
            */
            double quarter = .25;
            double dime = .10;
            double nickel = .05;
            double hiltTotal = quarter + dime + nickel + nickel;
            Console.WriteLine(hiltTotal);
            /* 
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all? 
            */
            int muffinsBrier = 18;
            int muffinsMacadams = 20;
            int muffinsFlannery = 17;
            int totalMuffins = muffinsBrier + muffinsMacadams + muffinsFlannery;
            Console.WriteLine(totalMuffins);
            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */
            double yoyoCost = .24;
            double whistleCost = .14;
            double totalCost = yoyoCost + whistleCost;
            Console.WriteLine(totalCost);
            /*
            13. Mrs. Hilt made 5 Rice Krispie Treats. She used 8 large marshmallows
            and 10 mini marshmallows.How many marshmallows did she use
            altogether?
            */
            int largeMallows = 8;
            int miniMallows = 10;
            int totalMallows = largeMallows + miniMallows;
            Console.WriteLine(totalMallows);
            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */
            int hiltHouseSnow = 29;
            int schoolSnow = 17;
            int diffOfSnow = hiltHouseSnow - schoolSnow;
            Console.WriteLine(diffOfSnow);
            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */
            int totalCash = 10;
            int toyTruck = 3;
            int pencilCase = 2;
            int remainingFunds = totalCash - (toyTruck + pencilCase);
            Console.WriteLine(remainingFunds);
            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */
            int initialMarbles = 16;
            int lostMarbles = 7;
            int newMarbleCount = initialMarbles - lostMarbles;
            Console.WriteLine(newMarbleCount);
            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */
            int numOfSeashells = 19;
            int desiredSeashells = 25;
            int necessarySeashells = desiredSeashells - numOfSeashells;
            Console.WriteLine(necessarySeashells);
            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */
            int totalBalloons = 17;
            int redBalloons = 8;
            int greenBalloons = totalBalloons - redBalloons;
            Console.WriteLine(greenBalloons);
            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */
            int shelfBooks = 38;
            int newBooks = 10;
            int totalShelfBooks = shelfBooks + newBooks;
            Console.WriteLine(totalShelfBooks);
            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */
            int oneBeeLegs = 6;
            int totalNumBees = 8;
            int eightBees= oneBeeLegs * totalNumBees;
            Console.WriteLine(eightBees);
            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */
            double iceCreamCone = .99;
            int numOfCones = 2;
            double costOfTwoCones = iceCreamCone * numOfCones;
            Console.WriteLine(costOfTwoCones);
            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */
            int rocksNeeded = 125;
            int rocksOwned = 64;
            int rockDiff = rocksNeeded - rocksOwned;
            Console.WriteLine(rockDiff);
            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */
            int previousMarbles = 38;
            int lostMarbs = 15;
            int newMarbleAmt = previousMarbles - lostMarbs;
            Console.WriteLine(newMarbleAmt);
            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */
            int concertMilesAway = 78;
            int milesDriven = 32;
            int milesLeft = concertMilesAway - milesDriven;
            Console.WriteLine(milesLeft);
            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time did she spend shoveling snow?
            */
            int snowShovelingAm = 90;
            int snowShovelingPm = 45;
            int totalSnowShoveling = snowShovelingAm + snowShovelingPm;
            Console.WriteLine(totalSnowShoveling);
            /*    
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */
            int numHotdog = 6;
            double costHotdog = .50;
            double totalSpent = numHotdog * costHotdog;
            Console.WriteLine(totalSpent);
            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */
            double currentBal = .50;
            double costPencil = .07;
            double remainderBudget = currentBal % costPencil;
            double pencilBudget = (currentBal - remainderBudget) / costPencil;
            Console.WriteLine(pencilBudget);
            /*    
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */
            int viewedButterflies = 33;
            int orangeButterflies = 20;
            int redButterflies = viewedButterflies - orangeButterflies;
            Console.WriteLine(redButterflies);
            /*    
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */
            double cashGiven = 1.00;
            double costCandy = .54;
            double changeGiven = cashGiven - costCandy;
            Console.WriteLine(changeGiven);
            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */
            int currentTreeNum = 13;
            int newTreesAdded = 12;
            int totalTrees = currentTreeNum + newTreesAdded;
            Console.WriteLine(totalTrees);
            /*    
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */
            int numDays = 2;
            int numHoursDay = 24;
            int totalHoursTilGrandma = numDays * numHoursDay;
            Console.WriteLine(totalHoursTilGrandma);
            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */
            int numCousins = 4;
            int numPiecesGum = 5;
            int totalPiecesGumNecessary = numCousins * numPiecesGum;
            Console.WriteLine(totalPiecesGumNecessary);
            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */
            double currentCash = 3.00;
            double costCandyBar = 1.00;
            double changeRemainder = currentCash - costCandyBar;
            Console.WriteLine(changeRemainder);
            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */
            int numBoatsInLake = 5;
            int peoplePerBoat = 3;
            int totalNumPeopleInBoats = numBoatsInLake * peoplePerBoat;
            Console.WriteLine(totalNumPeopleInBoats);
            /*
        35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
        have now?
        */
            int numLegosStart = 380;
            int numLegosLost = 57;
            int currentLegoNum = numLegosStart - numLegosLost;
            Console.WriteLine(currentLegoNum);
            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */
            int currentMuffinNum = 35;
            int desiredMuffinNum = 83;
            int neededMuffins = desiredMuffinNum - currentMuffinNum;
            Console.WriteLine(neededMuffins);
            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */
            int crayonsWilly = 1400;
            int crayonsLucy = 290;
            int diffCrayonNum = crayonsWilly - crayonsLucy;
            Console.WriteLine(diffCrayonNum);
            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */
            int numStickersOnPage = 10;
            int numPagesAvailable = 22;
            int totalNumStickers = numStickersOnPage * numPagesAvailable;
            Console.WriteLine(totalNumStickers);
            /*
            39. There are 96 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */
            int totalCupcakesAvail = 96;
            int totalNumChildren = 8;
            int cupcakeNumPerChild = totalCupcakesAvail / totalNumChildren;
            Console.WriteLine(cupcakeNumPerChild);
            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies each, how many
            cookies will not be placed in a jar?
            */
            int totalGingCookies = 47;
            int cookiesPerJar = 6;
            int remainderCookies = totalGingCookies % cookiesPerJar;
            Console.WriteLine(remainderCookies);
            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received and equal number of croissants,
            how many will be left with Marian?
            */
            int totalCroissants = 59;
            int numNeighbor = 8;
            int remainderCroissants = totalCroissants % numNeighbor;
            Console.WriteLine(remainderCroissants);
            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */
            int cookiesPerTray = 12;
            int totalCookiesNeeded = 276;
            int numTraysNeeded = totalCookiesNeeded / cookiesPerTray;
            Console.WriteLine(numTraysNeeded);
            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */
            int biteSizedPretzels = 480;
            int oneServing = 12;
            int totalServings = biteSizedPretzels / oneServing;
            Console.WriteLine(totalServings);
            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */
            int lemonCupcakes = 53;
            int cupcakesLeftHome = 2;
            int boxLemonCupcakes = 3;
            int totalBoxesLemonCupcakes = (lemonCupcakes - cupcakesLeftHome) / boxLemonCupcakes;
            Console.WriteLine(totalBoxesLemonCupcakes);
            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */
            int preparedCarrotSticks = 74;
            int numPeople = 12;
            int remainingCarrotSticks = preparedCarrotSticks % numPeople;
            Console.WriteLine(remainingCarrotSticks);
            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */
            int numTeddyBears = 98;
            int shelfMax = 7;
            int numShelvesFilled = numTeddyBears / shelfMax;
            Console.WriteLine(numShelvesFilled);
            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */
            int numFamilyPics = 480;
            int albumMaxVolume = 20;
            int numAlbumsNeeded = numFamilyPics / albumMaxVolume;
            Console.WriteLine(numAlbumsNeeded);
            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */
            int numJoeCards = 94;
            int fullBoxVol = 8;
            int numBoxesFilled = numJoeCards / fullBoxVol;
            Console.WriteLine(numBoxesFilled);
            int unfilledBoxAmt = numJoeCards % fullBoxVol;
            Console.WriteLine(unfilledBoxAmt);
            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */
            int numBooks = 210;
            int numShelves = 10;
            int shelfVol = numBooks / numShelves;
            Console.WriteLine(shelfVol);
            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */
            int numCroissants = 17;
            int numGuests = 7;
            int remainingCroissants = numCroissants % numGuests;
            int equalServing = (numCroissants - remainingCroissants) / numGuests;
            Console.WriteLine(equalServing);
            /*
                CHALLENGE PROBLEMS
            */

            /*
            Bill and Jill are house painters. Bill can paint a 12 x 14 room in 2.15 hours, while Jill averages 
            1.90 hours. How long will it take the two painter working together to paint 5 12 x 14 rooms?
            Hint: Calculate the hourly rate for each painter, combine them, and then divide the total walls in feet by the combined hourly rate of the painters.
            Challenge: How many days will it take the pair to paint 623 rooms assuming they work 8 hours a day?.
            */
            int hoursWorkedDay = 8;
            int oneRoomTotalFeet = (12 + 12 + 14 + 14);
            int fiveRooms = oneRoomTotalFeet * 5;
            double rateBillPaints = oneRoomTotalFeet/ 2.15;
            double rateJillPaints = oneRoomTotalFeet / 1.90;
            double combinedHoursPainting = rateBillPaints + rateJillPaints;
            double timeForOneRoom = oneRoomTotalFeet / combinedHoursPainting;
            double timeFiveRooms = fiveRooms / combinedHoursPainting;
            Console.WriteLine("It will take Jill and Bill " + timeFiveRooms + " hours to paint five rooms.");
            double tooManyRooms = oneRoomTotalFeet * 623;
            double sixTwentyThreeRooms = tooManyRooms / combinedHoursPainting;
            double totalDaysSixTwentyThree = sixTwentyThreeRooms / hoursWorkedDay;
            Console.WriteLine("It will take Jill and Bill " + totalDaysSixTwentyThree + " days to paint 623 rooms.");
            
            /*
            Create and assign variables to hold your first name, last name, and middle initial. Using concatenation,
            build an additional variable to hold your full name in the order of last name, first name, middle initial. The
            last and first names should be separated by a comma followed by a space, and the middle inital must end
            with a period.
            Example: "Hopper, Grace B." 
            */
            string firstName = " Keet";
            string lastName = "Bailey,";
            string middleInitial = " S.";
            string fullName = (lastName + firstName +  middleInitial);
            Console.WriteLine(fullName);
            /*
            The distance between New York and Chicago is 800 miles, and the train has already travelled 537 miles. 
            What percentage of the trip has been completed?
            Hint: The percent completed is the miles already travelled divided by the total miles.
            Challenge: Display as an integer value between 0 and 100 using casts.
            */
            double distBetweenDestinations = 800;
            double alreadyTraveledMileage = 537;
            double completedTravel = (alreadyTraveledMileage / distBetweenDestinations) * 100;
            int completedTravelWhole;
            completedTravelWhole = (int)completedTravel;
            Console.WriteLine("The train has completed " + completedTravel + "% or more simply " + completedTravelWhole + "% of it's trip.");
        }
    }
}
