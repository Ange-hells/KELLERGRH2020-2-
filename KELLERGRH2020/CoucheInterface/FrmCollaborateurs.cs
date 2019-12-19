using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KELLERGRH2020
{
    public partial class FrmCollaborateurs : Form
    {
        

        public FrmCollaborateurs()
        {
            InitializeComponent();

			ListeRegion.getRegions();
			ListeSecteurs.getSecteurs();
			ListeRole.getRoles();
			List<Collaborateur> oui;
			oui = ListeCollaborateurs.getCollaborateurs();
			ConstructionTreeview();
			// TODO    :       Affichage de l'arborescence présentant les secteurs, les régions et les collaborateurs en poste

		}

        private void ConstructionTreeview()
        {
            TreeNode n;
            TreeNode racine;

            // TODO : Requete LINQ pour obtenir les secteurs
            

            racine = tvOrganisation.Nodes.Add("KELLER THOMANN & TASSET - Gestion des ressources humaines");

			var req = from unSecteur in ListeSecteurs.getSecteurs()
					  where !(unSecteur.Code.Equals(0))
					  select unSecteur;


			foreach (Secteur s in req.ToList())
            {
                n = racine.Nodes.Add(s.Libelle);
                n.Nodes.Add("-");   // noeud fictif
            }
        }

        private void tvOrganisation_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode n = (TreeNode)e.Node;
            TreeNode parent = (TreeNode) n.Parent;
            TreeNode enfant;
  
            char[] delimiterChars = {'\\'};

			char[] separateurs = { '\\' };
			string[] elements = n.FullPath.Split(separateurs);

			if (elements.Length == 2)
			{
				// traitement secteur
				n.Nodes[0].Remove();
				Secteur s = ListeSecteurs.getSecteurByLibelle(n.Text);
				foreach (Region r in s._Regions)
				{
					enfant = n.Nodes.Add(r.Libelle);
					enfant.Nodes.Add("Pas de visiteurs");
				}



				var req2 = from c in ListeCollaborateurs.getCollaborateurs()
						   from p in c.Postes
						   where (p.dateDeb == c.Postes.Max(p1 => p1.dateDeb)
						   && (p.Secteur.Code == s.Code) && p.Role.Id == 1)
						   select c;

				foreach (Collaborateur c in req2.ToList())
				{
					enfant = n.Nodes.Add(c.Prenom.Trim(char.Parse(" ")) + " " + c.Nom);
				}
			}
			else
			{
				if (elements.Length == 3)
				{
					// traitement region
					Region r = ListeRegion.getRegionByLibelle(n.Text);

					var req = from c in ListeCollaborateurs.getCollaborateurs()
							  from p in c.Postes
							  where (p.dateDeb == c.Postes.Max(p1 => p1.dateDeb)
							  && (p.Region.Code == r.Code) && p.Role.Id != 1)
							  select c;


					// && p._Role.Code != 1

					if (req.ToList().Count > 0)
					{
						n.Nodes[0].Remove();
					}

					foreach (Collaborateur c in req.ToList())
					{
						enfant = n.Nodes.Add(c.Prenom.Trim(char.Parse(" ")) + " " + c.Nom);
						//enfant = n.Nodes.Add(c.Id());
					}
				}
			}
			//DG1.DataSource = enfant;
		}

	}

}
		// TO DO éclater le fullpath
		// string[] words = ...

		//if (words.Length == 2)
		//{
		//    // traitement secteur
		//    n.Nodes[0].Remove();
		//    Secteur s = ListeSecteurs.getSecteurByLibelle(n.Text);




		//}
		//else
		//{
		//    if (words.Length == 3)
		//    {
		//        // traitement région


		//        Region r = // TODO

		//        var req =  // TODO

		//        // suppression du noeud fictif

		//        if (req.ToList().Count > 0)
		//        {
		//            n.Nodes[0].Remove();
		//        }



		//    }

		//        }

