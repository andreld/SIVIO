using System;
using System.Collections.Generic;
using System.Text;

namespace Sivio.Models
{
    public class ObrasModel
    {
        public string FKInstalacao { get; set; } // mudar para int, chave estrangeira Instalação
        public int IdObra { get; set; }
        public string ResumoObra { get; set; }
        public string DescriObra { get; set; }
        public string FKReponsavel { get; set; } //mudar para int chave estrangeira de Contratada, 
        public double Custo { get; set; }
        public string OrigemRecursos { get; set; } //outra entidade?
        public DateTime DataInicio { get; set; }
        public int Prazo { get; set; }
        public double Latitude { get; set; }    
        public double Longitude { get; set; }
        public bool StatusObra { get; set; }
    }
}
