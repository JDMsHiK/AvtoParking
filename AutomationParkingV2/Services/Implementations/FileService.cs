using AutomationParkingV2.Models;
using AutomationParkingV2.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationParkingV2.Services.Implementations
{
  public class FileService : IFileService
  {
	private string _path = Path.Combine(Directory.GetCurrentDirectory(), "root");
	private readonly ISerializationService _serializationService;

	public FileService()
	{
	  //Создание сервиса сериализации
	  _serializationService = new SerializationService();
	}

	/// <summary>
	/// Добавленеи одного элемента в файл
	/// </summary>
	/// <typeparam name="T">Тип данных</typeparam>
	/// <param name="fileName">Название файла</param>
	/// <param name="value">Элемент записи</param>
	/// <returns></returns>
	public async Task<List<T>> AddItem<T>(string fileName, T value) where T : BaseModel
	{
	  try
	  {
		//Считываем файл
		var data = await ReadFile<T>(fileName);
		//Добавляем элемент
		data.Add(value);

		//Записываем новую коллекцию в файл
		WriteFile(fileName, data);

		return data;
	  }
	  catch (Exception ex)
	  {
		return new List<T>();
	  }
	}

	/// <summary>
	/// Удаленеи одного элемента
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="fileName"></param>
	/// <param name="item"></param>
	/// <returns></returns>
	public async Task<List<T>> DeleteItem<T>(string fileName, T item) where T : BaseModel
	{
	  try
	  {
		//Получение всех элементов
		var data = await ReadFile<T>(fileName);
		//Обьект для удаления
		var deleting = data.FirstOrDefault(x => x.ID == item.ID);
		if (deleting == null)
		{
		  return data;
		}

		//Удаление обьекта
		data.Remove(deleting);
		//Запись обновленной коллекции
		WriteFile(fileName, data);

		return data;
	  }
	  catch (Exception ex)
	  {
		return new List<T>();
	  }
	}

	/// <summary>
	/// Считывание данных из файла
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="fileName"></param>
	/// <returns></returns>
	public async Task<List<T>> ReadFile<T>(string fileName) where T : BaseModel
	{
	  try
	  {
		//Получение JSON`а из файла
		var json = File.ReadAllText(GetPath(fileName));
		//Преобразование JSON в тип T
		var data = _serializationService.DeserializeObject<List<T>>(json);

		return data != null ? data : new List<T>();
	  }
	  catch (Exception ex)
	  {
		return new List<T>();
	  }
	}

	/// <summary>
	/// Добавление или обновление обьекта
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="fileName"></param>
	/// <param name="item"></param>
	/// <returns></returns>
	public async Task<List<T>> AddOrUpdateItem<T>(string fileName, T item) where T : BaseModel
	{
	  try
	  {
		var data = await ReadFile<T>(fileName);
		//Поиск обьекта по ключу
		var finded = data.FirstOrDefault(x => x.ID == item.ID);
		if (finded != null)
		{
		  //Обновление обьекта
		  data.Remove(finded);
		  data.Add(item);
		}
		else
		{
		  //Добавление обьекта
		  data.Add(item);
		}

		//Запись обновленной коллекции
		WriteFile(fileName, data);

		return data != null ? data : new List<T>();
	  }
	  catch (Exception ex)
	  {
		return new List<T>();
	  }
	}

	/// <summary>
	/// Запись данных в файл
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="fileName"></param>
	/// <param name="value"></param>
	public async void WriteFile<T>(string fileName, List<T> value) where T : BaseModel
	{
	  try
	  {
		using (var sw = new StreamWriter(GetPath(fileName), false, Encoding.UTF8))
		{
		  if (!sw.BaseStream.CanWrite)
		  {
			Debug.Write($"Невозможно записать в файл.");
		  }

		  //Преобразование обьекта T в JSON
		  var json = _serializationService.SerializeObject(value);
		  //Запись в файл
		  await sw.WriteAsync(json);
		}
	  }
	  catch (Exception ex)
	  {
		throw;
	  }
	}

	/// <summary>
	/// Получение пути
	/// </summary>
	/// <param name="fileName">Имя файла</param>
	/// <returns></returns>
	private string GetPath(string fileName)
	{
	  //Путь + имя файла
	  var path = Path.Combine(_path, fileName);
	  //Если нет директории, то она создается
	  if (!Directory.Exists(_path))
	  {
		Directory.CreateDirectory(_path);
	  }

	  //Если нет файла, то она создается
	  if (!File.Exists(path))
	  {
		File.Create(path);
	  }

	  return path;
	}
  }
}
