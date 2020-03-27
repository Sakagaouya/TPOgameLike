using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgameClassLibrary.Entities
{
    public abstract class ResourceGenerator : Building
    {
        #region Variables privées
        private List<Resource> resourceBySecond;
        #endregion

        #region Properties
        [NotMapped]
        public virtual List<Resource> ResourceBySecond
        {
            get { return resourceBySecond; }
            set { resourceBySecond = value; }
        }
        #endregion

        #region Constructeurs
        public ResourceGenerator()
        {
            this.resourceBySecond = new List<Resource>();
        }
        #endregion
    }
}
