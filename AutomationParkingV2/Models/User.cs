using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationParkingV2.Models
{
  /// <summary>
  /// Базовая модель для пользователя
  /// <see cref="Employee"/> и <see cref="Customer"/>
  /// </summary>
  public class User : BaseModel
  {
	public string FirstName { get; set; }

	public string Patronymic { get; set; }

	public string LastName { get; set; }
  }
}
