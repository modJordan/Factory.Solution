using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }

    [Required(ErrorMessage = "The engineer's first name can't be empty!")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "The engineer's last name can't be empty!")]
    public string LastName { get; set; }
    [Required(ErrorMessage = "The engineer's specialty can't be empty!")]
    public string Specialty { get; set; }
    public virtual List<EngineerMachine> JoinEntities { get; set; }
  }
}
