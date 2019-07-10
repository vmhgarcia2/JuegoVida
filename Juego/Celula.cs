using System;
using System.Collections.Generic;
using System.Text;

namespace Juego
{
    public class Celula
    {
        //Estado: true=> viva
        private bool estado;

        public bool Estado
        {
            get => estado;
            set => estado = value;
        }

        public static bool SigueViva(bool estado, byte cantidad)
        {
            throw new Exception("No implementado");
        }

    }
}
