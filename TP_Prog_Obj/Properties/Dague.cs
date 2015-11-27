using System;

namespace TP_Prog_Obj
{
	public class Dague : ComportementEquipement
	{

		private string _name = "Dague";
		public string name {
			get {
				return _name;
			}
		}

		private int _points = 2;
		public int points {
			get {
				return _points;
			}
		}

		private int _niveaux = 5;
		public int niveaux {
			get {
				return _niveaux;
			}
		}

		private int _precAttaque = 60;
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


		public Dague ()
		{
		}

		public string equip()
		{
			return "Cette arme retire " + points + " pts de vie. Sa précision d'attaque est de : " +  precAttaque + " % et sa précision de défense est de : " + precDef + " %.";
		}

	}
}

