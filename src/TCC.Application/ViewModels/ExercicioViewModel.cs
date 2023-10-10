using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Application.ViewModels
{
    public class ExercicioViewModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Enunciado { get; set; }
        public string AlternativaA { get; set; }
        public string AlternativaB { get; set; }
        public string AlternativaC { get; set; }
        public string AlternativaD { get; set; }
        public string Resposta { get; set; }
        public int Xp { get; set; }
        public int QtdMoedas { get; set; }
    }
}
