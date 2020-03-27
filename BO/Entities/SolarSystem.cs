using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgameClassLibrary.Entities
{
	public class SolarSystem : IDbEntity
	{
		#region Variables privées
		private long? id;
		private String name;
		private List<Planet> planets;
		#endregion

		#region Properties
		public String Name
		{
			get { return name; }
			set { name = value; }
		}

		public virtual List<Planet> Planets
		{
			get { return planets; }
			set { planets = value; }
		}
		#endregion

		#region Propriétés issues de l'interface IdbEntity
		public virtual long? Id { get => this.id; set => this.id = value; }
		#endregion

		#region Constructeur
		public SolarSystem()
		{
			this.planets = new List<Planet>();
		}
		#endregion
	}
}
