namespace webapi.models
{
    public class Turma
    {
        public int dia { get; set; }
        public string sala { get; set; }
        public int vagas { get; set; }  
        public Disciplina disciplina { get; set; }
    }
}