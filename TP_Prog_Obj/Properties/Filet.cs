using System;

namespace TP_Prog_Obj
{
	public class Filet : ComportementEquipement
	{

		private string _name = "Filet";
		public string name {
			get {
				return _name;
			}
		}

		private int _points = 3;
		public int points {
			get {
				return _points;
			}
		}
		private int _niveaux = 1;
		public int niveaux {
			get {
				return _niveaux;
			}
		}

		private int _precAttaque = 30;
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

		public Filet ()
		{
		}

		public string equip()
		{
			return "Cette arme retire " + points + " pts de vie. Sa précision d'attaque est de : " +  precAttaque + " % et sa précision de défense est de : " + precDef + " %.";
		}

	}
}

