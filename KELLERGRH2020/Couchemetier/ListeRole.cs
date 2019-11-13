using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KELLERGRH2020
{
	public class ListeRole
	{

		private static List<Role> lesRoles;

		public static List<Role> getRoles()
		{
			if (lesRoles == null)
			{
				lesRoles = RoleDAO.getRoles();
			}
			return lesRoles;
		}

		public static Role getRoleByLibelle(string unLibelle)
		{
			return ListeRole.getRoles().FirstOrDefault(r => r.Libelle == unLibelle);
		}

		public static Role getRoleById(int unId)
		{
			return lesRoles.FirstOrDefault(r => r.Id == unId);
		}

	}
}
