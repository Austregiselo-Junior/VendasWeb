﻿using Remotion.Linq.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWeb.Data;
using VendasWeb.Models;

namespace VendasWeb.Services
{
    public class SellerService
    {
        private readonly VendasWebContext _context;

        public SellerService(VendasWebContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList(); //Acessa a fonte de dados relacionados a vendedores (Sellers) e transforma em uma lista
        }

        public void Inser(Seller obj)
        {
            _context.Add(obj); // Serviço de adicionar vendedor
            _context.SaveChanges(); //Confirmar adição no DB
        }

        public Seller FindById(int id)
        {
            return _context.Seller.FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();

        }
    }
}
