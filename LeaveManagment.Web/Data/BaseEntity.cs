using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagment.Web.Data;

public partial class BaseEntity
{
    [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateModified { get; set; }
}
