using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationParkingV2.Models
{
  /// <summary>
  /// Описание класса логгов, не включючен в систему, тк
  /// циклическая ссылка с <see cref="AutomationParkingV2.Services.Abstractions.IFileService"/>.
  /// </summary>
  public class LogItem : BaseModel
  {
	public string Message { get; set; }
  }
}
