// -----------------------------------------------------------------------
// <copyright file="FiltroCandidato.cs" company="CS Services Consultoria em Sistemas">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Projeto.Integracao.Dto.Filtro
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Estrategia;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class FiltroCandidatoDto
    {

        private String id;

        private EstrategiaCandidato estrategia;

        public String Id
        {
            get
            {
                return this.id;
            }

            set
            {
                this.id = value;
            }
        }

        public EstrategiaCandidato Estrategia
        {
            get
            {
                return this.estrategia;
            }

            set
            {
                this.estrategia = value;                                
            }
        }
    }
}
