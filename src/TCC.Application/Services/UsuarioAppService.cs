using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Application.Interfaces;
using TCC.Application.ViewModels;
using TCC.Domain.Interfaces;
using TCC.Domain.Models;
using TCC.Infra.Data.Repository;

namespace TCC.Application.Services
{
    public class UsuarioAppService : IUsuarioAppService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;
        private readonly UserManager<Usuario> _userManager;

        public UsuarioAppService(
            IUsuarioRepository usuarioRepository,
            IMapper mapper,
            UserManager<Usuario> userManager
            )
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
            _userManager = userManager;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public async Task<IEnumerable<UsuarioViewModel>> GetAll()
        {
            var users = _userManager.Users.ToList();
            return _mapper.Map<IEnumerable<UsuarioViewModel>>(users);
        }
    }
}
