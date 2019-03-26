using AutomationParkingV2.Models;
using AutomationParkingV2.Services.Abstractions;
using AutomationParkingV2.Services.Implementations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomationParkingV2
{
  public partial class RegistrationForm : Form
  {
	private readonly IFileService _fileservice;
	private readonly ILogger _logger;

	public RegistrationForm()
	{
	  InitializeComponent();
	  _fileservice = new FileService();
	  _logger = new LoggerService();
	}

	private async void Registration_Click(object sender, EventArgs e)
	{
	  try
	  {
		//Проверка на заполненность полей
		if (string.IsNullOrWhiteSpace(firstName.Text)
		|| string.IsNullOrWhiteSpace(lastName.Text)
		|| string.IsNullOrWhiteSpace(patronymic.Text)
		|| string.IsNullOrWhiteSpace(login.Text)
		|| string.IsNullOrWhiteSpace(password.Text)
		|| string.IsNullOrWhiteSpace(phone.Text))
		{
		  message.Text = "Введите все поля";
		  return;
		}

		//Создание нового пользователя
		var employee = new Employee
		{
		  FirstName = firstName.Text,
		  LastName = lastName.Text,
		  Patronymic = patronymic.Text,
		  Login = login.Text,
		  Password = password.Text,
		  Phone = phone.Text,
		  LastExit = DateTime.Now
		};

		//Добавление в файл
		await _fileservice.AddItem("employee.json", employee);

		//Логирование регистрации
		_logger.LogInfo($"Зарегестрирован - {employee.ID} : {employee.Login}");
		//Переход на главную форму
		var mainForm = new MainForm(employee);
		mainForm.Show();
		this.Hide();
	  }
	  catch (Exception ex)
	  {
		//Запись ошибки в файл
		_logger.LogCritical(ex.StackTrace.ToString());
	  }
	}
  }
}
