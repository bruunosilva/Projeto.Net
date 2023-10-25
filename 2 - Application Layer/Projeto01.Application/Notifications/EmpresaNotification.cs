using MediatR;
using Projeto01.Domain.Entities;

namespace Projeto01.Application.Notifications;

public class EmpresaNotification : INotification
{
    public Empresa Empresa { get; set; }
    public ActionNotification Action { get; set; }
}