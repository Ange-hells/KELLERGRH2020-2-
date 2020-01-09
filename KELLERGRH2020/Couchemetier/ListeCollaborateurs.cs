using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace KELLERGRH2020
{
    public static class ListeCollaborateurs
    {
        private static List<Collaborateur> lesCollaborateurs;



		// TODO 

	
		public static List<Collaborateur> getCollaborateurs()
		{
			if (lesCollaborateurs == null)
			{
				lesCollaborateurs = CollaborateurDAO.getCollaborateurs();
			}
			return lesCollaborateurs;
		}


		public static Collaborateur getCollaborateurById(int unId)
        {
			return ListeCollaborateurs.getCollaborateurs().FirstOrDefault(r => r.Id == unId);
		}

		public static List<Collaborateur> getCollaborateurByNomPrenom(string unNom, string unPrenom)
		{
			List<Collaborateur> laListe;
			laListe = new List<Collaborateur>();

			var req = from col in lesCollaborateurs
					  where col.Nom == unNom && col.Prenom == unPrenom
					  select col;

			foreach (Collaborateur col in req)
			{
				laListe.Add(col);
			}

			return laListe;
		}



	}
}
