using System;
using System.ComponentModel.DataAnnotations;
using ChamarCepApi.Controllers;
using ChamarCepApi.Models;

namespace ChamarCepApi
{
    public class WeatherForecast
    {
        public string CEp { get; set; }
    }
    public void OnPostSubmit(Cidade cidade)
    {
        var cep = new CEP();
        var nomeCidade = cep.BuscarCidade(cidade);
        this.CEp = nomeCidade;
    }
}
