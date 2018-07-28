using System;

namespace temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMenu();
            bool loop = true;
            while(loop){

                Console.Write("Input Menu: ");
                int menu = int.Parse(Console.ReadLine());
                TempCalculator cal = new TempCalculator();
                
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Reset menu Press [C/c]");
                        Console.Write("Input Number: ");
                        var input1 = Console.ReadLine();
                        if(Int32.TryParse(input1,out int number1)){
                            var result = cal.ConvertFahrenheitToCelsius(number1);
                            Console.Write("Output >>>");
                            Console.WriteLine(result);
                        }else if(input1 == "c" || input1 == "C"){
                            PrintMenu();
                        }
                        break;
                    case 2:
                         Console.WriteLine("Reset menu Press [C/c]");
                        Console.Write("Input Number: ");
                        var input2 = Console.ReadLine();
                        if(Int32.TryParse(input2,out int number2)){
                            var result = cal.ConvertKelvinToCelsius(number2);
                            Console.Write("Output >>>");
                            Console.WriteLine(result);
                        }else if(input2 == "c" || input2 == "C"){
                            PrintMenu();
                        }
                        break;
                    case 3:
                         Console.WriteLine("Reset menu Press [C/c]");
                        Console.Write("Input Number: ");
                        var input3 = Console.ReadLine();
                        if(Int32.TryParse(input3,out int number3)){
                            var result = cal.ConvertCelsiusToFahrenheit(number3);
                            Console.Write("Output >>>");
                            Console.WriteLine(result);
                        }else if(input3 == "c" || input3 == "C"){
                            PrintMenu();
                        }
                        break;
                    case 4:
                         Console.WriteLine("Reset menu Press [C/c]");
                        Console.Write("Input Number: ");
                        var input4 = Console.ReadLine();
                        if(Int32.TryParse(input4,out int number4)){
                            var result = cal.ConvertKelvinToFahrenheit(number4);
                            Console.Write("Output >>>");
                            Console.WriteLine(result);
                        }else if(input4 == "c" || input4 == "C"){
                            PrintMenu();
                        }
                        break;
                    case 5:
                         Console.WriteLine("Reset menu Press [C/c]");
                        Console.Write("Input Number: ");
                        var input5 = Console.ReadLine();
                        if(Int32.TryParse(input5,out int number5)){
                            var result = cal.ConvertFahrenheitToKelvin(number5);
                            Console.Write("Output >>>");
                            Console.WriteLine(result);
                        }else if(input5 == "c" || input5 == "C"){
                            PrintMenu();
                        }
                        break;
                    case 6:
                        Console.WriteLine("Reset menu Press [C/c]");
                        Console.Write("Input Number: ");
                        var input6 = Console.ReadLine();
                        if(Int32.TryParse(input6,out int number6)){
                            var result = cal.ConvertCelsiusToKelvin(number6);
                            Console.Write("Output >>>");
                            Console.WriteLine(result);
                        }else if(input6 == "c" || input6 == "C"){
                            PrintMenu();
                        }
                        break;
                    case 7:
                        loop = false;
                        break;
                }
                if(loop == true){
                    PrintMenu();
                }else{
                    Console.WriteLine("Bye bye..");
                }
                
            }
            
        } 

         static void PrintMenu()
        {
            Console.WriteLine("\n\t [1] Fahrenheit to Celsius");
            Console.WriteLine("\t [2] Kelvin to Celsius");
            Console.WriteLine("\t [3] Celsius to Fahrenheit");
            Console.WriteLine("\t [4] Kelvin to Fahrenheit");
            Console.WriteLine("\t [5] Fahrenheit to Kelvin");
            Console.WriteLine("\t [6] Celsius to Kelvin");
            Console.WriteLine("\t [7] Quit");
        }  
    }
}
