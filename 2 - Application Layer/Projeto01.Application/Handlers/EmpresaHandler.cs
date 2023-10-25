using System.Diagnostics;
using MediatR;
using Projeto01.Application.Notifications;
using Projeto01.Domain.Entities;

namespace Projeto01.Application.Handlers;

public class EmpresaHandler : INotificationHandler<EmpresaNotification>
{
    public Task Handle(EmpresaNotification notification, CancellationToken cancellationToken)
    {
        return Task.Run(() =>
        {
            var empresa = notification.Empresa;
            switch (notification.Action)
            {
                case ActionNotification.Create:
                    Debug.Write("Gravando empresa no MONGODB");
                    Debug.Write($"Empresa: {empresa.Id}, {empresa.NomeFantasia}, {empresa.RazaoSocial}, {empresa.Cnpj}");
                    break;
                
                case ActionNotification.Update:
                    Debug.Write("Atualizando empresa no MONGODB");
                    Debug.Write($"Empresa: {empresa.Id}, {empresa.NomeFantasia}, {empresa.RazaoSocial}, {empresa.Cnpj}");
                    break;
                
                case ActionNotification.Delete:
                    Debug.Write("Deletando empresa no MONGODB");
                    Debug.Write($"Empresa: {empresa.Id}, {empresa.NomeFantasia}, {empresa.RazaoSocial}, {empresa.Cnpj}");
                    break;
            }   
        });
    }
}