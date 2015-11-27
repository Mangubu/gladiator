using System;

namespace TP_Prog_Obj
{
	public static class Log
	{
		public static void Erreur(string error)
		{
			Console.WriteLine (error);
		}

		public static void Mort(string mort)
		{
			Console.WriteLine (mort);
		}

		public static void Message(string message)
		{
			Console.WriteLine (message);
		}


		public static void Attaque(string attaque)
		{
			Console.WriteLine (attaque);
		}
	}
}

