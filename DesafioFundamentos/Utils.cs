using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos
{
    public class Utils
    {
        public static int GetIntValueFromUser(string getMessage)
        {
            int valueInt = 0;
            bool isInputInvalid = false;
            do{
                if(isInputInvalid) ShowInvalidInput();
                
                Console.WriteLine(getMessage);
                isInputInvalid = !int.TryParse(Console.ReadLine(), out valueInt);
                Console.Clear();
            }while(isInputInvalid);

            return valueInt;
        }

        public static decimal GetDecimalValueFromUser(string getMessage)
        {
            decimal valueDecimal = 0M;
            bool isInputInvalid = false;
            do{
                if(isInputInvalid) ShowInvalidInput();

                Console.WriteLine(getMessage);
                isInputInvalid = !decimal.TryParse(Console.ReadLine(), out valueDecimal);
                Console.Clear();
            }while(isInputInvalid);

            return valueDecimal;
        }


        public static void ShowWaitMessageAndClearConsole(){
            Console.Write("Pressione uma tecla para continuar");Console.ReadKey();
            Console.Clear();
        }

        private static void ShowInvalidInput(){
            Console.WriteLine("Valor inserido está inválido, favor preencher com um valor válido.");
            ShowWaitMessageAndClearConsole();
        }

    }
}