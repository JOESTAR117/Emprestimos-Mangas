using EmprestimosManga.Data;

namespace EmprestimosManga.Models.Repositories
{
    public class EmprestimoRepositories : IEmprestimosRepositories
    {
        private readonly ApplicationDbContext _context;

        public EmprestimoRepositories(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(EmprestimosModel emprestimos)
        {
            _context.Emprestimos.Add(emprestimos);
            _context.SaveChanges();
        }

        public void Delete(EmprestimosModel emprestimos)
        {
           if (_context.Emprestimos != null)
            {
                _context.Remove(emprestimos);
                _context.SaveChanges();
            }
        }

        public List<EmprestimosModel> GetAll()
        {
            return _context.Emprestimos.ToList();
        }

        public EmprestimosModel? getById(int id)
        {
            return _context.Emprestimos.Find(id);
        }

        public void Update(EmprestimosModel emprestimos)
        {
            _context.Update(emprestimos);
            _context.SaveChanges();
        }
    }
}
