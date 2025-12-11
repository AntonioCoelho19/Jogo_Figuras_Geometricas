using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoFigurasGeometricas.Classes
{
    public class ImagemDesafio
    {
        public string CaminhoImagem {get; set;}
        public int Circulos {get; set;}
        public int Triangulos {get; set;}
        public int Quadrados {get; set;}
        public int Retangulos {get; set;}

        public ImagemDesafio(string caminho, int circulos, int triangulos, int quadrados, int retangulos)
        {
            CaminhoImagem = caminho;
            Circulos = circulos;
            Triangulos = triangulos;
            Quadrados = quadrados;
            Retangulos = retangulos;
        }
    }
}
