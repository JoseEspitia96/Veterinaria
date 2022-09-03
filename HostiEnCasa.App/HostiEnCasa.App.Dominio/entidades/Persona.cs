using System;

namespace HostiEnCasa.App.Dominio
{
    public class Persona
    {
        public int Id {set; get;}
        public Genero Genero {set; get;}
        public Persona(){

        }

        public Persona(int id){
            this.Id = id;
        }
    }


}