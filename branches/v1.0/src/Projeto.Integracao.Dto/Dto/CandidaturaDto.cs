// -----------------------------------------------------------------------
// <copyright file="CandidaturaDto.cs" company="CS Services Consultoria em Sistemas">
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
    /// Informações sobre candidaturas passadas do candidado
    /// </summary>
    public class CandidaturaDto
    {

        public String anoEleitoral { get; set; }
        public String cargo { get; set; }
        public String partidoSigla { get; set; }
        public String municipio { get; set; }
        public String estadoSigla { get; set; }
        public String resultado { get; set; }
        public String votosObtidos { get; set; }
        public String recursosFinaceiros { get; set; }

    }
}
