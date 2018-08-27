using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Livro : Autor
    {
        public int CdLivro { get; set; }
        public string TituloLivro { get; set; }
        public string SinopseLivro { get; set; }

    }
}
