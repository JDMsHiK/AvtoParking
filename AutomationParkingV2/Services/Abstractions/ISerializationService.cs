using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationParkingV2.Services.Abstractions
{
  public interface ISerializationService
  {
	string SerializeObject<T>(T value);

	T DeserializeObject<T>(string json);
  }
}
