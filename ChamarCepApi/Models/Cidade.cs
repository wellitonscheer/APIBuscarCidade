using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChamarCepApi.Models
{
    public class Cidade
    {
        [Required]
        public string Cep { get; set; }
    }
}
