namespace Tutorial_App_04
{
    public class Aluno : Pessoa // : add at class aluno a heritage from class Pessoa, avoiding to write code repetly
    {
        public int Nota { get; set; }
        //here in consequence to add class PESSOA with ": Pessoa" we can use all properties from PESSOA inside this class, as Nome and Idade
    }
}
