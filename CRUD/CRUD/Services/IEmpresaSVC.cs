using CRUD.Models;

namespace CRUD.Services
{
    //interface com as assinaturas
    public interface IEmpresaSVC
    {
        Task Adicionar(Empresa empresa);

        Task Atualizar(Empresa empresa);

        Task Deletar(Empresa empresa);

        Task<Empresa> GetBy(Guid id);

        Task<List<Empresa>> FindAll();
    }
}
