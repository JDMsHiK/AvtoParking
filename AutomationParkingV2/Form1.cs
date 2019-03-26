using AutomationParkingV2.Models;
using AutomationParkingV2.Services.Abstractions;
using AutomationParkingV2.Services.Implementations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomationParkingV2
{
  public partial class LoginForm : Form
  {
	private readonly IFileService _fileService;
	private readonly ILogger _logger;

	//Productions by "Костыли и Палки"
	public LoginForm()
	{
	  InitializeComponent();
	  //Получение сервиса для работы с файловой системой
	  _fileService = new FileService();
	  _logger = new LoggerService();
	}

	private async void LoginButton_Click(object sender, EventArgs e)
	{
	  try
	  {
		//Получение данных с файла
		var employees = await _fileService.ReadFile<Employee>("employee.json");
		//Получение пользователя
		var employee = employees.FirstOrDefault(x => x.Login == login.Text && x.Password == password.Text);
		if (employee != null)
		{
		  //Вход в систему, переход на главную форму
		  employee.LastExit = DateTime.Now;
		  await _fileService.AddOrUpdateItem("employee.json", employee);

		  //Логгирование входа
		  _logger.LogInfo($"Выполнен вход - {employee.ID} : {employee.Login}");
		  var mainForm = new MainForm(employee);
		  mainForm.Show();
		  Hide();
		}
		//Если введены неверные данные - вывод сообщения
		else
		{
		  LoginError.Text = "Неправильно введенные данные";
		}
	  }
	  catch (Exception ex)
	  {
		_logger.LogCritical(ex.StackTrace.ToString());
	  }
	}

	//Переход на форму регистрации
	private void RegistrationButton_Click(object sender, EventArgs e)
	{
	  var registrationForm = new RegistrationForm();
	  registrationForm.Show();
	  Hide();
	}

	//Закрытие формы
	private void ExitButton_Click(object sender, EventArgs e)
	{
	  this.Close();
	}
  }
}
