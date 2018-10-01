using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //escribe un programa que muestre hola y tu nombre
            Console.WriteLine("Hola Pilar");
            //escribe un programa que muestre la suma de 2 numeros
            Console.WriteLine(2 + 1);
            //escribe division entre 2 numeros
            Console.WriteLine(2 / 1);
            //escribe un programa que muestre el siguiente resultado
            //-5+8*6
            Console.WriteLine(-5 + 8 * 6);
            //(55+9)%9
            Console.WriteLine((55 + 9) % 9);
            //5+15/3*2-8%3
            Console.WriteLine(5 + 15 / 3 * 2 - 8 % 3);
            //escribe un programa que pida 2 numeros al usuario y muestre le resultado de multiplicar los 2
            Console.WriteLine("Introduce un numero");
            int numero1;
            numero1=Convert.ToInt32(Console.ReadLine()); //aqui hemos hecho un casting
            Console.WriteLine("Introduce otro numero");
            int numero2;
            numero2=Convert.ToInt32(Console.ReadLine());           
            Console.WriteLine("La multiplicacion entre " + numero1 + " y " + numero2 + " es " + (numero1*numero2));
            //Escribe un programa que pida un número al usuario y muestre la tabla de multiplicar hasta 10 de ese número
            Console.WriteLine("Introduce un numero");
            int numero3;
            numero3 = Convert.ToInt32(Console.ReadLine());

            int a=0;

            while (a<11)
            {
                Console.WriteLine(numero3 * a);
                a++;

            }

            //Escribe un programa que calcule el resultado de la siguiente operación
            Console.WriteLine(((25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5)));

            //Escribe un programa que pida al usuario el radio de un círculo y que calcule y muestre el área 
            //y el perímetro (el área de un círculo es PI por radio cuadrado y el perímetro es 2 por radio por PI)

            Console.WriteLine("Radio del circulo");
            double radio;
            radio = Convert.ToInt32(Console.ReadLine());
            const double PI=3.14;

            Console.WriteLine("El area del circulo es " + (PI * (radio * radio)) + " y el perimetro es " + (2 * PI * radio));

            //Escribe un programa que pida tres números al usuario y que calcule y muestre su media. 

            Console.WriteLine("Dame 1 numero");
            double numero4;
            numero4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame 1 numero");
            double numero5;
            numero5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame 1 numero");
            double numero6;
            numero6 = Convert.ToInt32(Console.ReadLine());
            double resultado = (numero4 + numero5 + numero6) / 3;
            Console.WriteLine("La media de los 3 numeros es " + resultado);

            //Escribe un programa que pida al usuario la anchura y altura de un rectángulo y que calcule 
            //y muestre su área y su perímetro (el área es la altura por la anchura y el perímetro es 2 por la suma 
            //    de la altura y la anchura).
            Console.WriteLine("Dame el ancho de un rectangulo");
            double ancho;
            ancho = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame el alto de un rectangulo");
            double alto;
            alto = Convert.ToInt32(Console.ReadLine());
            double resultadoArea;
            resultadoArea = (ancho * alto);
            double perimetro;
            perimetro = 2 * (alto + ancho);
            Console.WriteLine("El area es " + resultadoArea + " y el perimetro es " + perimetro);

            //Escribe un programa que pida dos variables, y después intercambie sus valores(si por ejemplo ponemos 8 
            //en la variable a y 5 en la variable b, que al final del programa la variable a tenga el valor 5 y la 
            //variable b el valor 8).

            Console.WriteLine("Dame 1 numero");
            int numero7;
            numero7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame otro numero");
            int numero8;
            numero8 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Los numeros cambiados son " + numero8 + " y " + numero7);


            //Escribe un programa que pida un número de 3 dígitos y que muestre en pantalla el resultado de sumarlos.
            Console.WriteLine("Dame un numero de 3 digitos");
            int numero9;
            numero9 = Convert.ToInt32(Console.ReadLine());
            int a1;
            a1 = numero9 / 100;
            int b;
            b = (numero9 % 100)/10;
            int c;
            c = numero9-(a1*100)-(b*10);
            Console.WriteLine("La suma de los 3 digitos es: " + (a1+b+c));

            //Escribe un programa que pida al usuario un dígito(n) y calcule y muestre el valor de n+nn + nnn.
            //Por ejemplo si el usuario introduce 5 el programa calcularía 5 + 55 + 555
            Console.WriteLine("Dame un digito");
            string n = Console.ReadLine();
            int dig1;
            dig1 = Convert.ToInt32(n);
            int dig2;
            dig2 = Convert.ToInt32(n+n);
            int dig3;
            dig3 = Convert.ToInt32(n+n+n);
            int frase;
            frase = (dig1+dig2+dig3);
            Console.WriteLine(frase);

            //Escribe un programa que pida al usuario un número y convierta el string a un int y lo muestre en pantalla.
            Console.WriteLine("Dame un numero");
            string num1;
            num1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine(num1);


            //Escribe un programa que calcule el resto de dividir dos números sin 
            //utilizar el operador de división de resto(%)
            Console.WriteLine("Dame 2 numeros");
            int nume2;
            nume2 = Convert.ToInt32(Console.ReadLine());
            int nume3;
            nume3 = Convert.ToInt32(Console.ReadLine());
            double division = nume2/nume3;

            Console.WriteLine(division);


            //Escribe un programa que le pida al usuario un número de pulgadas y lo convierta a
            //metros(una pulgada son 0.0254 metros)
            Console.WriteLine("Dame pulgadas");
            double medida;
            medida = Convert.ToInt32(Console.ReadLine());
            const double PULGADA = 0.0254;
            double resultadoMetros = medida * PULGADA;
            Console.WriteLine(medida +" pulgadas son " + resultadoMetros + " metros");

            //Escribe un programa que pida un número de minutos y muestre cuantos años y días son

            Console.WriteLine("Dime minutos");
            int minutos;
            minutos = Convert.ToInt32(Console.ReadLine());
            const double AÑOS = 525600 ;
            const double DIAS = 1440 ;
            double año = minutos/AÑOS;
            double dia = minutos/DIAS;
            Console.WriteLine(minutos + " minutos son " + año + " años y " + dia + " dias ");

            //Escribe un programa que pida una distancia(en metros), y el tiempo tardado
            //(como tres números: horas, minutos y segundos) y que muestre la velocidad en metros por segundo y kilómetros por hora.
            Console.WriteLine(" Dime una distancia en metros");
            double distancia;
            distancia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dime el tiempo tardado en horas..");
            double horas;
            horas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("minutos...");
            double minuto;
            minuto = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("... y segundos");
            double segundos;
            segundos = Convert.ToInt32(Console.ReadLine());

            double velocidad = (distancia/1000) / horas;
            double velocidadMetros = (distancia * 1000) /
                ((horas*3600)+(minuto*60)+segundos); 

            Console.WriteLine("La velocidad es de " + velocidad + " kilometros/hora " + " y de " + velocidadMetros + "metros/segundo" );

            //Escribe un programa que genere un número aleatorio entre el 1 y el 100(pista: hay que utilizar una función).

            Console.WriteLine("Esto va a generar un numero aleatorio entre 1 y 100: ");
            int aleatorio;
            aleatorio = Convert.ToInt32(Console.ReadLine());
            aleatorio = ++aleatorio;
        
            
            Console.WriteLine(aleatorio);
































            Console.ReadLine(); 






            


        }
        
            
        
    }
}
