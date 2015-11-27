using System;
using System.Collections.Generic;

namespace TP_Prog_Obj
{
	public class Equipe
	{   
		
		const int MAX_NB_GLADIATOR = 3;
		const int MAX_NB_EQUIPE = 5;

		//permet d'ajouer ou de retourner le joueur de l'equipe
		private Joueur _sonJoeur;
		public Joueur sonJoeur {
			get {
				return _sonJoeur;
			}
			set {
				_sonJoeur = value;
			}
		}

		private List<Gladiator> _lstGladiator = new List<Gladiator>();
		public List<Gladiator> lstGladiator {
			get {
				return _lstGladiator;
			}
			/*set {
				_lstGladiator = value;
			}*/
		}

		private static int _NB_EQUIPE;
		public static int NB_EQUIPE {
			get { return Equipe._NB_EQUIPE; }
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

		private int _nbmatch = 2;
		public int nbmatch {
			get {
				return _nbmatch;
			}
			set {
				_nbmatch = value;
			}
		}

		private int _nbmatchG = 5;
		public int nbmatchG {
			get {
				return _nbmatchG;
			}
			set {
				_nbmatchG = value;
			}
		}


		private int _nbmatchP = 10;
		public int nbmatchP {
			get {
				return _nbmatchP;
			}
			set {
				_nbmatchP = value;
			}
		}

	


		private string _description;
		public string description {
			get {
				return _description;
			}
			set {
				_description = value;
			}
		}

		public Equipe()
		{
			Equipe._NB_EQUIPE++;
		}
			

		public float getPourcentageV()
		{
			float pourcentage;

			pourcentage = (float)nbmatchG/nbmatchP;
			return pourcentage ;
		}
			  

		// Set a player to the team error if count team have more than < 5 teams
		/*public void setListGlad (List<Gladiator> mesGladiators)
		{
			this.lstGladiator = mesGladiators;
		}*/

		// Set a player to the team error if count team have more than < 5 teams
		public void setPlayer (Joueur unJoueur)
		{
			if (unJoueur.listEquipe.Count < MAX_NB_EQUIPE ) {
				this.sonJoeur = unJoueur;
			} else {

				string error = "Votre joueur  a atteint son nombre maximum d'equipe";
				Log.Erreur (error);
			}
		}

			
		// Add gladiator in a List of gladiator and return error if count items < 5
		public void setGladiator(Gladiator unGladiator)
		{
			if (lstGladiator.Count < MAX_NB_GLADIATOR) {
				lstGladiator.Add (unGladiator);
			} else {

				string error = "Votre equipe est pleine";
				Log.Erreur (error);
			}
		}
			

		//Show nb of gladiator in a team
		public string getNbGladiator()
		{
			int nb_gladiator = lstGladiator.Count;
			return "Il ya " + nb_gladiator + " gladiator(s) dans votre equipe.";
		}



	}
}

