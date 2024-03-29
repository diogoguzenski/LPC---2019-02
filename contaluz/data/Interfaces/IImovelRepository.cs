using System.Collections.Generic;
using domain.Models;

namespace TESTE.Interfaces
{
    public interface IImovelRepository
    {
        int Insert(Imovel obj);
        int Update(Imovel obj);
        int Delete(int id);
        Imovel GetById(int id);
        List<Imovel> GetAll();
    }
}