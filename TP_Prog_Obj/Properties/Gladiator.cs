using System;
using System.Collections.Generic;

namespace TP_Prog_Obj
{
	public class Gladiator
	{

		const int MAX_NB_EQUIPEMENT = 3;
		const int MAX_NB_GLADIATOR = 3;

		private int _nbpoints = 10 ;
		public int nbpoints {
			get {
				return _nbpoints;
			}
			set {
				_nbpoints = value;
			}
		}

		//permet d'ajouer ou de retourner l'equipe du gladiator
		private Equipe _sonEquipe;
		public Equipe sonEquipe {
			get {
				return _sonEquipe;
			}
			set {
				_sonEquipe = value;
			}
		}

		private string _nom;
		public string nom {
			get {
				return _nom;
			}
			set {
				_nom = value;
			}
		}

		private static int _NB_GLADIATOR;
		public static int NB_GLADIATOR {
			get { return Gladiator._NB_GLADIATOR; }
		}

		// gestoin des equipement avec un design pattern
		protected List<ComportementEquipement> _lstEquipement = new List<ComportementEquipement> ();
		public List<ComportementEquipement> lstEquipement {
			get {
				return _lstEquipement;
			}
		}


		private int _NbMatch;
		public int NbMatch {
			get {
				return _NbMatch;
			}
			set {
				_NbMatch = value;
			}
		}


		private int _NbMatchG;
		public int NbMatchG {
			get {
				return _NbMatchG;
			}
			set {
				_NbMatchG = value;
			}
		}

		private int _NbMatchP;
		public int NbMatchP {
			get {
				return _NbMatchP;
			}                
			set {
				_NbMatchP = value;
			}
		}

		private int _getPourcentageV;
		public int getPourcentageV {
			get {
				return _getPourcentageV;
			}
			set {
				_getPourcentageV = value;
			}
		}


		public Gladiator ()
		{
			Gladiator._NB_GLADIATOR++;
		}

		public bool attack (ComportementEquipement unEquipement)
		{
			Random rand = new Random ();
				
			double precAttack = unEquipement.precAttaque;
			double prec = ((double)precAttack) / 100;
	
			//Console.WriteLine (prec);
			if (rand.NextDouble () <= prec) {
				return true;
			} else {
				return false;
			}

		}

		public bool defense (ComportementEquipement unEquipement)
		{
			Random rand = new Random ();
			double precDefense = unEquipement.precDef;
			double prec = ((double)precDefense) / 100;

			//Console.WriteLine (prec);
			if (rand.NextDouble () <= prec) {
				return true;
			} else {
				return false;
			}

		}



		// Set a team to the gladiator error if count team have more than < 3 gladiators
		public void setTeam (Equipe uneEquipe)
		{
			if (uneEquipe.lstGladiator.Count <= MAX_NB_GLADIATOR ) {
				this.sonEquipe = uneEquipe;
			} else {

				string error = "Votre equipe  a atteint son nombre maximum de gladiator";
				Log.Erreur (error);
			}
		}

		// Add gladiator in a List of gladiator and return error if count items < 5
		public void setEquipementToList (ComportementEquipement monEquipement)
		{
			if (this.nbpoints > 0) {
				if (lstEquipement.Count <= MAX_NB_EQUIPEMENT) {
				
					if (this.nbpoints < monEquipement.points) {

						string error = "Votre gladiator n'a plus suffisement de points pour acquérir un/une "+ monEquipement.name;
						Log.Erreur (error);

					} else {
						lstEquipement.Add (monEquipement);
						this.nbpoints = this.nbpoints - monEquipement.points;
					}

				} else {

					string error2 = "Votre gladiator a atteint son nombre d'equipement maximum.";
					Log.Erreur (error2);
				}
			} else {

				string error3 = "Votre gladiator n'a plus suffisement de points pour acquérir un équipement.";
				Log.Erreur (error3);
			}

		}
			
		//Show nb of gladiator in a team
		public string getNbEquipement ()
		{
			int nb_equipment = lstEquipement.Count;
			return "Il ya " + nb_equipment + " gladiator(s) dans votre equipe.";
		}
	
	}
}

