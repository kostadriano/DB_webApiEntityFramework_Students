using System;

namespace webapi.models
{
    public class Cidade
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }

    }
}