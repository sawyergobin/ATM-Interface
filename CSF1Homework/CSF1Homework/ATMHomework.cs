using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class ATMHomework
    {
        static void Main(string[] args)
        {

            int acctNum = 998877;
            int pin = 6655;
            int incorrectAcctNum = 0;

            #region ASCII ART

            string balloons = @"
              ,,,,,,,,,,,,,
          .;;;;;;;;;;;;;;;;;;;,.
        .;;;;;;;;;;;;;;;;;;;;;;;;,
      .;;;;;;;;;;;;;;;;;;;;;;;;;;;;.
      ;;;;;@;;;;;;;;;;;;;;;;;;;;;;;;' .............
      ;;;;@@;;;;;;;;;;;;;;;;;;;;;;;;'.................
      ;;;;@@;;;;;;;;;;;;;;;;;;;;;;;;'...................
      `;;;;@;;;;;;;;;;;;;;;@;;;;;;;'.....................
       `;;;;;;;;;;;;;;;;;;;@@;;;;;'..................;....
         `;;;;;;;;;;;;;;;;@@;;;;'....................;;...
           `;;;;;;;;;;;;;@;;;;'...;.................;;....
              `;;;;;;;;;;;;'   ...;;...............;.....
                 `;;;;;;'        ...;;..................
                    ;;              ..;...............
                    `                  ............
                   `                      ......
                  `                         ..
                 `                           '
                `                           '
               `                           '
              `                           `
              `                           `,
              `
               `
                 `.
";

            string monaLisa = @"
i`it)v|[[[[(//s+)`(-\\/JJgbdd@@@@@@@dmKK(c!(/-[2=/cct/!-v\!_L\)|
]-!/(!-)\L\)v|c5(!,!Ldd@@@@@@@@@@@@@@@@@@@dK/]!c\\\v|i\/cT\v((c-
]!`/v\//(-|t\VvcL!m@@@@@M@@@@@@@@@@@@@@@@@@@@bLt\\|)c/2-vv)/it\.
--/-,\,\v\,|)/v/m@@@@@@K@@@@@@@@@@@@@@@@@@@@@@@bK!v!-( )-!.[/cT
//.\--'--|-/c(e@@@@@@@DD@@@@@@@@@@@@@@@@@@@@@@@@@@s\\\\-||/v!c\.
-,-|\`||\-\/id@@@@@@@@N@@@@@@@@@@@@@@@@@@@@@@@@@@@@b.),`-,-/c-`i
!,\!-!-!'!-!d@@@@@@@P[+~**AAA@@@@@@@@@@@@@@@@@@@@@@@b/./`c-/.\7-
--'.-- -/,id@@@*P!`          \'Z8@@@@@@@@@@@@@@@@@@@@@i.\\'.\.c
',`,`\'-,-J@@5`-           -- `-iYA@@@@@@@@@@b@@@@@@@@@_\-|-\c-
'. -.,`/.G@@K- `               - )7KM@@@@@@@@@@@@@@@@@@@c-----/
- `-  --i@@Ai                    -!ZZ@@@@@@@@@@@@@@@@@@@b! \`|-`
 `-,'- G@@@[,                    '.D8K@@@@@@@@@@@@@@@@@@@[/-,-/.
-` .-/v@@@A)                      -)ZdMd@@@@@@@@@@@@@@@@@@\' _\
- ` ,iVJ@@@!                     '-!(K5K@@@@@@@@@@@@@@@@@@[(/s[.
  - i\G@@@Z-                    ' ! -i55ZZ@@@@@@@@@@@@@@@@@)(4)`
 , -|b@@@@!\                     '  ` |-tYG@@@@@@@@@@@@@@@@XNYZ-
   tt@@@@A-,                        '  `)(d@@@@@@@@@@@@@@@@D)8A[
   )8@@@@@\                         ,-'-/Kd@@@@@@@@@@@@@@@@@KD@[
  ]]Z@@@@d|-              ,ii.c,, -.icLZKK@@@@@@8@K@@@@@@@@@(@8[
  KN8@@@@@( .i!vGG_      J4Kb8ZKb@bbK@d@88@@@@@@@b@@@@@@@@@@dK@-
 )/8K@@@K@b@dP~~~T4(    Jd@@7`___s@M@@@@MM8d@@@d@@@@@@@@@@@@LM8[
\!48@K@@@@8@@d*@@@bVi   bAKLY~~@@@@@@*ff/\NM8@@@@@@@@@@@@@@@db@[
,\\Kb@@@d@.~t` !*~!`.  -MA)    '~'.).` `,'K@@@@@@@@@@@@@@@@@AKb[
,`8M@@@@@@ -`,,gvZ``    A//-  ..c\+\`    i]d@@@@@@M@@@@@@@@@@@8[
i\@8@K@@@D              \!'             !iZ8@@@8A@@@@@8d@b@@@8M[
e8d5@@@@@@             '!-             '-)8@@@@@@@@@@@@@@@@@@M8i
8dZ8@M@@@@-             v  ,          ,\tK@@@@@@@@@@@@A@@@@@@Z2|
@b@AK@@@b@[              //           cctbA@@@AK@@d@@d@@@K@@@bmi
@@8@M@8@@@P-            -=/.         /iD8d@@@@@@@@@@@@@@A@@@d@@[
@8@@@MA@@@@\-      .   _)g2i        -((dKK@@@@@d@@@@d@@K@@@@@@K[
@@@bAK@@K@@)i     'c,,Kb@@bK       )X)Kb@M@@d@@@Mb@@A@d@@@@@@8@[
@K@b@@@@A@AA/i-     ~M@@@@Mc    .,\c=)D8d@@b@@@d@@@@@@@@@@8d@@A[
@@@@Mb@@@@@@('c\`     PPK((,i]v|-\-v)8XNAdMK@@@@@@@b@@MK@A@@@@@[
@@8@@MK@d@A@L!--c)s_, ,(ZsbLb@\`- .-N]/KM@@@@@@@d@@@A@@@@@@@@d@[
@@Kb@@@K@b@@@/-  !''~~Vff*N5f -` -,\))KK@@@@@@@MK@@d@@@M8d@b@@@[
@b@@@KAK@@@@@@2--    ,,_JJ/i)/- |/v)NK@8d@@@@@@@@@@8@@@@@@@@M@K[
@@8d@K@@@b@@@@@d!,   'VV\)\\)\7(-)4Jb@8@A@@@K@d@@@@@@@8@@@@@@@@[
M@@@@8@@K@Kb@@@d@v.       `-\\/v)88b@M@A@K@@M@@@A@@M@8@@A@d@8@M[
Zb@d@M@K@@@@@@@@@@m       -)!/stbb@b@@A@b@@@@@Kb@@@@@@@b@@@K@@@[
K@@d@@@@@d@M@8@@@@@Ks   ,-/vJD@@8d@K@@@@@@8@@@@@@@@@@MK@@@b@@M@[
tN@b@@d@d@M@@@@@@@@@@LL4JKd@A@@d@@K@@@@MK@@@@8@@@@@@@@@@@b@@@@@[
)NM@8b@@A@@@A@@@@@@@@@@@@@@A@@A@@8@@K@d@@@@M@@K@@K@A@@@8@@M@@@@[
(tMM@@@d@@M8@@@@A@@@@A@@@A@@@@@@@@@A@@@@8b@@8d@@@@@@@@@@@@@@@@M[
tNZ@@K@@@d@@@@A@@@@@8@@@/4N@@8@b@@d@@M@8@MK@M8@K@@@@@@d@@@@@@@@[
M/KA8@@@MA@@@M@@@@@@@@@@[|t*Z@N@@@@8@@M8ZAZZ@M@@@A@d@@@@@K@@@d@[
bYJ4M@@@@@@A@@@@@@@@@@@@D.\'(YKKZD@8dK@5A84YZ@dM@@@@@@@@@@@@d@@[
K5dM8@8d@d@@@@@@@@8@@@@@@..-!/))ZK5AK4)AY(/XY/Z@@@A@@@d@@@M@@@@[
Y8dNA@@AK@@d@@@b@@@@@@@@@L,-,\!]]\X(5)Z/7c\\t5/K@@@@@@@@b@@@@@@[
8M8@@@A@@@A@@8@@@@@@@@@KDLt! !,-|t'(-\\!,\/,\!ZJG@@@d@Md@@@G@@@[
";


            string libertyBell = @"

         .--.-,-.-.-,-.--.
         |     \   /     |
         |      \ /      |
         |  .===,=,===.  |
       _/\_; .-'`^`'-. ;_/\_
      (  /` /_________\ `\  )
      |  | |===========| |  |
      |  | |           | |  |
      |  | |  ,        | |  |
      |  | ;_{_________; |  |
      |  |/===`>========\|  |
      |  ;-._<`________.-;  |
      |  | |     U     | |  |
     /   | |___________| |   \
    |                         |
    |                         |
    '-------------------------'

";
            string menuArt = libertyBell;

            #endregion
            bool applicationOn = true;

            while (applicationOn)
            {

                while (incorrectAcctNum < 3)
                {
                    Console.Write("Welcome to the Bank! \nEnter Your Account Number:");
                    int userAcctNum = Convert.ToInt32(Console.ReadLine().Trim());
                    if (userAcctNum == acctNum)
                    {
                        while (userAcctNum == acctNum)
                        {
                            Console.Write("Account Number Located. Enter the associated account PIN: ");
                            int userPin = Convert.ToInt32(Console.ReadLine().Trim());
                            if (userPin == pin)
                            {
                                decimal acctBalance = 247.50m;
                                bool loggedIn = true;
                                while (loggedIn == true)
                                {
                                    Console.Clear();
                                    Console.WriteLine(menuArt);
                                    Console.WriteLine("Welcome, Valued Customer! How may we assist you today?" +
                                        "\nPress the number key of the menu option you wish to use." +
                                        "\n(1) View Account Balance" +
                                        "\n(2) Make a Deposit" +
                                        "\n(3) Make a Withdrawal" +
                                        "\n(4) Change Menu Picture" +
                                        "\n(ESC) Logout of Account");
                                    ConsoleKey menuChoice = Console.ReadKey(true).Key;

                                    switch (menuChoice) //using an if tree instead could allow for numpad entries?
                                    {
                                        case ConsoleKey.D1:
                                            Console.Clear();
                                            Console.WriteLine($"Your current account# {userAcctNum} balance is: \n{acctBalance:c} " +
                                                $"\nPress any key to return to the menu.");
                                            Console.ReadKey();
                                            break;

                                        case ConsoleKey.D2:
                                            Console.Clear();
                                            Console.Write("Enter the amount you wish to deposit: ");
                                            decimal depositAmt = decimal.Parse(Console.ReadLine().Trim());
                                            acctBalance += depositAmt;
                                            Console.WriteLine($"Depositing {depositAmt:c}. \nUpdated account# {userAcctNum} " +
                                                $"remaining balance is {acctBalance:c}. \nPress any key to return to the menu");
                                            Console.ReadKey();
                                            break;

                                        case ConsoleKey.D3:
                                            Console.Clear();
                                            Console.Write("Enter the amount you wish to withdraw: ");
                                            decimal withdrawAmt = decimal.Parse(Console.ReadLine().Trim());
                                            acctBalance -= withdrawAmt;
                                            Console.WriteLine($"Withdrawing {withdrawAmt:c}. \nUpdated account# {userAcctNum}: " +                 $"remaining balance is {acctBalance:c}. \nPress any key to return to the menu");
                                            Console.ReadKey();
                                            break;

                                        case ConsoleKey.D4:
                                            Console.Clear();
                                            Console.WriteLine($"Changing the menu image for account# {userAcctNum}. " +
                                                $"\nnPlease Select from the following options: " +
                                                $"\n(1) Balloons" +
                                                $"\n(2) MonaLisa" +
                                                $"\n(3) Liberty Bell");
                                            ConsoleKey picMenuChoice = Console.ReadKey(true).Key;

                                            switch (picMenuChoice)
                                            {
                                                case ConsoleKey.D1:
                                                    menuArt = balloons;
                                                    Console.WriteLine("Menu image changed to some joyful balloons. Enjoy!");
                                                    break;

                                                case ConsoleKey.D2:
                                                    menuArt = monaLisa;
                                                    Console.WriteLine("Menu image changed to the beautiful Mona Lisa. Enjoy!");
                                                    break;

                                                case ConsoleKey.D3:
                                                    menuArt = libertyBell;
                                                    Console.WriteLine("Menu image changed to the historic Liberty Bell. Enjoy!");
                                                    break;

                                                default:
                                                    Console.Clear();
                                                    Console.WriteLine("That choice was invalid, press any key to continue...");
                                                    Console.ReadKey();
                                                    break;
                                            }//end menuimage switch

                                            break;

                                        case ConsoleKey.Spacebar: //TODO Easter Egg
                                            Console.Clear();
                                            Console.WriteLine("Space Giiiiiirrrrrlllll,\nI saw a lunar eclipse \n Press any " +
                                                "key to return to the menu...");
                                            Console.ReadKey();
                                            break;

                                        case ConsoleKey.Escape:
                                            Console.Clear();
                                            applicationOn = false;
                                            loggedIn = false;
                                            incorrectAcctNum += 3;
                                            acctNum = 0;
                                            Console.WriteLine("Thank you for using our services! \nPress any key to logout... ");
                                            Console.ReadKey(true);
                                            break;


                                        default:
                                            Console.Clear();
                                            Console.WriteLine("That choice was invalid, press any key to continue...");
                                            Console.ReadKey();
                                            break;
                                    }//end main menu switch

                                }//end loggedIn while
                            }//end userPin if
                            else
                            {
                                Console.Clear();
                                Console.WriteLine($"The PIN you entered is incorrect \nYou may keep attempting until you get it correct."); // TODO trapped here if they don't know pin
                            }//end userPin else 
                        }//end acctNum while
                    }//end acctNum if
                    else
                    {
                        Console.Clear();
                        incorrectAcctNum++;
                        Console.WriteLine($"The account number you entered is incorrect \nYou have {3 - incorrectAcctNum} {(incorrectAcctNum == 2 ? "try" : "tries")} remaining.");
                    }//end else

                }//end incorrectAcctNum while
                if (applicationOn == true)
                {
                    Console.WriteLine("You have been locked out for entering incorrect credentials, please see a teller. " +
                                "\nYour business is important to us! Please don't leave or damage this machine!" +
                                "\nPress any button to acknowledge.");
                    Console.ReadKey(true);
                    applicationOn = false;

                }
            }//end applicationOn while

            Console.WriteLine("You have been logged out, have a nice day!");


        }//end Main()
    }//end class
}//end namespace

