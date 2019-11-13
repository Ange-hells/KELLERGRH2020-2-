using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KELLERGRH2020
{
	public class Role
	{
		private int lId;
		private string leLibelle;

		public Role(int unId, string unLibelle)
		{
			lId = unId;
			leLibelle = unLibelle;
		}

		public int Id
		{
			get { return lId; }
			set
			{ lId = value; }
		}

		public string Libelle
		{
			get { return leLibelle; }
			set
			{ leLibelle = value; }
		}
	}
}
