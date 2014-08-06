// -----------------------------------------------------------------------
// <copyright file="BemDto.cs" company="CS Services Consultoria em Sistemas">
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
    /// Retorna informações sobre todos os bens declarados pelo candidato, separados pelo ano de declaração. Contém informações como descrição, tipo e valor unitário do bem declarado.
    /// </summary>
    public class BemDto
    {
        public String bem { get; set; }
        public String montante { get; set; }
        public String ano { get; set; }
    }
}
