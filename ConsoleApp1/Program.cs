using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            String alphabet = "ЯУЧЦУЩЛЮЦРТХИЮЛХИЮПГЦРТЮЛЧЩРСІЯЇИМОЩЯГЦЧЇЇИНИЮПЕЧЇЬРЩЧОЙФЗКЯЇИЦРХЦЧНПЦПМШРКХЦЧНПЦИХПКЛЗУЧСАРУЬЧЇИЦЧСХЦЧНПЦПЗУЯЦИОПЇИЖЮЄЯЦРЇЛЩЬИФЄЦЧЖХЦЧНПЦЧЖИІЧЯЦРЇЛЩЬЯХЧХЦИШЩПУФИКЇЛФЛХЛЦЮИЩЦРТИФЙЛІЩРЮИУЧЖЯЦРЇЛЩЬИФЄЦЧЖХЦЧНПЦЧЖХЧНЦИЇЇИНИЮПХЦЧНПЦЯКРТЬЦПБГПЬЛФЯЇПЕРТИФЙЛІЩРХЦЧНПЦЯУЧХШФЛУЬЦПБГПЬЛФЇИЩПАХЛЮПВРХЦЧНПЦЯВРФПБГПЬЛФЇЮЩИКПВРТЦРТШФИЦРХЛЮЩРСХЦЧНПЦЯЇЬРБЮЧГЧУШФЧЕПЦПИІЧХЦЧНПЦЯЇЬРБЙЛЧХЛЮЩПГЦПБЧІМУЮРЇЮЧІЮЧХЦЧНПЦЯХЦЧНПЦЮЧГЧУЦИШФЧЕПЦРЮЧЕЧЗУЕЧОИАРУЬЧЇИЦИЯЦРЇЛЩЬИФЄЦИХЦЧНПЦИЮЧКЧШЧЇЦЛЦЦЗХХЦЧНПЦПЦИОПЇИМЮЄЬЗХЦЧНПЦИЇЬРБЛФЛХЛЦЮРЇЯЦРЇЛЩЬИФЄЦЧСХЦЧНПЦПЗУРЦЛЦИФЛНИЮЄХЦЧНПЦР";
            alphabet = alphabet.Replace("А", "ф").Replace("Б","х").Replace("В", "ц").Replace("Г", "ч").Replace("Д", "ш").Replace("Е", "щ").Replace("Є", "ь").Replace("Ж", "ю").Replace("З", "я").Replace("И", "а").Replace("І", "б").Replace("Ї", "в").Replace("Й", "г").Replace("К", "д").Replace("Л", "е").Replace("М", "є").Replace("Н", "ж").Replace("О", "з").Replace("П", "и").Replace("Р", "i").Replace("С", "ї").Replace("Т", "й").Replace("У", "к").Replace("Ф", "л").Replace("Х", "м").Replace("Ц", "н").Replace("Ч", "о").Replace("Ш", "п").Replace("Щ", "р").Replace("Ь", "с").Replace("Ю", "т").Replace("Я", "у");
            Console.WriteLine(alphabet.ToUpper());
            Console.ReadLine();
        }
    }
}
