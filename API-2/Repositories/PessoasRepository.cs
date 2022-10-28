using API_2.Models;


namespace API_2.Repositories
{
    public interface IPessoasRepository
    {
        public bool Create(Pessoa pessoa);
        public Pessoa Read(int id);
        public bool Update(Pessoa pessoa);
        public bool Delete(int id);
    }
    public class PessoasRepository: IPessoasRepository
    {
        private readonly _DbContext db;
        public PessoasRepository(_DbContext _db)
        {
            db = _db;
        }

        public bool Create(Pessoa pessoa)
        {
            try
            {

                var pessoa_db = new Pessoa()
                {
                    Nome = pessoa.Nome, 
                    CPF = pessoa.CPF,   
                    Email = pessoa.Email,
                };
                db.pessoa.Add(pessoa_db);
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }


        

        public Pessoa Read(int id)
        {
            try
            {
                var pessoa_db = db.pessoa.Find(id);
                return pessoa_db;
            }
            catch
            {
                return new Pessoa();
            }
        }

        public bool Update(Pessoa pessoa)
        {
            try
            {
                var pessoa_db = db.pessoa.Find(pessoa.Id);
                pessoa_db.Nome = pessoa.Nome;
                pessoa_db.CPF = pessoa.CPF;
                pessoa_db.Email = pessoa.Email;
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
                var pessoa_db = db.pessoa.Find(id);
                db.pessoa.Remove(pessoa_db);
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
