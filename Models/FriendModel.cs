using System;
using System.ComponentModel.DataAnnotations;

namespace BootsrapDemoTest.Models
{
    public class FriendModel
    {
        public int ID { get; set; }
        [Required]
        [Range(0, 200, ErrorMessage = "FriendID must be between 0-200")]
        [Display(Name = "Friend ID")]

        public int FriendID { get; set; }
        [Required] public String Name { get; set; }
        [Required] public String Hometown { get; set; }




    }
}
