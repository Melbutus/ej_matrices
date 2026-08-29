using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_clase1.Models
{
    internal class Universidad
    {
        int[,] matriz;
        string[] nombres;
        int[] partidos;

        public Universidad() 
        { 
            matriz = new int[10,5];
            nombres = ["UCA", "UTN", "UNSAM", "UNL", "UNER", "UNR", "UBA", "UADER", "PUNAM", "UMLAM"];
            partidos = [5];
        }


        public void simularJuego()
        {
            Random random = new Random();
            int resultado = 0;
            
           for(int filaUni = 0; filaUni<10; filaUni++) // recorro universidades
           {
                int ganados = 0;
                int empatados = 0;
                int perdidos = 0;
                int puntosTotales = 0;

                for(int partido= 0; partido <5; partido++)
                {
                    resultado = random.Next(0,3);

                    if (resultado == 0) // ganó
                    {
                        ganados += 1;
                    }
                    else if (resultado == 1)//empató
                    {
                        empatados += 1;
                    }
                    else if (resultado== 2)
                    {
                        perdidos += 1;
                    }
                }
                puntosTotales = (ganados * 3) + (empatados * 1);
                matriz[filaUni, 0] = ganados; // guardamos en matriz
                matriz[filaUni,1] = empatados;
                matriz[filaUni,2] = perdidos;
                matriz[filaUni,3] = puntosTotales;
            }
            
        }

        public void ordenar()
        {
            for(int i=0; i<nombres.Length; i++)
            {
                for(int j=0;j<nombres.Length-1; j++)// -1 para q j+1(10) no de error
                {
                    if (matriz[j, 3] < matriz[j + 1, 3]) // si están al revez
                    {
                        for (int k= 0; k < 4; k++) //recorremos columnas
                        {
                            int auxm = matriz[j, k];
                            matriz[j,k] = matriz[j + 1, k];
                            matriz[j+1,k] = auxm;
                            
                        }

                        string auxnom = nombres[j];
                        nombres[j] = nombres[j + 1];
                        nombres[j + 1] = auxnom;
                    }
                }
            }
        }

        public string [] Describir()
        {
            string [] lineas = new string [nombres.Length]; 

            for(int i = 0; i < nombres.Length; i++)
            {
                lineas[i] = $"  {nombres[i], -10}      {matriz[i, 0],-5}      {matriz[i, 1], -5}      {matriz[i, 2],-5}      {matriz[i,3],-5}       ";
            }

            return lineas;
        }
    }
}
