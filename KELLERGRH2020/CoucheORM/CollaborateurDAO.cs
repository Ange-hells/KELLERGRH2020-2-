using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;  // pour connection state
using System.Windows.Forms;

namespace KELLERGRH2020
{
    public static class CollaborateurDAO
    {

		private static List<Collaborateur> lesCollaborateurs;
		public static List<Collaborateur> getCollaborateurs()
		{
			if (lesCollaborateurs == null)
			{
				List<Collaborateur> lesCollaborateurs = new List<Collaborateur>();
				List<Role> lesRoles = RoleDAO.getRoles();
				List<Secteur> lesSecteurs = SecteurDAO.getSecteurs();
				List<Region> lesRegions = RegionDAO.getRegions();


				Collaborateur unCollaborateur;
				SqlConnection ctn = new SqlConnection(Connexion.getChaine());
				ctn.Open();
				string req = "select * from COLLABORATEUR";
				SqlCommand cmd = new SqlCommand(req, ctn);
				SqlDataReader jeu = cmd.ExecuteReader();
				while (jeu.Read())
				{
					unCollaborateur = new Collaborateur(int.Parse(jeu[0].ToString()), jeu[1].ToString(), jeu[2].ToString(), jeu[3].ToString(), jeu[4].ToString(), jeu[5].ToString(), DateTime.Parse(jeu[6].ToString()));
					lesCollaborateurs.Add(unCollaborateur);
				}
				jeu.Close();

				// TODO : Ajouter les postes à l'objet unCollaborateur

				string req2 = "SELECT * FROM Poste ORDER BY Id_Collaborateur ASC, DateDebutPoste DESC";
				cmd = new SqlCommand(req2, ctn);
				jeu = cmd.ExecuteReader();

				bool continuer = jeu.Read();
				while (continuer)
				{
					int idCourant = int.Parse(jeu[0].ToString());
					Collaborateur leCollab = lesCollaborateurs.FirstOrDefault(r => r.Id = idCourant);
					while (continuer && int.Parse(jeu[0].ToString()) == idCourant)
					{
						//Poste unPoste = new Poste(DateTime.Parse(jeu[1].ToString()), ListeRole.getRoleById(int.Parse(jeu[5].ToString())));
						DateTime nul;
						if (jeu[2].ToString() == "")
						{
							nul = new DateTime(110, 5, 29, 11, 15, 0); //date fictive
						}
						else
						{
							nul = DateTime.Parse(jeu[2].ToString());
						}


						 
						DateTime test = DateTime.Parse(jeu[1].ToString());
						DateTime test2 = nul;
						Role test3 = ListeRole.getRoleById(int.Parse(jeu[5].ToString()));
						Poste unPoste = new Poste(DateTime.Parse(jeu[1].ToString()), nul, ListeRole.getRoleById(int.Parse(jeu[5].ToString())), ListeRegion.getRegionByCode(int.Parse(jeu[3].ToString())), ListeSecteurs.getSecteurByCode(int.Parse(jeu[4].ToString())));


						leCollab.Post.Add(unPoste);
						continuer = jeu.Read();
					}
				}
				jeu.Close();
				ctn.Close();

			}
            return lesCollaborateurs;
        }
    }
}
