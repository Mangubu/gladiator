using System;

namespace TP_Prog_Obj
{
	public class Competition
	{
		private Joueur _joueur1;
		public Joueur joueur1 {
			get {
				return _joueur1;
			}
			set {
				_joueur1 = value;
			}
		}
			

		private Joueur _joueur2;
		public Joueur joueur2 {
			get {
				return _joueur2;
			}
			set {
				_joueur2 = value;
			}
		}

		private Combat _combat1;
		public Combat combat1 {
			get {
				return _combat1;
			}
			set {
				_combat1 = value;
			}
		}

		private Combat _combat2;
		public Combat combat2 {
			get {
				return _combat2;
			}
			set {
				_combat2 = value;
			}
		}

		private Combat _combat3;
		public Combat combat3 {
			get {
				return _combat3;
			}
			set {
				_combat3 = value;
			}
		}

		private Combat _combat4;
		public Combat combat4 {
			get {
				return _combat4;
			}
			set {
				_combat4 = value;
			}
		}

		public Competition ()
		{
		}


	}
}

