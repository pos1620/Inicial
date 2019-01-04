/*
 * Created by SharpDevelop.
 * User: home
 * Date: 02/01/2019
 * Time: 09:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Configuration;
namespace Inicial
{
	/// <summary>
	/// Description of functions.
	/// </summary>
	public class functions
	{
		
		public static string caminho(){
			return ConfigurationManager.AppSettings["arq_db"];
		}
		
		public static void LerArquivos(String name)
		{
		
			if(File.Exists(caminho()+name)){
			//	Console.WriteLine("file was found it");
			using(StreamReader arq = File.OpenText(caminho()+name))
			{
				String ln;
				while((ln=arq.ReadLine())!=null)
					Console.WriteLine(ln);
				
			}
			}
			else
				Console.WriteLine("not found it");
		}
	}//fim classe
}//fim namespace
