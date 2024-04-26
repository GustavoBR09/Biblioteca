using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Infra.Data.UoW
{
    public interface IUnitOfWork
    {
        bool Commit();

    }
}
