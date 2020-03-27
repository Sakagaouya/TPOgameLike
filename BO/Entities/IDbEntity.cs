using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgameClassLibrary.Entities
{
    public interface IDbEntity
    {
        
        //Long qui peut être nullable car le int des Bases de données est plus grand que le int de C#
        long? Id { get; set; }
    
    }
}
