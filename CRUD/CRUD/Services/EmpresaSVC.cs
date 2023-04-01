using CRUD.Data;
using CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Services
{
    //Funções Adicionar, Deletar e Atualizar;
    public class EmpresaSVC : IEmpresaSVC
    {
        private readonly AppDB appDB;

        public EmpresaSVC(AppDB appdb)
        {
            appDB = appdb;
        }

        public async Task Adicionar(Empresa empresa)
        {
            await appDB.AddAsync(empresa);
            await appDB.SaveChangesAsync();
        }

        public async Task Atualizar(Empresa empresa)
        {
            appDB.Update(empresa);
            await appDB.SaveChangesAsync();
        }

        public async Task Deletar(Empresa empresa)
        {
            appDB.Remove(empresa);
            await appDB.SaveChangesAsync();
        }

        public async Task<Empresa> GetBy(Guid id)
        {
            var empresa = await appDB.Empresas.FirstOrDefaultAsync(c => c.id == id);

            return empresa;
        }

        public async Task<List<Empresa>> FindAll()
        {
            var empresas = await appDB.Empresas.ToListAsync();

            return empresas;
        }


    }
}
