using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgameClassLibrary.Entities
{
    public abstract class FunctionBuilding : Building
    {
        #region Variables privées
        private List<Action> actions;
        #endregion

        #region Properties
        [NotMapped]
        public virtual List<Action> Actions
        {
            get { return actions; }
            set { actions = value; }
        }

        #endregion

        #region Constructors
        public FunctionBuilding()
        {
            //initialise la liste
            this.actions = new List<Action>();
        }
        #endregion
    }
}
