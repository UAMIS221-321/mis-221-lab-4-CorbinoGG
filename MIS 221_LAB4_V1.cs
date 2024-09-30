
using System;

class Program{
    static void Main(){
        while(true){
            MainMenu();
            string userInput = GetMenuInput();
            RouteUser(userInput);
        }
    }

    static void MainMenu(){
        Console.Clear();
        Console.WriteLine("Please select a menu choice\n1. No Topping Pizza\n2. Cheese Pizza\n3. Pepperoni Pizza\n4. Exit");
    }

    static string GetMenuInput(){
        return(Console.ReadLine());
    }

    static void RouteUser(string userInput){
        switch(userInput){
            case "1":
                PlainPizza();
                break;
            case "2":
                CheesePizza();
                break;
            case "3":
                PepPizza();
                break;
            case "4":
                Exit();
                break;
            default:
                Console.WriteLine("Invalid menu selection.");
                Pause();
                break;
        }
    }

    static void PlainPizza(){
        Console.Clear();
        Console.WriteLine("Here is your No-Topping Pizza:\n");

        Random random = new Random(); //initialize randomness
        int rows = random.Next(8, 13); //generates a random number between 8 and 12
        for(int i = rows; i >= 1; i--){
            for(int j = 1; j <= rows - i; j++){
                Console.Write(" ");
            }
            for(int k = 1; k <= i; k++){
                Console.Write("* ");
            }
            Console.WriteLine();
        }
        Pause();
    }

    static void CheesePizza(){
        Console.Clear();
        Console.WriteLine("Here is your Cheese Pizza:\n");

        Random random = new Random(); //randomness
        int rows = random.Next(8, 13); //generates a random number between 8 and 12
        for(int i = rows; i >= 1; i--){
            for(int j = 1; j <= rows - i; j++){
                Console.Write(" ");
            }
            for(int k = 1; k <= i; k++){
                if(i == 1 || i == rows || k == 1 || k == i){ //creates border of crust around pizza
                    Console.Write("* ");
                }
                else{
                    Console.Write("# "); //cheese
                }
            }
            Console.WriteLine();
        }
        Pause();
    }

    static void PepPizza(){
        Console.Clear();
        Console.WriteLine("Here is your Pepperoni Pizza:\n");

        Random random = new Random(); //randomness
        int rows = random.Next(8, 13); //generates a random number between 8 and 12
        for(int i = rows; i >= 1; i--){
            for(int j = 1; j <= rows - i; j++){
                Console.Write(" ");
            }
            for(int k = 1; k <= i; k++){
                if(i == 1 || i == rows || k == 1 || k == i){ //creates border of crust around pizza
                    Console.Write("* ");
                }
                else{
                    if(random.Next(0, 8) == 0){ //generates random number of pepperonis
                        Console.Write("[]"); //pepperoni
                    }
                    else{
                        Console.Write("# "); //cheese
                    }
                }
            }
            Console.WriteLine();
        }
        Pause();
    }

    static void Pause(){
        System.Console.WriteLine("\nPress any key to return to Menu...\n");
        Console.ReadKey();
    }

    static void Exit(){
        Console.WriteLine("\nClosing program... \nThank you for choosing Crimson Crust.\n");
        Environment.Exit(0);
    }
}
