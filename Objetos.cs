using System;

namespace LoadPlanner
{
    class objetos
    {
    
        public string abreviacion;
        public float numeroEspacios;
         
        public float peso; 
        
        
        public string nombre;
       
        public objetos(string abreviacion, float numeroEspacios,  float peso, string nombre)
        {
          

            this.abreviacion = abreviacion;
            this.numeroEspacios = numeroEspacios;
            
            this.peso = peso;           
            this.nombre = nombre;
        }


        private string ObtenerNombreAMostrar()
        {
            string nombreAMostrar;
            if (this.nombre != null)
            {
                
                nombreAMostrar = this.nombre;
            }
            else
            {
                nombreAMostrar = "Objeto";
            }
            return nombreAMostrar;
        

        
       
        }

        
    }
}