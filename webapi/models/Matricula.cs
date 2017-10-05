using System;

namespace webapi.models
{
    public class Matricula
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public System.DateTime Dt_Matricula { get; set; }
    }
}