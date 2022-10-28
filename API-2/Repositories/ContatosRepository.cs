using API_2.Models;


namespace API_2.Repositories
{
    public interface IContatosRepository
    {
        public bool Create(Contato contato);
        public Contato Read(int id);
        public bool Update(Contato contato);
        public bool Delete(int id);
    }
    public class ContatosRepository : IContatosRepository
    {
        private readonly _DbContext db;
        public ContatosRepository(_DbContext _db)
        {
            db = _db;
        }

        public bool Create(Contato contato)
        {
            try
            {
                var contato_db = new Contato()
                {
                    Nome = contato.Nome,
                    Telefone = contato.Telefone,
                    PessoaId = contato.PessoaId

                };
                db.contato.Add(contato_db);
                db.SaveChanges();

                return true;
            }
            catch 
            {
                return false;
            }
        }

        public Contato Read(int id)
        {
            try 
            {
                var contato_db = db.contato.Find(id);
                return contato_db;
            }
            catch
            {
                return new Contato();
            }
        }
        public bool Update(Contato contato)
        {
            try
            {
                var contato_db = db.contato.Find(contato.Id);
                contato_db.Nome = contato.Nome;
                contato_db.Telefone = contato.Telefone;
                contato_db.PessoaId = contato.PessoaId;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete (int id)
        {
            try
            {
                var contato_db = db.contato.Find(id);
                db.contato.Remove(contato_db);
                db.SaveChanges();
                return true;
                
            }
            catch 
            {
                return false; 
            }
        }

       
    }

}
