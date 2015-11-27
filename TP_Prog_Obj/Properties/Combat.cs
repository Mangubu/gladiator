using System;

namespace TP_Prog_Obj
{
	public class Combat
	{
		const int MAX_NB_EQUIPEMENT = 3;
		const int MAX_NB_GLADIATOR = 3;

		private Gladiator _gladiator1;
		public Gladiator gladiator1 {
			get {
				return _gladiator1;
			}
			set {
				_gladiator1 = value;
			}
		}

		private Gladiator _gladiator2;
		public Gladiator gladiator2 {
			get {
				return _gladiator2;
			}
			set {
				_gladiator2 = value;
			}
		}

		public Combat ()
		{
		}

		public void fight(){

			gladiator1.NbMatch++;
			gladiator2.NbMatch++;

			if (gladiator1.lstEquipement.Count < 3 && gladiator2.lstEquipement.Count < 3) {

				var error = "Veuillez vérifier que les gladiators possèdent bien " + MAX_NB_GLADIATOR + " equipements.";
				Log.Erreur (error);
			}
			else if (gladiator1.lstEquipement.Count < 3) {

				var error = "Veuillez vérifier que votre " + gladiator1.nom + " possède bien " + MAX_NB_GLADIATOR + " equipements.";
				Log.Erreur (error);
			} else if (gladiator2.lstEquipement.Count < 3) {

				var error = "Veuillez vérifier que votre " + gladiator2.nom + " possède bien " + MAX_NB_GLADIATOR + " equipements.";
				Log.Erreur (error);
			} else {

				//LE PREMIER GLADIATOR ATTAQUE//
				if (gladiator1.lstEquipement [0].niveaux < gladiator2.lstEquipement [0].niveaux) 
				{
					if (gladiator1.attack (gladiator1.lstEquipement [0])) 
					{
						string mort1_1 = gladiator1.nom + " Attaque avec " + gladiator1.lstEquipement [0].name;
						Log.Mort (mort1_1);
						if (gladiator2.defense (gladiator2.lstEquipement [0])) 
						{
							if (gladiator2.attack (gladiator2.lstEquipement [1])) 
							{
								string mort1_2 = gladiator2.nom + " Attaque avec " + gladiator2.lstEquipement [1].name;
								Log.Mort (mort1_2);
								if (gladiator1.defense (gladiator1.lstEquipement [1])) 
								{
									if (gladiator1.attack (gladiator1.lstEquipement [2])) 
									{
										string mort1_3 = gladiator1.nom + " Attaque avec " + gladiator1.lstEquipement [2].name;
										Log.Mort (mort1_3);
									}
									else 
									{
										string rate = gladiator1.nom + " rate sa troisieme attaque";
										Log.Mort (rate);
										string succes = gladiator2.nom + " survécu à " + gladiator1.nom;
										Log.Mort (succes);
										if (gladiator2.attack (gladiator2.lstEquipement [2])) 
										{
											
											
										}
										else 
										{
											string rate2 = gladiator2.nom + " rate sa troisieme attaque";
											Log.Mort (rate2);
											string succes2 = gladiator2.nom + " et " + gladiator1.nom + " ont fait un match nul";
											Log.Mort (succes2);
											gladiator2.NbMatchG++;
											gladiator1.NbMatchP++;
										}
									}
								}
								else 
								{
									string defaite = gladiator1.nom + " n'est pas parvenue à ce défendre et a donc été éliminé";
									Log.Mort (defaite);
									gladiator2.NbMatchG++;
									gladiator1.NbMatchP++;
								}
							} 
							else 
							{
								string rate = gladiator2.nom + " rate sa troisieme attaque";
								Log.Mort (rate);

								if (gladiator1.attack (gladiator1.lstEquipement [1])) {
									string mort3_1 = gladiator1.nom + " Attaque avec " + gladiator1.lstEquipement [1].name;
									Log.Mort (mort3_1);


								} else 
								{
									string rate2 = gladiator1.nom + " rate sa troisieme attaque";
									Log.Mort (rate2);
								}
							}
						} 
						else 
						{
							string defaite = gladiator2.nom + " n'est pas parvenue à ce défendre et a donc été éliminé";
							Log.Mort (defaite);
							gladiator1.NbMatchG++;
							gladiator2.NbMatchP++;
						}
					} 
					else 
					{
						string rate2 = gladiator1.nom + " rate sa première attaque";
						Log.Mort (rate2);

						if (gladiator2.attack (gladiator2.lstEquipement [0])) 
						{
							string mort2_1 = gladiator2.nom + " Attaque avec " + gladiator2.lstEquipement [0].name;
							Log.Mort (mort2_1);
							string attaque = gladiator2.nom + " attaque.";
							Log.Attaque (attaque);
							if (gladiator1.defense (gladiator1.lstEquipement [1])) 
							{
								if (gladiator1.attack (gladiator1.lstEquipement [2])) 
								{
									string mort2_2 = gladiator1.nom + " Attaque avec " + gladiator1.lstEquipement [2].name;
									Log.Mort (mort2_2);
									if (gladiator2.defense (gladiator1.lstEquipement [1])) 
									{
										if (gladiator2.attack (gladiator2.lstEquipement [2])) 
										{
											string mort2_3 = gladiator2.nom + " Attaque avec " + gladiator2.lstEquipement [2].name;
											Log.Mort (mort2_3);
											string defaite = gladiator1.nom + " n'est pas parvenue à ce défendre et a donc été éliminé";
											Log.Mort (defaite);
											gladiator2.NbMatchG++;
											gladiator1.NbMatchP++;
										}	
										else
										{
											string succes2 = gladiator1.nom + " et " + gladiator1.nom + " ont fait un match nul";
											Log.Mort (succes2);
											gladiator2.NbMatchG++;
											gladiator2.NbMatchP++;
											gladiator1.NbMatchG++;
											gladiator1.NbMatchP++;
										}
									}
									else
									{
										string defaite = gladiator2.nom + " n'est pas parvenue à ce défendre et a donc été éliminé";
										Log.Mort (defaite);
										gladiator2.NbMatchG++;
										gladiator1.NbMatchP++;
									}
								}
								else
								{
									string rate = gladiator1.nom + " rate sa troisieme attaque";
									Log.Mort (rate);

									if (gladiator2.defense (gladiator1.lstEquipement [1])) 
									{
										if (gladiator2.attack (gladiator2.lstEquipement [2])) 
										{
											string mort2_3 = gladiator2.nom + " Attaque avec " + gladiator2.lstEquipement [2].name;
											Log.Mort (mort2_3);
											string defaite = gladiator1.nom + " n'est pas parvenue à ce défendre et a donc été éliminé";
											Log.Mort (defaite);
											gladiator2.NbMatchG++;
											gladiator1.NbMatchP++;
										}	
										else
										{
											string succes2 = gladiator1.nom + " et " + gladiator1.nom + " ont fait un match nul";
											Log.Mort (succes2);
											gladiator2.NbMatchG++;
											gladiator2.NbMatchP++;
											gladiator1.NbMatchG++;
											gladiator1.NbMatchP++;
										}
									}
									else
									{
										string defaite = gladiator2.nom + " n'est pas parvenue à ce défendre et a donc été éliminé";
										Log.Mort (defaite);
										gladiator2.NbMatchG++;
										gladiator1.NbMatchP++;
									}
								}
							} 
							else 
							{
								string defaite = gladiator1.nom + " n'est pas parvenue à ce défendre et a donc été éliminé";
								Log.Mort (defaite);
								gladiator2.NbMatchG++;
								gladiator1.NbMatchP++;
							}
						}
						else
						{
							if (gladiator1.attack (gladiator1.lstEquipement [1])) 
							{

							} 
							else 
							{
								string rate = gladiator1.nom + " rate sa deuxieme attaque";
								Log.Mort (rate);

								if (gladiator2.attack (gladiator2.lstEquipement [1])) 
								{

								}
								else{
									string rate3 = gladiator2.nom + " rate sa deuxieme attaque";
									Log.Mort (rate3);

									if (gladiator1.attack (gladiator1.lstEquipement [2])) 
									{

									}
									else
									{
										string rate4 = gladiator1.nom + " rate sa troisieme attaque";
										Log.Mort (rate4);
										string succes = gladiator2.nom + " survécu à " + gladiator1.nom;
										Log.Mort (succes);

										if (gladiator2.attack (gladiator2.lstEquipement [2])) 
										{
											string defaite = gladiator1.nom + " n'est pas parvenue à ce défendre et a donc été éliminé";
											Log.Mort (defaite);
											gladiator2.NbMatchG++;
											gladiator1.NbMatchP++;
										}
										else 
										{
											string succes2 = gladiator1.nom + " et " + gladiator1.nom + " ont fait un match nul";
											Log.Mort (succes2);
											gladiator2.NbMatchG++;
											gladiator2.NbMatchP++;
											gladiator1.NbMatchG++;
											gladiator1.NbMatchP++;
										}

									}
								}
							}
						}
					}
				}



				//LE SECOND GLADIATOR ATTAQUE//
				else if (gladiator2.lstEquipement [0].niveaux < gladiator1.lstEquipement [0].niveaux) 
				{
					if (gladiator2.attack (gladiator2.lstEquipement [0])) 
					{
						string mort1_1 = gladiator2.nom + " Attaque avec " + gladiator2.lstEquipement [0].name;
						Log.Mort (mort1_1);
						if (gladiator1.defense (gladiator1.lstEquipement [0])) 
						{
							if (gladiator1.attack (gladiator1.lstEquipement [1])) 
							{
								string mort1_2 = gladiator1.nom + " Attaque avec " + gladiator1.lstEquipement [1].name;
								Log.Mort (mort1_2);
								if (gladiator2.defense (gladiator2.lstEquipement [1])) 
								{
									if (gladiator2.attack (gladiator2.lstEquipement [2])) 
									{
										string mort1_3 = gladiator2.nom + " Attaque avec " + gladiator2.lstEquipement [2].name;
										Log.Mort (mort1_3);
									}
									else 
									{
										string rate = gladiator2.nom + " rate sa troisieme attaque";
										Log.Mort (rate);
										string succes = gladiator1.nom + " survécu à " + gladiator2.nom;
										Log.Mort (succes);
										if (gladiator1.attack (gladiator1.lstEquipement [2])) 
										{


										}
										else 
										{
											string rate2 = gladiator1.nom + " rate sa troisieme attaque";
											Log.Mort (rate2);
											string succes2 = gladiator1.nom + " et " + gladiator2.nom + " ont fait un match nul";
											Log.Mort (succes2);
											gladiator2.NbMatchG++;
											gladiator1.NbMatchP++;
										}
									}
								}
								else 
								{
									string defaite = gladiator2.nom + " n'est pas parvenue à ce défendre et a donc été éliminé";
									Log.Mort (defaite);
									gladiator2.NbMatchG++;
									gladiator1.NbMatchP++;
								}
							} 
							else 
							{
								string rate = gladiator1.nom + " rate sa troisieme attaque";
								Log.Mort (rate);

								if (gladiator1.attack (gladiator2.lstEquipement [1])) {
									string mort3_1 = gladiator2.nom + " Attaque avec " + gladiator2.lstEquipement [1].name;
									Log.Mort (mort3_1);


								} else 
								{
									string rate1 = gladiator2.nom + " rate sa troisieme attaque";
									Log.Mort (rate1);
								}
							}
						} 
						else 
						{
							string defaite = gladiator1.nom + " n'est pas parvenue à ce défendre et a donc été éliminé";
							Log.Mort (defaite);
							gladiator1.NbMatchG++;
							gladiator2.NbMatchP++;
						}
					} 
					else 
					{
						if (gladiator2.attack (gladiator1.lstEquipement [0])) 
						{
							string mort2_1 = gladiator1.nom + " Attaque avec " + gladiator1.lstEquipement [0].name;
							Log.Mort (mort2_1);
							string attaque = gladiator1.nom + " attaque.";
							Log.Attaque (attaque);
							if (gladiator1.defense (gladiator2.lstEquipement [1])) 
							{
								if (gladiator1.attack (gladiator2.lstEquipement [2])) 
								{
									string mort2_2 = gladiator2.nom + " Attaque avec " + gladiator2.lstEquipement [2].name;
									Log.Mort (mort2_2);
									if (gladiator1.defense (gladiator2.lstEquipement [1])) 
									{
										if (gladiator1.attack (gladiator1.lstEquipement [2])) 
										{
											string mort2_3 = gladiator1.nom + " Attaque avec " + gladiator1.lstEquipement [2].name;
											Log.Mort (mort2_3);
											string defaite = gladiator2.nom + " n'est pas parvenue à ce défendre et a donc été éliminé";
											Log.Mort (defaite);
											gladiator2.NbMatchG++;
											gladiator1.NbMatchP++;
										}	
										else
										{
											string succes2 = gladiator2.nom + " et " + gladiator2.nom + " ont fait un match nul";
											Log.Mort (succes2);
											gladiator2.NbMatchG++;
											gladiator2.NbMatchP++;
											gladiator1.NbMatchG++;
											gladiator1.NbMatchP++;
										}
									}
									else
									{
										string defaite = gladiator1.nom + " n'est pas parvenue à ce défendre et a donc été éliminé";
										Log.Mort (defaite);
										gladiator2.NbMatchG++;
										gladiator1.NbMatchP++;
									}
								}
								else
								{
									string rate = gladiator2.nom + " rate sa troisieme attaque";
									Log.Mort (rate);

									if (gladiator1.defense (gladiator2.lstEquipement [1])) 
									{
										if (gladiator1.attack (gladiator1.lstEquipement [2])) 
										{
											string mort2_3 = gladiator1.nom + " Attaque avec " + gladiator1.lstEquipement [2].name;
											Log.Mort (mort2_3);
											string defaite = gladiator2.nom + " n'est pas parvenue à ce défendre et a donc été éliminé";
											Log.Mort (defaite);
											gladiator2.NbMatchG++;
											gladiator1.NbMatchP++;
										}	
										else
										{
											string succes2 = gladiator2.nom + " et " + gladiator2.nom + " ont fait un match nul";
											Log.Mort (succes2);
											gladiator2.NbMatchG++;
											gladiator2.NbMatchP++;
											gladiator1.NbMatchG++;
											gladiator1.NbMatchP++;
										}
									}
									else
									{
										string defaite = gladiator1.nom + " n'est pas parvenue à ce défendre et a donc été éliminé";
										Log.Mort (defaite);
										gladiator2.NbMatchG++;
										gladiator1.NbMatchP++;
									}
								}
							} 
							else 
							{
								string defaite = gladiator2.nom + " n'est pas parvenue à ce défendre et a donc été éliminé";
								Log.Mort (defaite);
								gladiator2.NbMatchG++;
								gladiator1.NbMatchP++;
							}
						}
						else
						{
							if (gladiator2.attack (gladiator2.lstEquipement [1])) 
							{

							} 
							else 
							{
								string rate = gladiator2.nom + " rate sa deuxieme attaque";
								Log.Mort (rate);

								if (gladiator1.attack (gladiator1.lstEquipement [1])) 
								{

								}
								else{
									string rate2 = gladiator1.nom + " rate sa deuxieme attaque";
									Log.Mort (rate2);

									if (gladiator2.attack (gladiator2.lstEquipement [2])) 
									{

									}
									else
									{
										string rate3 = gladiator2.nom + " rate sa troisieme attaque";
										Log.Mort (rate2);
										string succes = gladiator1.nom + " survécu à " + gladiator2.nom;
										Log.Mort (succes);

										if (gladiator1.attack (gladiator1.lstEquipement [2])) 
										{
											string defaite = gladiator2.nom + " n'est pas parvenue à ce défendre et a donc été éliminé";
											Log.Mort (defaite);
											gladiator2.NbMatchG++;
											gladiator1.NbMatchP++;
										}
										else 
										{
											string succes2 = gladiator2.nom + " et " + gladiator2.nom + " ont fait un match nul";
											Log.Mort (succes2);
											gladiator2.NbMatchG++;
											gladiator2.NbMatchP++;
											gladiator1.NbMatchG++;
											gladiator1.NbMatchP++;
										}

									}
								}
							}
						}
					}
				}
				else 
				{


					//LE PREMIER GLADIATOR ATTAQUE//

					// le premier gladiator attaque avec sa première arme (tour 1)
					if (gladiator1.attack (gladiator1.lstEquipement [0])) 
					{
						string mort1_1 = gladiator1.nom + " Attaque avec " + gladiator1.lstEquipement [0].name;
						Log.Mort (mort1_1);
						// le deuxieme gladiators se defend avec ça première arme (tour 1) 
						if (gladiator2.defense (gladiator2.lstEquipement [0])) 
						{
							string mort1_2 = gladiator2.nom + " a contré avec " + gladiator2.lstEquipement [0].name;
							Log.Mort (mort1_2); 
							// le premier gladiator attaque avec sa deuxieme arme (tour 2)
							if (gladiator1.attack (gladiator1.lstEquipement [1])) 
							{
								string mort1_3 = gladiator1.nom + " Attaque avec " + gladiator1.lstEquipement [1].name;
								Log.Mort (mort1_3);
								// le deuxieme gladiators se defend avec ça deuxieme arme (tour 2) 
								if (gladiator2.defense (gladiator2.lstEquipement [1])) 
								{
									string mort1_4 = gladiator2.nom + " a contré avec " + gladiator2.lstEquipement [1].name;
									Log.Mort (mort1_4);
									// le premier gladiator attaque avec sa troisième arme (tour 3)
									if (gladiator1.attack (gladiator1.lstEquipement [2])) 
									{
										string mort1_5 = gladiator1.nom + " Attaque avec " + gladiator1.lstEquipement [2].name;
										Log.Mort (mort1_5);
										if (gladiator2.defense (gladiator2.lstEquipement [0])) 
										{
											string mort1_6 = gladiator2.nom + " a contré avec " + gladiator2.lstEquipement [2].name;
											Log.Mort (mort1_6);
											string succes = gladiator2.nom + " survécu à " + gladiator1.nom;
											Log.Mort (succes);
										}
										// Si le deuxième gladiator ne parvient pas à ce défendre (tour 3)
										else 
										{
											string defaite1_3 = gladiator2.nom + " n'est pas parvenue à ce défendre et a donc été éliminé";
											Log.Mort (defaite1_3);
											gladiator1.NbMatchG++;
											gladiator2.NbMatchP++;
										}
									}
									//Si le premier gladiator rate son attaque
									else 
									{
										string rate1_3 = gladiator1.nom + " rate sa troisieme attaque";
										Log.Mort (rate1_3);
										string succes = gladiator2.nom + " survécu à " + gladiator1.nom;
										Log.Mort (succes);
										gladiator1.NbMatchG++;
									}
								}
								// Si le deuxième gladiator ne parvient pas à ce défendre (tour 2)
								else {
									string defaite1_2 = gladiator2.nom + " n'est pas parvenue à ce défendre et a donc été éliminé";
									Log.Mort (defaite1_2);
									gladiator1.NbMatchG++;
									gladiator2.NbMatchP++;
								}
							}
							//Si le premier gladiator rate son attaque ( tour 2 )
							else {
								string rate1_2 = gladiator1.nom + " rate sa deuxieme attaque";
								Log.Mort (rate1_2);
								// Le gladiator attaque avec ca troisième arme ( tour 3 )
								if (gladiator1.attack (gladiator1.lstEquipement [2])) 
								{
									string mort3_1 = gladiator1.nom + " Attaque avec " + gladiator1.lstEquipement [1].name;
									Log.Mort (mort3_1);
									// le deuxieme gladiators se defend avec ça deuxieme arme (tour 3) 
									if (gladiator2.defense (gladiator2.lstEquipement [1])) {
										string mort3_3 = gladiator2.nom + " a contré avec " + gladiator2.lstEquipement [0].name;
										Log.Mort (mort3_3);
										string succes = gladiator2.nom + " survécu à " + gladiator1.nom;
										Log.Mort (succes);
										gladiator1.NbMatchG++;
									} 
									else 
									{
										string defaite3_1 = gladiator2.nom + " n'est pas parvenue à ce défendre et a donc été éliminé";
										Log.Mort (defaite3_1);
										gladiator1.NbMatchG++;
										gladiator2.NbMatchP++;
									}
								}
								//Si le premier gladiator rate son attaque
								else 
								{
									string rate3_3 = gladiator1.nom + " rate sa troisieme attaque";
									Log.Mort (rate3_3);
									string succes = gladiator2.nom + " survécu à " + gladiator1.nom;
									Log.Mort (succes);
									gladiator1.NbMatchG++;
								}

									
							}
						} 
						// Si le deuxième gladiator ne parvient pas à ce défendre (tour 1)
						else {
							string defaite1_1 = gladiator2.nom + " n'est pas parvenue à ce défendre et a donc été éliminé";
							Log.Mort (defaite1_1);
							gladiator1.NbMatchG++;
							gladiator2.NbMatchP++;
						}
					} 
					//Si le premier gladiator rate son attaque (tour 1)
					else 
					{
						string rate1_1 = gladiator1.nom + " rate sa premiere attaque";
						Log.Mort (rate1_1);
						// Le gladiator attaque avec ca deuxième arme ( tour 2 )
						if (gladiator1.attack (gladiator1.lstEquipement [1])) 
						{
							string mort2_1 = gladiator1.nom + " Attaque avec " + gladiator1.lstEquipement [1].name;
							Log.Mort (mort2_1);
							// le deuxieme gladiators se defend avec ça première arme (tour 2) 
							if (gladiator2.defense (gladiator2.lstEquipement [0])) 
							{
								string mort2_2 = gladiator2.nom + " a contré avec " + gladiator2.lstEquipement [0].name;
								Log.Mort (mort2_2); 
								// Le gladiator attaque avec ca troisième arme ( tour 3 )
								if (gladiator1.attack (gladiator1.lstEquipement [2])) 
								{
									string mort2_3 = gladiator1.nom + " Attaque avec " + gladiator1.lstEquipement [1].name;
									Log.Mort (mort2_3);
									// le deuxieme gladiators se defend avec ça deuxieme arme (tour 3) 
									if (gladiator2.defense (gladiator2.lstEquipement [1])) {
										string mort2_4 = gladiator2.nom + " a contré avec " + gladiator2.lstEquipement [0].name;
										Log.Mort (mort2_4);
										string succes = gladiator2.nom + " survécu à " + gladiator1.nom;
										Log.Mort (succes);
										gladiator1.NbMatchG++;
									} 
									else 
									{
										string defaite2_1 = gladiator2.nom + " n'est pas parvenue à ce défendre et a donc été éliminé";
										Log.Mort (defaite2_1);
										gladiator1.NbMatchG++;
										gladiator2.NbMatchP++;
									}

								}
								//Si le premier gladiator rate son attaque ( tour 2)
								else 
								{
									string rate3_1 = gladiator1.nom + " rate sa troisième attaque";
									Log.Mort (rate3_1);
									gladiator2.NbMatchG++;
									string succes = gladiator2.nom + " survécu à " + gladiator1.nom;
									Log.Mort (succes);

								}
							}
							else 
							{
								string defaite2_2 = gladiator2.nom + " n'est pas parvenue à ce défendre et a donc été éliminé";
								Log.Mort (defaite2_2);
								gladiator1.NbMatchG++;
								gladiator2.NbMatchP++;
							}

						}
						//Si le premier gladiator rate son attaque (tour 3)
						else 
						{
							string rate2_1 = gladiator1.nom + " rate sa deuxieme attaque";
							Log.Mort (rate2_1);
							// Le gladiator attaque avec ca troisième arme ( tour 3 )
							if (gladiator1.attack (gladiator1.lstEquipement [2])) 
							{
								string mort3_1 = gladiator1.nom + " Attaque avec " + gladiator1.lstEquipement [1].name;
								Log.Mort (mort3_1);
								// le deuxieme gladiators se defend avec ça deuxieme arme (tour 3) 
								if (gladiator2.defense (gladiator2.lstEquipement [1])) {
									string mort3_3 = gladiator2.nom + " a contré avec " + gladiator2.lstEquipement [0].name;
									Log.Mort (mort3_3);
									string succes = gladiator2.nom + " survécu à " + gladiator1.nom;
									Log.Mort (succes);
									gladiator1.NbMatchG++;
								} 
								else 
								{
									string defaite3_1 = gladiator2.nom + " n'est pas parvenue à ce défendre et a donc été éliminé";
									Log.Mort (defaite3_1);
									gladiator1.NbMatchG++;
									gladiator2.NbMatchP++;
								}
							}
							//Si le premier gladiator rate son attaque
							else 
							{
								string rate3_3 = gladiator1.nom + " rate sa troisieme attaque";
								Log.Mort (rate3_3);
								string succes = gladiator2.nom + " survécu à " + gladiator1.nom;
								Log.Mort (succes);
								gladiator1.NbMatchG++;
							}

						}

					}



					//LE DEUXIEME GLADIATOR ATTAQUE//

					// le premier gladiator attaque avec sa première arme (tour 1)
					if (gladiator2.attack (gladiator2.lstEquipement [0])) 
					{
						string mort1_1 = gladiator2.nom + " Attaque avec " + gladiator2.lstEquipement [0].name;
						Log.Mort (mort1_1);
						// le deuxieme gladiators se defend avec ça première arme (tour 1) 
						if (gladiator1.defense (gladiator1.lstEquipement [0])) 
						{
							string mort1_2 = gladiator1.nom + " a contré avec " + gladiator1.lstEquipement [0].name;
							Log.Mort (mort1_2); 
							// le premier gladiator attaque avec sa deuxieme arme (tour 2)
							if (gladiator2.attack (gladiator2.lstEquipement [1])) 
							{
								string mort1_3 = gladiator2.nom + " Attaque avec " + gladiator2.lstEquipement [1].name;
								Log.Mort (mort1_3);
								// le deuxieme gladiators se defend avec ça deuxieme arme (tour 2) 
								if (gladiator1.defense (gladiator1.lstEquipement [1])) 
								{
									string mort1_4 = gladiator1.nom + " a contré avec " + gladiator1.lstEquipement [1].name;
									Log.Mort (mort1_4);
									// le premier gladiator attaque avec sa troisième arme (tour 3)
									if (gladiator2.attack (gladiator2.lstEquipement [2])) 
									{
										string mort1_5 = gladiator2.nom + " Attaque avec " + gladiator2.lstEquipement [2].name;
										Log.Mort (mort1_5);
										if (gladiator1.defense (gladiator1.lstEquipement [0])) 
										{
											string mort1_6 = gladiator1.nom + " a contré avec " + gladiator1.lstEquipement [2].name;
											Log.Mort (mort1_6);
											string succes = gladiator1.nom + " survécu à " + gladiator2.nom;
											Log.Mort (succes);
										}
										// Si le deuxième gladiator ne parvient pas à ce défendre (tour 3)
										else 
										{
											string defaite1_3 = gladiator1.nom + " n'est pas parvenue à ce défendre et a donc été éliminé";
											Log.Mort (defaite1_3);
											gladiator1.NbMatchG++;
											gladiator2.NbMatchP++;
										}
									}
									//Si le premier gladiator rate son attaque
									else 
									{
										string rate1_3 = gladiator2.nom + " rate sa troisieme attaque";
										Log.Mort (rate1_3);
										string succes = gladiator1.nom + " survécu à " + gladiator2.nom;
										Log.Mort (succes);
										gladiator1.NbMatchG++;
									}
								}
								// Si le deuxième gladiator ne parvient pas à ce défendre (tour 2)
								else {
									string defaite1_2 = gladiator1.nom + " n'est pas parvenue à ce défendre et a donc été éliminé";
									Log.Mort (defaite1_2);
									gladiator1.NbMatchG++;
									gladiator2.NbMatchP++;
								}
							}
							//Si le premier gladiator rate son attaque ( tour 2 )
							else {
								string rate1_2 = gladiator2.nom + " rate sa deuxieme attaque";
								Log.Mort (rate1_2);
								// Le gladiator attaque avec ca troisième arme ( tour 3 )
								if (gladiator2.attack (gladiator2.lstEquipement [2])) 
								{
									string mort3_1 = gladiator2.nom + " Attaque avec " + gladiator2.lstEquipement [1].name;
									Log.Mort (mort3_1);
									// le deuxieme gladiators se defend avec ça deuxieme arme (tour 3) 
									if (gladiator1.defense (gladiator1.lstEquipement [1])) {
										string mort3_3 = gladiator1.nom + " a contré avec " + gladiator1.lstEquipement [0].name;
										Log.Mort (mort3_3);
										string succes = gladiator1.nom + " survécu à " + gladiator2.nom;
										Log.Mort (succes);
										gladiator1.NbMatchG++;
									} 
									else 
									{
										string defaite3_1 = gladiator1.nom + " n'est pas parvenue à ce défendre et a donc été éliminé";
										Log.Mort (defaite3_1);
										gladiator1.NbMatchG++;
										gladiator2.NbMatchP++;
									}
								}
								//Si le premier gladiator rate son attaque
								else 
								{
									string rate3_3 = gladiator2.nom + " rate sa troisieme attaque";
									Log.Mort (rate3_3);
									string succes = gladiator1.nom + " survécu à " + gladiator2.nom;
									Log.Mort (succes);
									gladiator1.NbMatchG++;
								}


							}
						} 
						// Si le deuxième gladiator ne parvient pas à ce défendre (tour 1)
						else {
							string defaite1_1 = gladiator1.nom + " n'est pas parvenue à ce défendre et a donc été éliminé";
							Log.Mort (defaite1_1);
							gladiator1.NbMatchG++;
							gladiator2.NbMatchP++;
						}
					} 
					//Si le premier gladiator rate son attaque (tour 1)
					else 
					{
						string rate1_1 = gladiator2.nom + " rate sa premiere attaque";
						Log.Mort (rate1_1);
						// Le gladiator attaque avec ca deuxième arme ( tour 2 )
						if (gladiator2.attack (gladiator2.lstEquipement [1])) 
						{
							string mort2_1 = gladiator2.nom + " Attaque avec " + gladiator2.lstEquipement [1].name;
							Log.Mort (mort2_1);
							// le deuxieme gladiators se defend avec ça première arme (tour 2) 
							if (gladiator1.defense (gladiator1.lstEquipement [0])) 
							{
								string mort2_2 = gladiator1.nom + " a contré avec " + gladiator1.lstEquipement [0].name;
								Log.Mort (mort2_2); 
								// Le gladiator attaque avec ca troisième arme ( tour 3 )
								if (gladiator2.attack (gladiator2.lstEquipement [2])) 
								{
									string mort2_3 = gladiator2.nom + " Attaque avec " + gladiator2.lstEquipement [1].name;
									Log.Mort (mort2_3);
									// le deuxieme gladiators se defend avec ça deuxieme arme (tour 3) 
									if (gladiator1.defense (gladiator1.lstEquipement [1])) {
										string mort2_4 = gladiator1.nom + " a contré avec " + gladiator1.lstEquipement [0].name;
										Log.Mort (mort2_4);
										string succes = gladiator1.nom + " survécu à " + gladiator2.nom;
										Log.Mort (succes);
										gladiator1.NbMatchG++;
									} 
									else 
									{
										string defaite2_1 = gladiator1.nom + " n'est pas parvenue à ce défendre et a donc été éliminé";
										Log.Mort (defaite2_1);
										gladiator1.NbMatchG++;
										gladiator2.NbMatchP++;
									}

								}
								//Si le premier gladiator rate son attaque ( tour 2)
								else 
								{
									string rate3_1 = gladiator2.nom + " rate sa troisième attaque";
									Log.Mort (rate3_1);
									gladiator2.NbMatchG++;
									string succes = gladiator1.nom + " survécu à " + gladiator2.nom;
									Log.Mort (succes);

								}
							}
							else 
							{
								string defaite2_2 = gladiator1.nom + " n'est pas parvenue à ce défendre et a donc été éliminé";
								Log.Mort (defaite2_2);
								gladiator1.NbMatchG++;
								gladiator2.NbMatchP++;
							}

						}
						//Si le premier gladiator rate son attaque (tour 3)
						else 
						{
							string rate2_1 = gladiator2.nom + " rate sa deuxieme attaque";
							Log.Mort (rate2_1);
							// Le gladiator attaque avec ca troisième arme ( tour 3 )
							if (gladiator1.attack (gladiator2.lstEquipement [2])) 
							{
								string mort3_1 = gladiator2.nom + " Attaque avec " + gladiator2.lstEquipement [1].name;
								Log.Mort (mort3_1);
								// le deuxieme gladiators se defend avec ça deuxieme arme (tour 3) 
								if (gladiator1.defense (gladiator1.lstEquipement [1])) {
									string mort3_3 = gladiator1.nom + " a contré avec " + gladiator1.lstEquipement [0].name;
									Log.Mort (mort3_3);
									string succes = gladiator1.nom + " survécu à " + gladiator2.nom;
									Log.Mort (succes);
									gladiator1.NbMatchG++;
								} 
								else 
								{
									string defaite3_1 = gladiator1.nom + " n'est pas parvenue à ce défendre et a donc été éliminé";
									Log.Mort (defaite3_1);
									gladiator1.NbMatchG++;
									gladiator2.NbMatchP++;
								}
							}
							//Si le premier gladiator rate son attaque
							else 
							{
								string rate3_3 = gladiator2.nom + " rate sa troisieme attaque";
								Log.Mort (rate3_3);
								string succes = gladiator1.nom + " survécu à " + gladiator2.nom;
								Log.Mort (succes);
								gladiator1.NbMatchG++;
							}

						}

					}
					string end = "Fin du combat";
					Log.Mort (end);
				}
			}
		}
	}
}

