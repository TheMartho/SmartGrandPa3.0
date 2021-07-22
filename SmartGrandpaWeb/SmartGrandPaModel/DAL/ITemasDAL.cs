using SmartGrandPaModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGrandPaModel.DAL
{
    //INTERFAZ DE TEMASDALARCHIVOS
    public interface ITemasDAL
    {
        List<Tema> GetAll();
        Tema FindById(int id);
        List<String> GetUrls(Tema t);
        List<Tema> temasFiltrados(String filtro);
    }
}
