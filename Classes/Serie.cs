namespace DIO.Series
{    //Classe onde são criados os Atributos e métodos utilizados.
    public class Serie : EntidadeBase
    {   // Atributos
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido {get; set; }
        //Metodos
        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {   this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;}
        public override string ToString()
        {   string retorno = "";
            retorno += "Genero: " + this.Genero + System.Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + System.Environment.NewLine;
            retorno += "Descricao: " + this.Descricao + System.Environment.NewLine;
            retorno += "Ano de Inicio: " + this.Ano + System.Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;}
        public string retornaTitulo()
        {   return this.Titulo;}
        internal int retornaId()
        {   return this.Id;}
        public void Excluir()
        {   this.Excluido = true;}
        public bool retornaExcluido()
        {   return this.Excluido;}
}}