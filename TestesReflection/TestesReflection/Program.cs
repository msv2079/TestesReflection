using System;
using System.Reflection;

namespace TestesReflection
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("TESTES REFLECTION");

			Console.WriteLine(new string('*', 80));

			#region Tipos de Variáveis

			int inteiro = 10;
			string texto = "Murilo";
			float flutuante = 10.2f;

			Type tipo = null;

			tipo = inteiro.GetType();

			Console.WriteLine(tipo.Name);
			Console.WriteLine(texto.GetType().Name);
			Console.WriteLine(flutuante.GetType().Name);

			#endregion

			Console.WriteLine(new string('*', 80));

			var assembly = typeof(Humano).Assembly;
			var humanoType = typeof(Humano);

			Console.WriteLine("Assembly: {0}", assembly);
			Console.WriteLine("Humano Type: {0}", humanoType);

			var classePorNameSpace = Type.GetType("TesteReflection.Humano");

			Console.WriteLine("Classe por NameSpace: {0}", classePorNameSpace);

			Console.Write(new string('*', 80));

			#region Propriedades da Classe Humano

			PropertyInfo[] properties = humanoType.GetProperties();

			Console.WriteLine("Propriedades da classe humano");
			Console.WriteLine(System.Environment.NewLine);

			foreach (var propertyInfo in properties)
			{
				Console.WriteLine(propertyInfo);
			}

			#endregion

			Console.WriteLine(new string('*', 80));

			#region Capturando uma propriedade não setada

			object newHuman = Activator.CreateInstance(humanoType);

			PropertyInfo property = humanoType.GetProperty("Idade");
			Console.WriteLine("Idade: {0}", property.GetValue(newHuman, null));

			property.SetValue(newHuman, 10, null);
			Console.WriteLine("Idade: {0}", property.GetValue(newHuman, null));
			#endregion

			Console.WriteLine(new string('*', 80));

			#region Chamando métodos

			object classInstance = Activator.CreateInstance(humanoType, null);

			var metodoPensarAlgo = humanoType.GetMethod("PensarAlgo");
			metodoPensarAlgo.Invoke(classInstance, new object[] { "C#", DateTime.Now });

			var metodoPiscar = humanoType.GetMethod("Respirar");
			metodoPiscar.Invoke(classInstance, null);

			#endregion

			Console.ReadKey();
		}
	}
}
