using Building.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building.DAL
{
    public interface IUnitOfWork
    {
        IReadingRepository ReadingRepository { get; }
        IBuildingRepository BuildingRepository { get; }
        IDataFieldRepository DataFieldRepository { get; }
        IObjectRepository ObjectRepository { get; }
    }
}
