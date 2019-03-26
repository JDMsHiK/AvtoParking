using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationParkingV2.Services.Abstractions
{
  public interface ILogger
  {
	void LogInfo(string message);

	void LogCritical(string message);

	void LogError(string message);
  }
}
