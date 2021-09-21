using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building.DAL.IRepositories
{
    public interface IUnitOfWork
    {
        IReadingRepository ReadingRepository { get; }
        IBuildingRepository BuildingRepository { get; }
        IDataFieldRepository DataFieldRepository { get; }
        IObjectRepository ObjectRepository { get; }
    }
}
