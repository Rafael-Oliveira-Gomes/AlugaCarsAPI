using AlugaCars.Core.Entities;

namespace AlugaCars.DataAcess.Interface
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        Task<IEnumerable<Usuario>> ConsultarUsuario(int skip, int take);
        Task<Usuario> ConsultarUsuarioPorID(int id);
    }
}
