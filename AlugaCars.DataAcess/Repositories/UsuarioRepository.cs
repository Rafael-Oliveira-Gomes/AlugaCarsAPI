using AlugaCars.Core.Entities;
using AlugaCars.DataAcess.Interface;
using AlugaCars.DataAcess.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AlugaCars.DataAcess.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(DataContext context) : base(context) { }

        public async Task<IEnumerable<Usuario>> ConsultarUsuario(int skip, int take)
        {
            return await _context.Usuarios.Skip(skip).Take(take).ToListAsync();
        }

        public async Task<Usuario> GetUser(string userId)
        {
            Usuario user = await _context.Usuarios.FindAsync(userId);

            return user;
        }
        public async Task<Usuario> ConsultarUsuarioPorID(int id)
        {
            return await _context.Usuarios.FindAsync(id);
        }
    }
}
