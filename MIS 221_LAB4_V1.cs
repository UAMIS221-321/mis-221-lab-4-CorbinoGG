
using System;

class Program{
    static void Main(){
        while(true){
            MainMenu();
            string userInput = GetMenuInput(); //loop priming
            while(userInput != "4"){ //condition control
                RouteUser(userInput);
                MainMenu();
                userInput = GetMenuInput(); //update read
            }
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
                NoToppingPizza();
                break;
            case "2":
                CheesePizza();
                break;
            case "3":
                PepperoniPizza();
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

    static void NoToppingPizza(){
        Console.WriteLine("No Topping Pizza");
        Pause();
    }

    static void CheesePizza(){
        Console.WriteLine("Cheese Pizza");
        Pause();
    }

    static void PepperoniPizza(){
        Console.WriteLine("Pepperoni Pizza");
        Pause();
    }

    static void Pause(){
        System.Console.WriteLine("\nPress any key to return to Menu...\n");
        Console.ReadKey();
    }

    static void Exit(){
        Console.WriteLine("\nClosing program. Thank you for choosing Crimson Crust.\n");
        Environment.Exit(0);
    }
}