// -----------------------------------------------------------------------
// <copyright file="CandidatoDto.cs" company="CS Services Consultoria em Sistemas">
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
    /// Retorna uma lista de candidatos. É obrigatório definir um estado, exceto quando cargo = 1 (Presidente). Além do estado é obrigatório definir um cargo, um partido ou um nome. Caso essas condições não estejam satisfeitas a busca retorna uma mensagem de erro.
    /// </summary>
    public class CandidatoDto
    {
        public string id { get; set; }
        public string apelido { get; set; }
        public string nome { get; set; }
        public string numero { get; set; }
        public string titulo { get; set; }
        public string CPF { get; set; }
        public string matricula { get; set; }
        public string cargo { get; set; }
        public string estado { get; set; }
        public string partido { get; set; }
        public string idade { get; set; }
        public string instrucao { get; set; }
        public string ocupacao { get; set; }
        public string miniBio { get; set; }
        public string cargos { get; set; }
        public string previsao { get; set; }
        public string bancadas { get; set; }
        public string processos { get; set; }
        public string casaAtual { get; set; }
        public bool reeleicao { get; set; }
        public string foto { get; set; }
    }
}
