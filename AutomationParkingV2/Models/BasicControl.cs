using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationParkingV2.Models
{
  /// <summary>
  /// Базовый обьект для классов <see cref="Arrivals"/> и <see cref="Departures"/>
  /// </summary>
  public class BasicControl : BaseModel
  {
	public DateTime? CheckPoint { get; set; }

	public int Place { get; set; }

	public string Customer { get; set; }

	public string Employee { get; set; }
  }
}
