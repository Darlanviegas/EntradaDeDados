using System;
using Entrada_de_Dados_CSharp;

/*Desafio #1: Conhecendo seu usuário
  1. Escreva um algoritmo onde seu usuário deve informar nome, idade,
  peso,altura e profissão, a partir disso você deve exibir um texto
  com todas essas informações pra ele. Ex: Usuário inseriu nome:
  Giovanni,idade: 21, peso: 74kg profissão: Programador altura: 1.83
  (Aqui precisamos coletar o número quebrado, não vale usar tipo
  caractere para altura hein) Você exibe: Olá Giovanni, você tem 21
  anos, é programador, tem 1.83M de altura e pesa 74kg.*/
class Program
{
    static void Main(string[] args)

    {
        string name;
        int age, months, weeks, days, currentyear, birth, counter;
        double weight;
        double height, imc;
        string profession;


        //Data Collect.
        Console.WriteLine("Qual o seu nome?");
        name = Console.ReadLine();
        Console.WriteLine("Qual sua idade?");
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Qual seu peso? Utilize a vírgula");
        weight = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Qual sua altura? Utilize a vírgula");
        height = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Qual sua profissão?");
        profession = Console.ReadLine();
        Console.WriteLine();


        Console.WriteLine("Olá " + name + ", você tem " + age + " anos sua profissão é " + profession + " sua altura é " + height + " e você pesa " + weight + " KG");

        //Age Validation.
        if (age > 18)
        {
            Console.WriteLine("Como você já é maior de idade pode tomar umas no Carnaval! Mas não esquece de voltar de Uber");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Como você ainda é menor de idade, vai ter que ficar só na Coca Cola!");
            Console.WriteLine();
        }

        //Output user age in months weeks and days.
        months = age * 12;
        weeks = age * 52;
        days = age * 365;
        Console.WriteLine("Uma curiosidade sobre você! Já viveu até o momento:");
        Console.WriteLine(months + " meses " + weeks + " semanas " + days + " dias");
        Console.WriteLine();

        //User IMC calculation.
        imc = weight / (height * height);
        Console.WriteLine("Seu IMC é " + imc + " KG/m²");
        if (imc < 18.5)
        {
            Console.WriteLine("Sua condição física é Magreza");
        }
        else if ((imc > 18.4) && (imc < 25.0))
        {
            Console.WriteLine("Sua condição física é Normal");
        }
        else if ((imc > 24.8) && (imc < 30.1))
        {
            Console.WriteLine("Sua condição física é Sobrepeso");
        }
        else
        {
            Console.WriteLine("Sua condição física é Obesidade");

        }
        Console.WriteLine();

        //Year the user was born.
        Console.WriteLine("Em que ano estamos?");
        currentyear = Convert.ToInt32(Console.ReadLine());
        birth = currentyear - age;
        Console.WriteLine("Você nasceu em " + birth);
        Console.WriteLine();

        //How old were you in each year                    
        for (counter = birth; counter < currentyear; counter++)
        {
            Console.WriteLine(counter + " Você tinha " + (counter - birth) + " anos");
        }

        Console.WriteLine(counter + " Você tem " + (currentyear - birth) + " anos.");

    }





}


