using System;
using System.Collections.Generic;

namespace TP_Prog_Obj
{
	class MainClass
	{
		public static void Main (string[] args)
		{
		
			Joueur Joueur1 = new Joueur ();
			Joueur Joueur2 = new Joueur ();
			Joueur Joueur3 = new Joueur ();
			Joueur Joueur4 = new Joueur ();

			Equipe Equipe1 = new Equipe ();
			Equipe1.nom = "Equipe1";
			Equipe Equipe2 = new Equipe ();
			Equipe2.nom = "Equipe2";
			Equipe Equipe3 = new Equipe ();
			Equipe3.nom = "Equipe3";
			Equipe Equipe4 = new Equipe ();
			Equipe4.nom = "Equipe4";

			Gladiator gladiator1 = new Gladiator ();
			gladiator1.nom = "Glad1";
			Gladiator gladiator2 = new Gladiator ();
			gladiator2.nom = "Glad2";
			Gladiator gladiator3 = new Gladiator ();
			gladiator3.nom = "Glad3";
			Gladiator gladiator4 = new Gladiator ();
			gladiator4.nom = "Glad4";

		
			Joueur1.listEquipe.Add (Equipe1);
			Joueur2.listEquipe.Add (Equipe2);
			Joueur3.listEquipe.Add (Equipe3);
			Joueur4.listEquipe.Add (Equipe4);

			ComportementEquipement unPetitBouclierRond = new PetitBouclierRond ();
			ComportementEquipement uneDague = new Dague ();
			ComportementEquipement uneEpee = new Epee ();
			ComportementEquipement Trident = new Trident ();
			ComportementEquipement unBouclierRectangulaire = new BouclierRectangulaire ();
			ComportementEquipement unCasque = new Casque ();
			ComportementEquipement uneLance = new Lance ();
			ComportementEquipement unFilet = new Filet ();

			gladiator1.lstEquipement.Add (unPetitBouclierRond);
			gladiator1.lstEquipement.Add (uneDague);
			gladiator1.lstEquipement.Add (uneEpee);

			gladiator2.lstEquipement.Add (Trident);
			gladiator2.lstEquipement.Add (uneLance);
			gladiator2.lstEquipement.Add (uneEpee);

			gladiator3.lstEquipement.Add (uneDague);
			gladiator3.lstEquipement.Add (unPetitBouclierRond);
			gladiator3.lstEquipement.Add (uneEpee);

			gladiator4.lstEquipement.Add (unPetitBouclierRond);
			gladiator4.lstEquipement.Add (uneDague);
			gladiator4.lstEquipement.Add (unFilet);

			Combat unCombat = new Combat ();

			unCombat.gladiator1 = gladiator1;
			unCombat.gladiator2 = gladiator2;

			unCombat.fight ();

		}
	}
}
