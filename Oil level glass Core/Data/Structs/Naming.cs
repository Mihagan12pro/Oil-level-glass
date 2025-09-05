using Oil_level_glass_Core.Services;
using System.ComponentModel.DataAnnotations;

namespace Oil_level_glass_Core.Data.Structs
{
    public struct Naming
    {
        [Required(ErrorMessage = StringMaster.RequiredError)]
        public string Name { get; set; }

        [Required(ErrorMessage = StringMaster.RequiredError)]
        public string Marking { get; set; }
    }
}
