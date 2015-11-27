using System;

namespace TP_Prog_Obj
{
	public class Trident : ComportementEquipement
	{
		private string _name = "Trident";
		public string name {
			get {
				return _name;
			}
		}

		private int _points = 7;
		public int points {
			get {
				return _points;
			}
		}

		private int _niveaux = 3;
		public int niveaux {
			get {
				return _niveaux;
			}
		}

		private int _precAttaque = 40;
		public int precAttaque {
			get {
				return _precAttaque;
			}
		}

		private int _precDef = 10;
		public int precDef {
			get {
				return _precDef;
			}
		}


		public Trident ()
		{
			this._name = "Trident";
		}

		public string getName()
		{
			return name;
		}
		public string equip()
		{
			return "Cette arme retire " + points + " pts de vie. Sa précision d'attaque est de : " +  precAttaque + " % et sa précision de défense est de : " + precDef + " %.";
		}
	}
}

