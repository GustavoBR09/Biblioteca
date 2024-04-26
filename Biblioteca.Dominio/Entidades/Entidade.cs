using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dominio.Entidades
{
    public abstract class Entidade
    {
        protected Entidade() 
        {
        }
        public int Id { get; set; }
    }
}
