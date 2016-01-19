using System;

namespace ApiComFirebird.Models
{
    /// <summary>
    /// A entidade que � a representa��o da tabela no banco de dados
    /// </summary>
    public class Pessoa
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
    }
}