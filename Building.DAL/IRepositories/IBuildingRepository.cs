using Entity = Building.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building.DAL.IRepositories
{
    public interface IBuildingRepository : IBaseRepository<Entity.Building>
    {
    }
}
