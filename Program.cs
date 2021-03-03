using System;

namespace LoadPlanner
{
    class Program
    {
        static void Main(string[] args)
        {       
        objetos casillaVacia1 = new objetos(null, 0f, 0, null); 
        objetos objeto1 = new objetos("BC", 20f, 1, "Bolsa de chatarra");
        objetos objeto2 = new objetos("C3", 0.2f, 1, "Caja vacia");
        objetos casillaVacia2 = new objetos(null, 20f, 1, null);   
        objetos objeto3 = new objetos("BP", 3f, 2, "Bolsa con plantas");
        objetos objeto4 = new objetos("B", 70f, 2, "Barril");  
        objetos objeto5 = new objetos("C1", 5f, 1, "Caja ligera");
        objetos objeto6 = new objetos("S", 4f, 2, "Silla");  
        objetos objeto7 = new objetos("BP", 3f, 2, "Bolsa con plantas");
        objetos objeto8 = new objetos("B", 70f, 2, "Barril"); 
        objetos objeto9 = new objetos("C2", 15f, 1, "Caja pesada");
        objetos objeto10 = new objetos("S", 4f, 2, "Silla");  

        objetos[,] vehiculo = new objetos [3,4];
        vehiculo [0,0] = casillaVacia1;
        vehiculo [0,1] = objeto1;
        vehiculo [0,2] = objeto2;
        vehiculo [0,3] = casillaVacia2;
        vehiculo [1,0] = objeto3;
        vehiculo [1,1] = objeto4;
        vehiculo [1,2] = objeto5;
        vehiculo [1,3] = objeto6;
        vehiculo [2,0] = objeto7;
        vehiculo [2,1] = objeto8;
        vehiculo [2,2] = objeto9;
        vehiculo [2,3] = objeto10;

        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 4; j++)
            {
                Console.Write(vehiculo[i,j].abreviacion + " ");
            }
            Console.WriteLine();
        }

        if((vehiculo[0,1].peso > vehiculo[1,1].peso))
            {
                Console.WriteLine(vehiculo[1,1].nombre + " se esta aplastando");
            }
            else if((vehiculo[1,1].peso > vehiculo[2,1].peso))
            {
                Console.WriteLine(vehiculo[2,1].nombre + "Se esta aplastando");
            }
            else if((vehiculo[0,2].peso > vehiculo[1,2].peso))
            {
                Console.WriteLine(vehiculo[1,2].nombre + " se esta aplastando");
            }
            else if((vehiculo[1,2].peso > vehiculo[2,2].peso))
            {
                Console.WriteLine(vehiculo[2,2].nombre + " se esta aplastando");
            }
            else if((vehiculo[1,0].peso > vehiculo[2,0].peso))          
            {
                Console.WriteLine(vehiculo[2,0].nombre + " se esta aplastando");
            }
            else if((vehiculo[1,3].peso > vehiculo[2,3].peso))
            {
                Console.WriteLine(vehiculo[2,3].nombre + " se esta aplastando");
            }
            else if((vehiculo[0,1].peso <= vehiculo[1,1].peso && vehiculo[1,1].peso <= vehiculo[2,1].peso))
            {
                Console.WriteLine("Nada se aplasta");
            }
            else if((vehiculo[0,2].peso <= vehiculo[1,2].peso && vehiculo[1,2].peso <= vehiculo[2,2].peso))
            {
                Console.WriteLine("Nada se aplasta");
            }
            else if((vehiculo[1,0].peso <= vehiculo[2,0].peso && vehiculo[1,3].peso <= vehiculo[2,3].peso))
            {
                Console.WriteLine("Nada se aplasta");
            }

        
        

        
               
        }
    }
}
