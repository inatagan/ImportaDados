using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using ImportaDados.DAO;
using ImportaDados.Model;

namespace ImportaDados.Bll
{
    public class PassagemBll
    {
		PassagemDAO passagemDAO = new PassagemDAO();
		Passagem passagem = new Passagem();
		JavaScriptSerializer serializer = new JavaScriptSerializer();

		public void ImportaDados(string path)
		{
			string[] arquivosJson = Directory.GetFiles(path);
			foreach (string arq in arquivosJson)
			{
				TextReader tr = new StreamReader(arq);
				string linha = tr.ReadLine();
				passagem = serializer.Deserialize<Passagem>(linha);
				passagemDAO.Inserir(passagem);
			}
		}

		public ListaPassagem lista()
		{
			return passagemDAO.lista();
		}
    }
}
