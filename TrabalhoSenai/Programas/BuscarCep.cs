using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TrabalhoSenai.Programas
{
    internal class BuscarCep
    {
        public static Endereco BuscarCEP(String cep)
        {
			try
			{
				string url = $"https://viacep.com.br/ws/{cep}/json/";
				using (WebClient client = new WebClient())
				{
					string json = client.DownloadString(url);
					Endereco endereco = JsonConvert.DeserializeObject<Endereco>(json);
					return endereco;
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Não foi possivel retornar as informações do cep" + ex.Message, "Erro - busca cep", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
				
			}
        }
    }
}
