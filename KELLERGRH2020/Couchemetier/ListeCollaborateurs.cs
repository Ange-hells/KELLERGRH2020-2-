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


		public static Collaborateur getCollaborateurById(string unId)
        {
			return ListeCollaborateurs.getCollaborateurs().FirstOrDefault(r => r.Id == unId);
		}

        public static List<Collaborateur> getCollaborateurByNomPrenom(string unNom, string unPrenom)
        {
            // TODO 
        }



    }
}
