using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace KELLERGRH2020
{
    public static class RoleDAO
    {
        private static List<Role> lesRoles;

		public static List<Role> getRoles()
		{
			if (lesRoles == null)
			{
				lesRoles = new List<Role>();
				Role unRole;
				SqlConnection ctn = new SqlConnection(Connexion.getChaine());
				ctn.Open();
				string req = "select * from ROLE";
				SqlCommand cmd = new SqlCommand(req, ctn);
				SqlDataReader jeu = cmd.ExecuteReader();
				while (jeu.Read())
				{
					unRole = new Role(int.Parse(jeu[0].ToString()), jeu[1].ToString());
					lesRoles.Add(unRole);
				}
				jeu.Close();
				ctn.Close();
			}
			return lesRoles;
		}
	}
}
