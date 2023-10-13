using System.Security.Cryptography.X509Certificates;

namespace Projeto01.Domain.Entities;

public class Empresa
{
    #region Properties
    public Guid Id { get; set; }
    public string NomeFantasia { get; set; }
    public string RazaoSocial { get; set; }
    public string Cnpj { get; set; }

    #endregion

    #region Navigations

    public ICollection<Funcionario> Funcionarios { get; set; }

    #endregion
    
    

}