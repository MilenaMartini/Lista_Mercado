using System;
using System.Collections.Generic;
using System.Text;
using Lista_Mercado.Model;
using System.Threading.Tasks;
using SQLite;

namespace Lista_Mercado.Helper
{
    public class SQLiteHelper
    {
        readonly SQLiteAsyncConnection connection;

        public void insert(Produto p)
        {

        }

        public void update(Produto p)
        {

        }


        //retorna preenchido
        public Task<Produto> getById(int p)
        {
            return new Produto(); 
        }

        
        public Task<List<Produto>> getAll()
        {

        }

        public void delete(int id)
        {

        }
    }
}
