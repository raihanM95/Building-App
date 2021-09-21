using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building.Domain.DTOs
{
    public class ReadingDto
    {
        public int BuildingId { get; set; }
        public int DataFieldId { get; set; }
        public int ObjectId { get; set; }
        public DateTime TimestampFrom { get; set; }
        public DateTime TimestampTo { get; set; }
    }
}
