using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ChamarCepApi.Models;

namespace ChamarCepApi.Controllers
{
    public class CEP
    {
        public string BuscarCidade(Cidade cidade)
        {
            string strurlTest = string.Format("https://viacep.com.br/ws/{0}/json/", cidade.Cep);
            WebRequest requestObjGet = WebRequest.Create(strurlTest);
            requestObjGet.Method = "GET";
            HttpWebResponse responseObjGet = null;
            responseObjGet = (HttpWebResponse)requestObjGet.GetResponse();
            string streesulttest = null;
            using (Stream stream = responseObjGet.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                streesulttest = sr.ReadToEnd();
                sr.Close();
            }
            return streesulttest;
        }
    }
}
