// -----------------------------------------------------------------------
// <copyright file="DoacaoDto.cs" company="CS Services Consultoria em Sistemas">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Projeto.Integracao.Dto.Dto
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Para certos cargos, distinguem-se entre doações para o próprio candidato e doações para os comitês/diretórios da coligação pela qual o sujeito concorreu; Esses casos são identificados por “nome”:“Doações a comitês/diretórios da coligação do candidato”,“cgc”:null,“montante”:null
    /// </summary>
    public class DoacaoDto
    {
        public String nome { get; set; }
        public String cgc { get; set; }
        public String montante { get; set; }
    }
}
