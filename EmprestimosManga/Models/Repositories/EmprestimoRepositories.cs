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

        public List<EmprestimosModel> GetAll()
        {
            return _context.Emprestimos.ToList();
        }
    }
}
