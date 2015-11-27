using System;
using System.Collections.Generic;

namespace TP_Prog_Obj
{
	public class Joueur
	{
		const int MAX_NB_EQUIPE = 5;

		private List<Equipe> _listEquipe = new List<Equipe>();
		public List<Equipe> listEquipe {
			get {
				return _listEquipe;
			}
			set {
				_listEquipe = value;
			}
		}

		private static int _NB_EQUIPE;
		public static int NB_EQUIPE {
			get { return Joueur._NB_EQUIPE; }
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

		private string _prenom;
		public string prenom {
			get {
				return _prenom;
			}
			set {
				_prenom = value;
			}
		}

		private string _alias;
		public string alias {
			get {
				return _alias;
			}
			set {
				_alias = value;
			}
		}

		private DateTime _dateInscription;
		public DateTime dateInscription {
			get {
				return _dateInscription;
			}
			set {
				_dateInscription = value;
			}
		}

		// constructeur du joueur
		public Joueur ()
		{
			Joueur._NB_EQUIPE++;
		}
			


		// recupère une equipe similaire à l'equipe courante pour lancer le combat 
		public string combat(Joueur unJoueur)
		{
			foreach ( Equipe monequipe in this.listEquipe)
			{
				return monequipe.nom;
			} 

			foreach (Equipe sonequipe in unJoueur.listEquipe) 
			{
				return sonequipe.nom;
			}
			return "fin";
		}

		// methode d'un joueur
		public string inscrip ()
		{
			return "code pour inscrip";
		}

		// Add gladiator in a List of gladiator and return error if count items < 5
		/*public void setTeam(Equipe uneEquipe)
		{
			if (_listEquipe.Count < MAX_NB_EQUIPE) {
				_listEquipe.Add (uneEquipe);
			} else {

				string error = "Vous avez ateint le nombre d'équipe autorisé";
				Log.Erreur(error);
			}
		}*/


	}
}

