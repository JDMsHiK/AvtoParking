using AutomationParkingV2.Models;
using AutomationParkingV2.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationParkingV2.Services.Implementations
{
  public class LoggerService : ILogger
  {
	private IFileService _fileService;
	private string _path = Path.Combine(Directory.GetCurrentDirectory(), "root/", "logs/");

	public LoggerService()
	{
	  GetPath($"{DateTime.Now.ToShortDateString()}.json");
	  _fileService = new FileService();
	}

	public async void LogCritical(string message)
	{
	  var logs = await _fileService.ReadFile<LogItem>(GetPath($"{DateTime.Now.ToShortDateString()}.json"));

	  logs.Add(new LogItem
	  {
		Message = $"Critical {DateTime.Now.ToShortTimeString()} :: {message}"
	  });

	  _fileService.WriteFile(GetPath($"{DateTime.Now.ToShortDateString()}.json"), logs);
	}

	public async void LogError(string message)
	{
	  var logs = await _fileService.ReadFile<LogItem>(GetPath($"{DateTime.Now.ToShortDateString()}.json"));

	  logs.Add(new LogItem
	  {
		Message = $"Error {DateTime.Now.ToShortTimeString()} :: {message}"
	  });

	  _fileService.WriteFile(GetPath($"{DateTime.Now.ToShortDateString()}.json"), logs);
	}

	public async void LogInfo(string message)
	{
	  var logs = await _fileService.ReadFile<LogItem>(GetPath($"{DateTime.Now.ToShortDateString()}.json"));

	  logs.Add(new LogItem
	  {
		Message = $"Info {DateTime.Now.ToShortTimeString()} :: {message}"
	  });

	  _fileService.WriteFile(GetPath($"{DateTime.Now.ToShortDateString()}.json"), logs);
	}

	private string GetPath(string fileName)
	{
	  var path = $"{_path}/{fileName}";
	  if (!Directory.Exists(_path))
	  {
		Directory.CreateDirectory(_path);
	  }

	  if (!File.Exists(path))
	  {
		File.Create(path);
	  }

	  return path;
	}
  }
}
