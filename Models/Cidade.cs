﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIBuscarCidade.Models
{
    public class Cidade
    {
        public string cep { get; set; }
        public string localidade { get; set; }
    }
}
