namespace EmprestimosManga.Models.Repositories
{
    public interface IEmprestimosRepositories
    {
        void Add(EmprestimosModel emprestimos);

        List<EmprestimosModel> GetAll();
    }
}
