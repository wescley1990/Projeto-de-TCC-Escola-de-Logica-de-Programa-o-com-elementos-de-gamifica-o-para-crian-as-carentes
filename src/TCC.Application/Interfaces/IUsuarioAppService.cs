using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Application.ViewModels;

namespace TCC.Application.Interfaces
{
    public interface IUsuarioAppService : IDisposable
    {
        Task<IEnumerable<UsuarioViewModel>> GetAll();
    }
}
