using System;

namespace webapi.models
{
    public class Aluno
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public Cidade Cidade { get; set; }
    }
}