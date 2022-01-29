
using System;

namespace projeto_series
{
    public class Serie : Entidadebase
    {
        // Atributos 
        private Genero Genero { get; set; }
        private string Titulo { get; set; }   
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido {get; set;}

        // Método
        public Serie (int id, Genero genero, string titulo, string descricao, int ano )
        {
            this.Id = id;
            this.Genero = Genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }
        public override string ToString()
        {
            //  Environment NewLine https://docs.microsoft.com/pt-br/dotnet/api/system.environment.newline?view=net-5.0
            string retorno = ""; 
            retorno += "Gênero:" + this.Genero +  Environment.NewLine ;  
            retorno += "Titulo:" + this.Titulo + Environment.NewLine ;
            retorno += "Descrição:" + this.Descricao + Environment.NewLine; 
            retorno += "Ano de Inicio:" + this.Ano + Environment.NewLine;
            retorno += "Excluído:" + this.Excluido;
            return retorno;
    
    
        }
        public string retornaTitulo()
        {
            return this.Titulo;
        }
        public int retornaId()
        {
            return this.Id;
        }
         public bool retornaExcluido()
        {
            return this.Excluido;
        }
        public void Excluir(){
            this.Excluido = true;
        }
    }   
}

