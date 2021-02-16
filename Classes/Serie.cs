namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        // Atributos

        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }

        //Metodos

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
        }

        public override string ToString()
        {
            //Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline
            string retorno = "";
            retorno += "Genero: " + this.Genero + System.Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + System.Environment.NewLine;
            retorno += "Descricao: " + this.Descricao + System.Environment.NewLine;
            retorno += "Ano de Inicio: " + this.Ano;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        internal int retornaId()
        {
            return this.Id;
        }
    }
}