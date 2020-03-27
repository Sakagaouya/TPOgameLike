using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgameClassLibrary.Entities
{
    public class Resource : IDbEntity
    {
        #region Variables privées
        private long? id;
        private String name;
        private int? lastQuantity;
        private DateTime lastUpdate;
        #endregion
        #region Properties
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public int? LastQuantity
        {
            get { return lastQuantity; }
            set { lastQuantity = value; }
        }

        public DateTime LastUpdate
        {
            get { return lastUpdate; }
            set { lastUpdate = value; }
        }
        #endregion
        #region Propriétés issues de l'interface IdbEntity
        public virtual long? Id { get => this.id; set => this.id = value; }
        #endregion
    }
}
