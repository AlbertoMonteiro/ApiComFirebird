using System;

namespace ApiComFirebird.Models
{
    /// <summary>
    /// A entidade que é a representação da tabela no banco de dados
    /// </summary>
    public class Pessoa
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
    }
}