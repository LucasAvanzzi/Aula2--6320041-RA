using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2__6320041_RA
{
    internal class Filme
    {
        string titulo;
        string sinopse;
        string genero;
        string classificacao;

        public void SetTitulo (string titulo)
        {
            this.titulo = titulo;
        }
        public string GetTitulo()
        {
            return this.titulo;
        }
        public void SetSinopse (string sinopse)
        {
            this.sinopse = sinopse;
        }
        public string GetSinopse ()
        {
            return this.sinopse;
        }
        public void SetGenero (string genero)
        {
            this.genero = genero;
        }
        public string GetGenero ()
        {
            return this.genero;
        }
        public void SetClassificacao (string classificacao)
        {
            this.classificacao = classificacao;
        }
        public string GetClassificacao()
        {
            return this.classificacao;
        }
    }
}
