using App.BUSINESS.DTOs.BaseDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.BUSINESS.DTOs.Course
{
    public class UpdateCourseDto:BaseEntityDto
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}
