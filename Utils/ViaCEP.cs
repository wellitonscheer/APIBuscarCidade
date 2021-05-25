using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using APIBuscarCidade.Models;

namespace APIBuscarCidade.Utils
{
    public class ViaCEP
    {
        public Cidade BuscarCidade(Cidade cidade)
        {
            string url = string.Format("https://viacep.com.br/ws/{0}/json/", cidade.cep);
            WebRequest requestObjGet = WebRequest.Create(url);
            requestObjGet.Method = "GET";
            HttpWebResponse responseObjGet = null;
            responseObjGet = (HttpWebResponse)requestObjGet.GetResponse();
            string jsonRetorno = null;
            using (Stream stream = responseObjGet.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                jsonRetorno = sr.ReadToEnd();
                sr.Close();
            }
            Cidade cidadeRetorno = JsonSerializer.Deserialize<Cidade>(jsonRetorno);
            return cidadeRetorno;
        }
    }
}
