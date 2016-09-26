using System;

namespace DotnetBot
{
    public static class Program
    {
                public static void Main(string[] args) 
                {
                      string message = "Welcome to .NET Core!";
                        
                       if (args.Length > 0) 
                        {
                          message = String.Empty;
                          foreach (string item in args) 
                          {
                            message += item; 
                          }
                        }

                        Console.WriteLine(GetBot(message));
                }

                public static string GetBot(string message) 
                {
                        string bot = $"\n        {message}";
                        bot += @"
    __________________
                      \
                       \
                          ....
                          ....'
                           ....
                        ..........
                    .............'..'..
                 ................'..'.....
               .......'..........'..'..'....
              ........'..........'..'..'.....
             .'....'..'..........'..'.......'.
             .'..................'...   ......
             .  ......'.........         .....
             .                           ......
            ..    .            ..        ......
           ....       .                 .......
           ......  .......          ............
            ................  ......................
            ........................'................
           ......................'..'......    .......
        .........................'..'.....       .......
     ........    ..'.............'..'....      ..........
   ..'..'...      ...............'.......      ..........
  ...'......     ...... ..........  ......         .......
 ...........   .......              ........        ......
.......        '...'.'.              '.'.'.'         ....
.......       .....'..               ..'.....
   ..       ..........               ..'........
          ............               ..............
         .............               '..............
        ...........'..              .'.'............
       ...............              .'.'.............
      .............'..               ..'..'...........
      ...............                 .'..............
       .........                        ..............
        .....

";
                        return bot;
                }


        }
}
