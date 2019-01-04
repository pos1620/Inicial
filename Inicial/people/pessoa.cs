/*
 * Created by SharpDevelop.
 * User: home
 * Date: 29/12/2018
 * Time: 20:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace Inicial.people
{
	/// <summary>
	/// Description of pessoa.
	/// </summary>
	public class pessoa
	{
		public string nome;
		public String Nome{
			set{nome = value;}
			get{return nome;}
		}
		
		public string endereco;
		public String Endereco{
			set{nome = value;}
			get{return endereco;}
		}
		
		public string wpp;
		public String Wpp{
			set{nome = value;}
			get{return wpp;}
		}
		
		
		public void QuemSou(){
			Console.WriteLine("quem sou?:"+this.GetType());
		}
		
		public void gravar(){
	 string con="acertei!";
			if(File.Exists(functions.caminho())){
			File.WriteAllText(functions.caminho()+"db.txt","acc");
			}
		}
		
		
	}//fim classe 
}//fim namespace