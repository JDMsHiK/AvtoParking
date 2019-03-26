using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationParkingV2.Models
{
  /// <summary>
  /// Базовая модель для сравнения обьектов по ключу
  /// </summary>
  public class BaseModel
  {
	public string ID { get; set; } = Guid.NewGuid().ToString();
  }
}
