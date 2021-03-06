﻿using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace eManager.Web.Models
{
    public class CreateEmployeeViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public int DepartmentId { get; set; }
        [Required]
        public string Name { get; set; }
    }
}