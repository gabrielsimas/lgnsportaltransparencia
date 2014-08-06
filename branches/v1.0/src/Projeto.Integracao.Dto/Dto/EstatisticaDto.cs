// -----------------------------------------------------------------------
// <copyright file="EstatisticaDto.cs" company="CS Services Consultoria em Sistemas">
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
    /// válido apenas para candidatos que estão em exercício na Câmera dos Deputados ou no Senado, caso contrário, vazio
    /// </summary>
    public class EstatisticaDto
    {

        public String faltas_plen { get; set; }
        public String media_plen { get; set; }
        public String faltas_com { get; set; }
        public String media_com { get; set; }
        public String evol { get; set; }
        public String ano_ref { get; set; }
        public String emendas { get; set; }
        public String media_emendas { get; set; }
        
    }
}
