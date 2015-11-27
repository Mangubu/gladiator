using System;

namespace TP_Prog_Obj
{
	public interface ComportementEquipement
	{
		string name { get; }
		int points { get;}
		int precAttaque { get;}
		int precDef { get ;}
		int niveaux { get ;}

		string equip();
	}


}

