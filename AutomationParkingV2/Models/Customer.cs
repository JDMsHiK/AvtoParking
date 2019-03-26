using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationParkingV2.Models
{
  /// <summary>
  /// Клиенты
  /// </summary>
  public class Customer : User
  {
	public string CarName { get; set; }

	public string TypeCar { get; set; }

	public string GovernmentNumber { get; set; }

	public string Color { get; set; }

	public DateTime? Created { get; set; } = DateTime.Now;

	public DateTime? Modified { get; set; }
  }
}
