using System.Collections.Generic;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia.AppRepositorios
{
    public interface IRepositorioMedico
    {
        Medico AddMedico(Medico medico);
        Medico getMedico(int idMedico);
    }
}