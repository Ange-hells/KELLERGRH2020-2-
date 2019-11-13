using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KELLERGRH2020
{
	public class Poste
	{
		private DateTime dateDebut;
		private DateTime dateFin;
		private Poste lePoste;
		private Role leRole;
		private Region laRegion;
		private Secteur leSecteur;

		public Poste(DateTime uneDateDebut, DateTime uneDateFin, Role unRole, Region uneRegion, Secteur unSecteur)
		{
			dateDebut = uneDateDebut;
			dateFin = uneDateFin;
			leRole = unRole;
			laRegion = uneRegion;
			leSecteur = unSecteur;
		}

		public Poste Postes
		{
			get { return lePoste; }
			set { lePoste = value; }
		}

		public Region Region
		{
			get { return laRegion; }
			set { laRegion = value; }
		}

		public Secteur Secteur
		{
			get { return leSecteur; }
			set { leSecteur = value; }
		}

		public DateTime dFin
		{
			get { return dateFin; }
			set { dateFin = value; }
		}
		public DateTime dateDeb
		{
			get { return dateDebut; }
			set { dateDeb = value; }
		}
		public Role Role
		{
			get { return leRole; }
			set { Role = value; }
		}
	}
}
