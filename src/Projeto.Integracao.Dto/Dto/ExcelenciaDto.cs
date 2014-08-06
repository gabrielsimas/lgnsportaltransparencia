// -----------------------------------------------------------------------
// <copyright file="ExcelenciaDto.cs" company="CS Services Consultoria em Sistemas">
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
    /// Retorna uma lista de Excelências em exercício. É preciso informar parte do nome/apelido ou a casa (Câmara = 1 ou Senado = 2)
    /// </summary>
    public class ExcelenciaDto
    {

        public String id { get; set; }
        public String nome { get; set; }
        public String apelido { get; set; }
        public String casa { get; set; }
        public String titulo { get; set; }
        public String CPF { get; set; }
        public String estado { get; set; }
        public String partido { get; set; }
        public String miniBio { get; set; }
        public String cargos { get; set; }
        public String processos { get; set; }
        public String bancadas { get; set; }
        public String partidosPassados { get; set; }
        public String cargosPassados { get; set; }
        public String estadosPassados { get; set; }
        public String municipiosPassados { get; set; }
        public String votosPassados { get; set; }
        public String recursosPassados { get; set; }
        public String resultadosPassados { get; set; }
        public String anosPassados { get; set; }


    }
}
