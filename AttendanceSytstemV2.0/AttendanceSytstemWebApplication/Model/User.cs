using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AttendanceSytstemWebApplication.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public int Role { get; set; }

        [JsonIgnore]
        public IEnumerable<Attendance> Attendance { get; set; }

        [JsonIgnore]
        public IEnumerable<Schedule> Schedule { get; set; }
    }
}
