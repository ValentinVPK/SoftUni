using SoftJail.Common;
using System.ComponentModel.DataAnnotations;

namespace SoftJail.DataProcessor.ImportDto
{
    public class CellInputModel
    {
        [Range(GlobalConstants.CELL_MIN_RANGE, GlobalConstants.CELL_MAX_RANGE)]
        public int CellNumber { get; set; }
        public bool HasWindow { get; set; }
    }
}