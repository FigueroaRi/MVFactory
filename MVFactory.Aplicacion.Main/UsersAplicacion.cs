using System;
using AutoMapper;
using MVFactory.Aplicacion.DTO;
using MVFactory.Aplicacion.Interface;
using MVFactory.Domain.Interface;
using MVFactory.Domain.Entity;
using MVFactory.Transversal.Common;
using MVFactory.Aplicacion.Validador;

namespace MVFactory.Aplicacion.Main
{

    public class UsersAplicacion:IUsersApplicacion
    {
        private readonly IUsersDomain _usersDomain;
        private readonly IMapper _mapper;
        private readonly UsersDtoValidador _usersDtoValidador;


        public UsersAplicacion(IUsersDomain usersDomain, IMapper iMapper, UsersDtoValidador usersDtoValidador)
        {
            _usersDomain = usersDomain;
            _mapper = iMapper;
            _usersDtoValidador = usersDtoValidador;
        }
        public Response<UsersDto> Authenticate(string username, string password)
        {
            var response = new Response<UsersDto>();
            var validation = _usersDtoValidador.Validate(new UsersDto() { UserName = username, Password = password });

            if (!validation.IsValid)
            {
                response.Message = "Errores de Validación";
                response.Errors = validation.Errors;
                return response;
            }
            try
            {
                var user = _usersDomain.Authenticate(username, password);
                response.Data = _mapper.Map<UsersDto>(user);
                response.IsSuccess = true;
                response.Message = "Autenticación Exitosa!!!";
            }
            catch (InvalidOperationException)
            {
                response.IsSuccess = true;
                response.Message = "Usuario no existe";
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }
    }
}
