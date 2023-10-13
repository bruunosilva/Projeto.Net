using AutoMapper;
using Projeto01.Application.Commands.Empresas;
using Projeto01.Domain.Entities;

namespace Projeto01.Application.Profiles;

public class EmpresaProlife : Profile
{
    public EmpresaProlife()
    {
        #region Commands To Entities

        CreateMap<EmpresaCreateCommand, Empresa>()
            .AfterMap((src, dest) =>
            {
                dest.Id = Guid.NewGuid();
            });
        CreateMap<EmpresaUpdateCommand, Empresa>();
        CreateMap<EmpresaDeleteCommand, Empresa>();

        #endregion
    }
}