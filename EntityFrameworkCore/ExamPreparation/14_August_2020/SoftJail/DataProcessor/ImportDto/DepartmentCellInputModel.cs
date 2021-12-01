using SoftJail.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SoftJail.DataProcessor.ImportDto
{
    public class DepartmentCellInputModel
    {
        [Required]
        [StringLength(GlobalConstants.DEPARTMENT_NAME_MAX_LENGTH, MinimumLength =GlobalConstants.DEPARTMENT_NAME_MIN_LENGTH)]
        public string Name { get; set; }

        public ICollection<CellInputModel> Cells { get; set; }
    }
}

/*{
    "Name": "",
    "Cells": [
      {
        "CellNumber": 101,
        "HasWindow": true
      },
      {
        "CellNumber": 102,
        "HasWindow": false
      }
    ]
  },*/
