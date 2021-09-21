using Building.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IReadingRepository readingRepository,
            IBuildingRepository buildingRepository,
            IDataFieldRepository dataFieldRepository,
            IObjectRepository objectRepository)
        {
            ReadingRepository = readingRepository;
            BuildingRepository = buildingRepository;
            DataFieldRepository = dataFieldRepository;
            ObjectRepository = objectRepository;
        }

        public IReadingRepository ReadingRepository { get; }

        public IBuildingRepository BuildingRepository { get; }

        public IDataFieldRepository DataFieldRepository { get; }

        public IObjectRepository ObjectRepository { get; }
    }
}
