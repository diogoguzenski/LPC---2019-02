namespace aula_02
{
    public class Cliente
    {
        public Cliente(int codigo, string nome)
        {
            this.codigo = codigo;
            this.nome = nome;
        }
        public int codigo { get; private set; }
        public string nome { get; private set; }
    }
}