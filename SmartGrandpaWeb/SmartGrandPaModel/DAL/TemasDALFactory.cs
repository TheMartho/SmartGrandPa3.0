using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGrandPaModel.DAL
{
    public class TemasDALFactory
    {
        public static ITemasDAL Create()
        {
            return TemasDALArchivos.GetInstancia();
        }
    }
}
