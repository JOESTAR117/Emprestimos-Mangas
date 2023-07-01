namespace EmprestimosManga.Models.Repositories
{
    public interface IEmprestimosRepositories
    {
        void Add(EmprestimosModel emprestimos);

        List<EmprestimosModel> GetAll();

        void Delete(EmprestimosModel emprestimos);

        EmprestimosModel? getById(int id);

        void Update(EmprestimosModel emprestimos);
    }
}
