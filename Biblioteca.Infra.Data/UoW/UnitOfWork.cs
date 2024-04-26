﻿using Biblioteca.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BibliotecaDBContext _context;

        public UnitOfWork(BibliotecaDBContext context)
        {
            _context = context;
        }

        public bool Commit()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
