﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KELLERGRH2020
{
    public class Collaborateur
    {

        private int lId;
        private string leNom;
        private string lePrenom;
        private string lAdresse;
        private string leCp;
        private string laVille;
        private DateTime laDateEmbauche;
		private List<Poste> lesPostes;


		public Collaborateur()
        {
        }

        public Collaborateur(int unId, string unNom, string unPrenom, string uneAdresse, string unCp, string uneVille, DateTime uneDateEmbauche)
        {
			lId = unId;
			leNom = unNom;
			lePrenom = unPrenom;
			lAdresse = uneAdresse;
			leCp = unCp;
			laVille = uneVille;
			laDateEmbauche = uneDateEmbauche;
			lesPostes = new List<Poste>();
		}



        public int Id
        {
            get { return lId; }
            set { lId = value; }
        }


        public string Nom
        {
            get { return leNom; }
            set
            { leNom = value; }
        }

        public string Prenom
        {
            get { return lePrenom; }
            set
            { lePrenom = value; }
        }

        public string Adresse
        {
            get { return lAdresse; }
            set
            { lAdresse = value; }
        }

        public string Cp
        {
            get { return leCp; }
            set
            { leCp = value; }
        }

        public string Ville
        {
            get { return laVille; }
            set
            { laVille = value; }
        }

        public DateTime DateEmbauche
        {
            get { return laDateEmbauche; }
            set
            { laDateEmbauche = value; }
        }

		public List<Poste> Postes
		{
			get { return lesPostes; }
			set
			{
				lesPostes = value;
			}
		}

	}
}
