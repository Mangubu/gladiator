using System;

namespace TP_Prog_Obj
{
	public class Lance : ComportementEquipement
	{
		private string _name = "Lance";
		public string name {
			get {
				return _name;
			}
		}

		private int _points = 5;
		public int points {
			get {
				return _points;
			}
		}

		private int _niveaux = 2;
		public int niveaux {
			get {
				return _niveaux;
			}
		}

		private int _precAttaque = 50;
		public int precAttaque {
			get {
				return _precAttaque;
			}
		}

		private int _precDef = 0;
		public int precDef {
			get {
				return _precDef;
			}
		}


		public Lance ()
		{
		}

		public string equip()
		{
			return "Cette arme retire " + points + " pts de vie. Sa précision d'attaque est de : " +  precAttaque + " % et sa précision de défense est de : " + precDef + " %.";
		}
	}
}

