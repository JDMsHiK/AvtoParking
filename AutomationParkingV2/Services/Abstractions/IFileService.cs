using AutomationParkingV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationParkingV2.Services.Abstractions
{
  public interface IFileService
  {
	/// <summary>
	/// Чтение файла
	/// </summary>
	/// <typeparam name="T">Считываемый тип данных</typeparam>
	/// <param name="fileName">Название файла</param>
	/// <returns>Список обьектов</returns>
	Task<List<T>> ReadFile<T>(string fileName) where T : BaseModel;

	/// <summary>
	/// Записывает данные в файл
	/// </summary>
	/// <typeparam name="T">Тип данных</typeparam>
	/// <param name="fileName">Имя файла</param>
	/// <param name="value">Данные для записи</param>
	void WriteFile<T>(string fileName, List<T> value) where T : BaseModel;

	/// <summary>
	/// Добавление одного элемента в файл
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="fileName"></param>
	/// <param name="value"></param>
	/// <returns></returns>
	Task<List<T>> AddItem<T>(string fileName, T value) where T : BaseModel;

	/// <summary>
	/// Удаление одного элемента из файла
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="fileName"></param>
	/// <param name="item"></param>
	/// <returns></returns>
	Task<List<T>> DeleteItem<T>(string fileName, T item) where T : BaseModel;

	/// <summary>
	/// Обновление или добавление информации в файле
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="fileName"></param>
	/// <param name="item"></param>
	/// <returns></returns>
	Task<List<T>> AddOrUpdateItem<T>(string fileName, T item) where T : BaseModel;
  }
}
