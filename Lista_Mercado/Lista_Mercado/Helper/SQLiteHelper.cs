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
        static SQLiteHelper database;
        readonly SQLiteAsyncConnection _conn;

        public SQLiteHelper(string path)
        {
            _conn = new SQLiteAsyncConnection(path);
            _conn.CreateTableAsync<Produto>().Wait();
        }
        public Task<int> Insert(Produto p)
        {
            return _conn.InsertAsync(p);
        }

        public void Update(Produto p)
        {
            string sql = "UPDATE Produto SET Descricao=? Quantidade=? Preco=? WHERE id= ?";
            _conn.QueryAsync<Produto>(sql, p.Descricao, p.Quantidade, p.Preco, p.Id ).Wait();

        }


        //retorna preenchido
        //public Task<Produto> GetById(int id)
        //{
        //    //return new Produto(); 
        //}

        
        public Task<List<Produto>> GetAll()
        {
            return _conn.Table<Produto>().ToListAsync();
        }

        public void Delete(int id)
        {
            _conn.Table<Produto>().DeleteAsync(i => i.Id == id);
        }
    }
}
