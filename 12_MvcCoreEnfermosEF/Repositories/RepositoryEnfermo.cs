using _12_MvcCoreEnfermosEF.Data;
using _12_MvcCoreEnfermosEF.Models;

namespace _12_MvcCoreEnfermosEF.Repositories
{
    public class RepositoryEnfermo
    {
        private EnfermoContext context;

        public RepositoryEnfermo(EnfermoContext context)
        {
            this.context = context;
        }

        public List<Enfermo> GetEnfermos()
        {
            var consulta = from datos in this.context.Enfermos
                           select datos;
            return consulta.ToList();
        }

        public Enfermo FindEnfermo(int inscripcion)
        {
            var consulta = from datos in this.context.Enfermos
                           select new Enfermo
                           {
                               Inscripcion = datos.Inscripcion,
                               Apellido = datos.Apellido,
                               Direccion = datos.Direccion,
                               FechaNacimiento = datos.FechaNacimiento,
                               Sexo = datos.Sexo,
                               NSS = datos.NSS
                           };
            return consulta.First();
        }

    }
}
