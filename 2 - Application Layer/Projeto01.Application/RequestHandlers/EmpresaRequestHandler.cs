using AutoMapper;
using MediatR;
using Projeto01.Application.Commands.Empresas;
using Projeto01.Application.Notifications;
using Projeto01.Domain.Contracts.Services;
using Projeto01.Domain.Entities;

namespace Projeto01.Application.RequestHandlers;

public class EmpresaRequestHandler :
    IRequestHandler<EmpresaCreateCommand>,
    IRequestHandler<EmpresaUpdateCommand>,
    IRequestHandler<EmpresaDeleteCommand>,
    IDisposable
{
    public EmpresaRequestHandler(IEmpresaDomainService empresaDomainService, IMediator mediator, IMapper mapper)
    {
        _empresaDomainService = empresaDomainService;
        _mediator = mediator;
        _mapper = mapper;
    }

    private readonly IEmpresaDomainService _empresaDomainService;
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;
    
    public async Task<Unit> Handle(EmpresaCreateCommand request, CancellationToken cancellationToken)
    {
        #region Cadastrando empresa

        var empresa = _mapper.Map<Empresa>(request);
        _empresaDomainService.Create(empresa);

        #endregion

        #region Gerar a notificação

        var notification = new EmpresaNotification
        {
            Action = ActionNotification.Create,
            Empresa = empresa
        };
        await _mediator.Publish(notification);

        #endregion
        
        return Unit.Value;
    }

    public async Task<Unit> Handle(EmpresaUpdateCommand request, CancellationToken cancellationToken)
    {
        #region Atualizando empresa

        var empresa = _mapper.Map<Empresa>(request);
        _empresaDomainService.Update(empresa);

        #endregion

        #region Gerar a notificação

        var notification = new EmpresaNotification
        {
            Action = ActionNotification.Update,
            Empresa = empresa
        };
        await _mediator.Publish(notification);

        #endregion
        
        return Unit.Value;
    }

    public async Task<Unit> Handle(EmpresaDeleteCommand request, CancellationToken cancellationToken)
    {
        #region Deletar empresa

        var empresa = _mapper.Map<Empresa>(request);
        _empresaDomainService.Delete(empresa);

        #endregion

        #region Gerar a notificação

        var notification = new EmpresaNotification
        {
            Action = ActionNotification.Delete,
            Empresa = empresa
        };
        await _mediator.Publish(notification);

        #endregion
        
        return Unit.Value;
    }

    public void Dispose()
    {
        _empresaDomainService.Dispose();
    }
}