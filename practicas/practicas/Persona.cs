﻿namespace practicas
{
    public class Persona
    {
        public string Nombre { get; set; }

        public string GetSaludo()
        {
            return $"¡Hola! Mi nombre es {Nombre}.";
        }
    }
}