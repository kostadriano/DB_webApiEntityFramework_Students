namespace webapi.models
{
    public class Disciplina
    {
      public string nome { get; set; }
      public int ch { get; set;}
      public Curso curso { get; set; }  
    }
}