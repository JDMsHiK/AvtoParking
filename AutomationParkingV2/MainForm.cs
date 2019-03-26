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
  public partial class MainForm : Form
  {
	private readonly Employee _employee;
	private readonly IFileService _fileService;
	private readonly ILogger _logger;

	/// <summary>
	/// Получение в конструкторе текущего работника и сохдание инстансов сервисов
	/// </summary>
	/// <param name="employee"></param>
	public MainForm(Employee employee)
	{
	  InitializeComponent();
	  _employee = employee;
	  _fileService = new FileService();
	  _logger = new LoggerService();
	}

#pragma warning disable IDE1006 // Naming Styles

	#region CustomerNonPublicMethods
	//Событие на изменение обьекта (строки)
	private async void customerGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
	  try
	  {
		if (customerGrid.CurrentRow != null)
		{
		  //Получение обьекта из строки
		  var user = (Customer)customerGrid.CurrentRow.DataBoundItem;
		  if (!string.IsNullOrWhiteSpace(user.ID))
		  {
			//Обновление обьекта
			var users = await _fileService.AddOrUpdateItem("customer.json", user);
			//Привязкеа новых даенных
			var source = new BindingSource();
			source.AllowNew = true;
			source.DataSource = users;
			customerGrid.DataSource = source;
		  }
		}
	  }
	  catch (Exception ex)
	  {
		_logger.LogCritical(ex.StackTrace.ToString());
	  }
	}

	//Событие на создание новой строки
	private async void customerGrid_UserAddedRow(object sender, DataGridViewRowEventArgs e)
	{
	  try
	  {
		//Получение добавленной строки, добавление ID
		var row = (Customer)customerGrid.CurrentRow.DataBoundItem;

		await _fileService.AddItem("customer.json", row);
	  }
	  catch (Exception ex)
	  {
		_logger.LogCritical(ex.StackTrace.ToString());
	  }
	}

	//Событие нажатия мыши для удаления обьекта
	private async void customerGrid_MouseClick(object sender, MouseEventArgs e)
	{
	  try
	  {
		//Если нажата правая кнопка мыши
		if (e.Button == MouseButtons.Right)
		{
		  //Получение координат нажатия
		  int currentMouseOverRow = customerGrid.HitTest(e.X, e.Y).RowIndex;

		  //Получение обьекта из строки
		  var customer = (Customer)customerGrid.Rows[currentMouseOverRow].DataBoundItem;

		  if (currentMouseOverRow >= 0)
		  {
			//Вывод окна подтверждения
			DialogResult dialogResult = MessageBox.Show("Удаление", "Удалить строку?", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
			  //Удаление обьекта
			  await _fileService.DeleteItem<Customer>("customer.json", customer);
			  var customers = await _fileService.ReadFile<Customer>("customer.json");
			  //Обновлеение коллекции
			  var source = new BindingSource();
			  source.AllowNew = true;
			  source.DataSource = customers;
			  customerGrid.DataSource = source;
			}
			else if (dialogResult == DialogResult.No)
			{
			  return;
			}
		  }
		}
	  }
	  catch (Exception ex)
	  {
		_logger.LogCritical(ex.StackTrace.ToString());
	  }
	}
	#endregion


	#region EmployeeNonPublicMethods
	private async void employeeGrid_UserAddedRow(object sender, DataGridViewRowEventArgs e)
	{
	  try
	  {
		var row = (Employee)employeeGrid.CurrentRow.DataBoundItem;

		await _fileService.AddItem("employee.json", row);
	  }
	  catch (Exception ex)
	  {
		_logger.LogCritical(ex.StackTrace.ToString());
	  }
	}

	private async void employeeGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
	  try
	  {
		if (employeeGrid.CurrentRow != null)
		{
		  var employee = (Employee)employeeGrid.CurrentRow.DataBoundItem;
		  if (!string.IsNullOrWhiteSpace(employee.ID))
		  {
			var employees = await _fileService.AddOrUpdateItem("employee.json", employee);
			var source = new BindingSource();
			source.AllowNew = true;
			source.DataSource = employees;
			employeeGrid.DataSource = source;
		  }
		}
	  }
	  catch (Exception ex)
	  {
		_logger.LogCritical(ex.StackTrace.ToString());
	  }
	}

	private async void employeeGrid_MouseClick(object sender, MouseEventArgs e)
	{
	  try
	  {
		if (e.Button == MouseButtons.Right)
		{
		  int currentMouseOverRow = employeeGrid.HitTest(e.X, e.Y).RowIndex;

		  var employee = (Employee)employeeGrid.Rows[currentMouseOverRow].DataBoundItem;

		  if (currentMouseOverRow >= 0)
		  {
			DialogResult dialogResult = MessageBox.Show("Удаление", "Удалить строку?", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
			  var employees = await _fileService.DeleteItem("employee.json", employee);
			  var source = new BindingSource();
			  source.AllowNew = true;
			  source.DataSource = employees;
			  employeeGrid.DataSource = source;
			}
			else if (dialogResult == DialogResult.No)
			{
			  return;
			}
		  }
		}
	  }
	  catch (Exception ex)
	  {
		_logger.LogCritical(ex.StackTrace.ToString());
	  }
	}
	#endregion


	#region ArrivalNonPublicMethods
	private async void arrivalGrid_MouseClick(object sender, MouseEventArgs e)
	{
	  try
	  {
		if (e.Button == MouseButtons.Right)
		{
		  int currentMouseOverRow = arrivalGrid.HitTest(e.X, e.Y).RowIndex;

		  var arrival = (Arrivals)arrivalGrid.Rows[currentMouseOverRow].DataBoundItem;

		  if (currentMouseOverRow >= 0)
		  {
			DialogResult dialogResult = MessageBox.Show("Удаление", "Удалить строку?", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
			  var arrivals = await _fileService.DeleteItem("arrival.json", arrival);
			  var source = new BindingSource();
			  source.AllowNew = true;
			  source.DataSource = arrivals;
			  arrivalGrid.DataSource = source;
			}
			else if (dialogResult == DialogResult.No)
			{
			  return;
			}
		  }
		}
	  }
	  catch (Exception ex)
	  {
		_logger.LogCritical(ex.StackTrace.ToString());
	  }
	}

	private async void arrivalGrid_UserAddedRow(object sender, DataGridViewRowEventArgs e)
	{
	  try
	  {
		var row = (Arrivals)arrivalGrid.CurrentRow.DataBoundItem;

		await _fileService.AddItem("arrival.json", row);
	  }
	  catch (Exception ex)
	  {
		_logger.LogCritical(ex.StackTrace.ToString());
	  }
	}

	private async void arrivalGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
	  try
	  {
		if (arrivalGrid.CurrentRow != null)
		{
		  var arrival = (Arrivals)arrivalGrid.CurrentRow.DataBoundItem;
		  if (!string.IsNullOrWhiteSpace(arrival.ID))
		  {
			var arrivals = await _fileService.AddOrUpdateItem("arrival.json", arrival);
			var source = new BindingSource();
			source.AllowNew = true;
			source.DataSource = arrivals;
			arrivalGrid.DataSource = source;
		  }
		}
	  }
	  catch (Exception ex)
	  {
		_logger.LogCritical(ex.StackTrace.ToString());
	  }
	}
	#endregion

	#region DepartureNonPublicMethods
	private async void departureGrid_MouseClick(object sender, MouseEventArgs e)
	{
	  try
	  {
		if (e.Button == MouseButtons.Right)
		{
		  int currentMouseOverRow = departureGrid.HitTest(e.X, e.Y).RowIndex;

		  var departure = (Employee)departureGrid.Rows[currentMouseOverRow].DataBoundItem;

		  if (currentMouseOverRow >= 0)
		  {
			DialogResult dialogResult = MessageBox.Show("Удаление", "Удалить строку?", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
			  var departures = await _fileService.DeleteItem("departure.json", departure);
			  var source = new BindingSource();
			  source.AllowNew = true;
			  source.DataSource = departure;
			  departureGrid.DataSource = source;
			}
			else if (dialogResult == DialogResult.No)
			{
			  return;
			}
		  }
		}
	  }
	  catch (Exception ex)
	  {
		_logger.LogCritical(ex.StackTrace.ToString());
	  }
	}

	private async void departureGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
	  try
	  {
		if (departureGrid.CurrentRow != null)
		{
		  var departure = (Departures)departureGrid.CurrentRow.DataBoundItem;
		  if (!string.IsNullOrWhiteSpace(departure.ID))
		  {
			var departures = await _fileService.AddOrUpdateItem("departure.json", departure);
			var source = new BindingSource();
			source.AllowNew = true;
			source.DataSource = departures;
			departureGrid.DataSource = source;
		  }
		}
	  }
	  catch (Exception ex)
	  {
		_logger.LogCritical(ex.StackTrace.ToString());
	  }
	}

	private async void departureGrid_UserAddedRow(object sender, DataGridViewRowEventArgs e)
	{
	  try
	  {
		var row = (Departures)departureGrid.CurrentRow.DataBoundItem;

		await _fileService.AddItem("departure.json", row);
	  }
	  catch (Exception ex)
	  {
		_logger.LogCritical(ex.StackTrace.ToString());
	  }
	}

	#endregion

	#region TypesCar
	private async void typeCarGrid_MouseClick(object sender, MouseEventArgs e)
	{
	  try
	  {
		if (e.Button == MouseButtons.Right)
		{
		  int currentMouseOverRow = typeCarGrid.HitTest(e.X, e.Y).RowIndex;

		  var typeCar = (TypeCar)typeCarGrid.Rows[currentMouseOverRow].DataBoundItem;

		  if (currentMouseOverRow >= 0)
		  {
			DialogResult dialogResult = MessageBox.Show("Удаление", "Удалить строку?", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
			  var typeCars = await _fileService.DeleteItem("departure.json", typeCar);
			  var source = new BindingSource();
			  source.AllowNew = true;
			  source.DataSource = typeCar;
			  typeCarGrid.DataSource = source;
			}
			else if (dialogResult == DialogResult.No)
			{
			  return;
			}
		  }
		}
	  }
	  catch (Exception ex)
	  {
		_logger.LogCritical(ex.StackTrace.ToString());
	  }
	}

	private async void typeCarGrid_UserAddedRow(object sender, DataGridViewRowEventArgs e)
	{
	  try
	  {
		var row = (TypeCar)typeCarGrid.CurrentRow.DataBoundItem;

		await _fileService.AddItem("typeCar.json", row);
	  }
	  catch (Exception ex)
	  {
		_logger.LogCritical(ex.StackTrace.ToString());
	  }
	}

	private async void typeCarGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
	  try
	  {
		if (typeCarGrid.CurrentRow != null)
		{
		  var typeCar = (TypeCar)typeCarGrid.CurrentRow.DataBoundItem;
		  if (!string.IsNullOrWhiteSpace(typeCar.ID))
		  {
			var typeCars = await _fileService.AddOrUpdateItem("typeCar.json", typeCar);
			var source = new BindingSource();
			source.AllowNew = true;
			source.DataSource = typeCars;
			typeCarGrid.DataSource = source;
		  }
		}
	  }
	  catch (Exception ex)
	  {
		_logger.LogCritical(ex.StackTrace.ToString());
	  }
	}
	#endregion

	//Обработка ошибок DataGrid
	private void arrivalGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
	{
	}

	private void departureGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
	{
	}

	//Метод загрузки формы
	private void MainForm_Load(object sender, EventArgs e)
	{
	  try
	  {
		//Очистка таблиц
		customerGrid.Columns.Clear();
		employeeGrid.Columns.Clear();
		arrivalGrid.Columns.Clear();
		departureGrid.Columns.Clear();
		typeCarGrid.Columns.Clear();

		//Получение статуса пользователя
		var isAdmin = _employee.Role == Roles.Admin ? true : false;

		//Ограничение дотсупа для редактирования таблиц
		customerGrid.Enabled = isAdmin;
		employeeGrid.Enabled = isAdmin;
		arrivalGrid.Enabled = isAdmin;
		departureGrid.Enabled = isAdmin;
		typeCarGrid.Enabled = isAdmin;

		#region CustomerTab
		//Указание колонок таблицы
		var userIdColumn = new DataGridViewTextBoxColumn
		{
		  DataPropertyName = "Id",
		  HeaderText = "Id",
		  ReadOnly = true
		};

		var userlastName = new DataGridViewTextBoxColumn
		{
		  DataPropertyName = "LastName",
		  HeaderText = "Фамилия"
		};

		var userfirstName = new DataGridViewTextBoxColumn
		{
		  DataPropertyName = "FirstName",
		  HeaderText = "Имя"
		};

		var userPatronymic = new DataGridViewTextBoxColumn
		{
		  DataPropertyName = "Patronymic",
		  HeaderText = "Отчество"
		};

		var color = new DataGridViewTextBoxColumn
		{
		  DataPropertyName = "Color",
		  HeaderText = "Цвет"
		};

		var number = new DataGridViewTextBoxColumn
		{
		  DataPropertyName = "GovernmentNumber",
		  HeaderText = "Гос. номер"
		};

		var model = new DataGridViewTextBoxColumn
		{
		  DataPropertyName = "CarName",
		  HeaderText = "Марка машины"
		};

		var type = new DataGridViewComboBoxColumn
		{
		  DataPropertyName = "TypeCar",
		  HeaderText = "Тип машины",
		  DisplayMember = "Name",
		};

		//Получение элементов SelectBox
		var types = _fileService.ReadFile<TypeCar>("typeCar.json").Result.Select(x => x.Name).ToList();
		//Добавление элементов
		types.ForEach(x => type.Items.Add(x));

		//Добавление колонок
		customerGrid.Columns.AddRange(userIdColumn, userlastName, userfirstName, userPatronymic, color, number, model, type);

		//Заполнение данными
		customerGrid.AutoGenerateColumns = false;
		var customers = _fileService.ReadFile<Customer>("customer.json").Result;
		var customerSource = new BindingSource();
		customerSource.AllowNew = true;
		customerSource.DataSource = customers;
		customerGrid.DataSource = customerSource;
		customerGrid.EditMode = DataGridViewEditMode.EditOnEnter;
		#endregion

		#region Employee
		var employeeIdColumn = new DataGridViewTextBoxColumn
		{
		  DataPropertyName = "Id",
		  HeaderText = "Id",
		  ReadOnly = true
		};

		var employeelastName = new DataGridViewTextBoxColumn
		{
		  DataPropertyName = "LastName",
		  HeaderText = "Фамилия"
		};

		var employeefirstName = new DataGridViewTextBoxColumn
		{
		  DataPropertyName = "FirstName",
		  HeaderText = "Имя"
		};

		var employeePatronymic = new DataGridViewTextBoxColumn
		{
		  DataPropertyName = "Patronymic",
		  HeaderText = "Отчество"
		};

		var employeeLogin = new DataGridViewTextBoxColumn
		{
		  DataPropertyName = "Login",
		  HeaderText = "Логин"
		};

		var employeePassword = new DataGridViewTextBoxColumn
		{
		  DataPropertyName = "Password",
		  HeaderText = "Пароль",
		  Visible = false
		};

		var employeePhone = new DataGridViewTextBoxColumn
		{
		  DataPropertyName = "Phone",
		  HeaderText = "Телефон"
		};

		var employeePosition = new DataGridViewTextBoxColumn
		{
		  DataPropertyName = "Position",
		  HeaderText = "Должность"
		};

		var employeeLastExit = new DataGridViewTextBoxColumn
		{
		  DataPropertyName = "LastExit",
		  HeaderText = "Последняя активность",
		  ReadOnly = true
		};

		var employeeRole = new DataGridViewTextBoxColumn
		{
		  DataPropertyName = "Role",
		  HeaderText = "Роль",
		  ReadOnly = true
		};

		employeeGrid.Columns.AddRange(
		  employeeIdColumn,
		  employeelastName,
		  employeefirstName,
		  employeePatronymic,
		  employeeLogin,
		  employeePassword,
		  employeePhone,
		  employeePosition,
		  employeeLastExit,
		  employeeRole);

		employeeGrid.AutoGenerateColumns = false;
		var employees = _fileService.ReadFile<Employee>("employee.json").Result;
		var employeeSource = new BindingSource();
		employeeSource.AllowNew = true;
		employeeSource.DataSource = employees;
		employeeGrid.DataSource = employeeSource;
		employeeGrid.EditMode = DataGridViewEditMode.EditOnEnter;
		#endregion

		#region Arrival
		var arrivalIdColumn = new DataGridViewTextBoxColumn
		{
		  DataPropertyName = "Id",
		  HeaderText = "Id",
		  ReadOnly = true
		};

		var checkPoint = new DataGridViewTextBoxColumn
		{
		  DataPropertyName = "CheckPoint",
		  HeaderText = "Контрольная точка"
		};

		var place = new DataGridViewTextBoxColumn
		{
		  DataPropertyName = "Place",
		  HeaderText = "Место"
		};

		var arrivalCustomer = new DataGridViewComboBoxColumn
		{
		  DataPropertyName = "Customer",
		  HeaderText = "Клиент"
		};

		var arrivalEmployee = new DataGridViewComboBoxColumn
		{
		  DataPropertyName = "Employee",
		  HeaderText = "Работник"
		};

		var customersList = _fileService.ReadFile<Customer>("customer.json")
		  .Result.Select(x => $"{x.LastName} {x.FirstName} {x.Patronymic}").ToList();
		customersList.ForEach(x => arrivalCustomer.Items.Add(x));

		var employeeList = _fileService.ReadFile<Employee>("employee.json")
		  .Result.Select(x => $"{x.LastName} {x.FirstName} {x.Patronymic}").ToList();
		employeeList.ForEach(x => arrivalEmployee.Items.Add(x));

		arrivalGrid.Columns.AddRange(
		  arrivalIdColumn,
		  checkPoint,
		  place,
		  arrivalCustomer,
		  arrivalEmployee);

		arrivalGrid.AutoGenerateColumns = false;
		var arrivals = _fileService.ReadFile<Arrivals>("arrival.json").Result;
		var arrivalSource = new BindingSource();
		arrivalSource.AllowNew = true;
		arrivalSource.DataSource = arrivals;
		arrivalGrid.DataSource = arrivalSource;
		arrivalGrid.EditMode = DataGridViewEditMode.EditOnEnter;
		#endregion

		#region Departure
		var departureIdColumn = new DataGridViewTextBoxColumn
		{
		  DataPropertyName = "Id",
		  HeaderText = "Id",
		  ReadOnly = true
		};

		var departureCheckPoint = new DataGridViewTextBoxColumn
		{
		  DataPropertyName = "CheckPoint",
		  HeaderText = "Контрольная точка"
		};

		var departurePlace = new DataGridViewTextBoxColumn
		{
		  DataPropertyName = "Place",
		  HeaderText = "Место"
		};

		var departureCustomer = new DataGridViewComboBoxColumn
		{
		  DataPropertyName = "Customer",
		  HeaderText = "Клиент"
		};

		var departureEmployee = new DataGridViewComboBoxColumn
		{
		  DataPropertyName = "Employee",
		  HeaderText = "Работник"
		};

		customersList.ForEach(x => departureCustomer.Items.Add(x));
		employeeList.ForEach(x => departureEmployee.Items.Add(x));

		departureGrid.Columns.AddRange(
		  departureIdColumn,
		  departureCheckPoint,
		  departurePlace,
		  departureCustomer,
		  departureEmployee);

		departureGrid.AutoGenerateColumns = false;
		var departures = _fileService.ReadFile<Departures>("departure.json").Result;
		var departureSource = new BindingSource();
		departureSource.AllowNew = true;
		departureSource.DataSource = departures;
		departureGrid.DataSource = departureSource;
		departureGrid.EditMode = DataGridViewEditMode.EditOnEnter;
		#endregion

		#region TypeCar
		var typeCarIdColumn = new DataGridViewTextBoxColumn
		{
		  DataPropertyName = "Id",
		  HeaderText = "Id",
		  ReadOnly = true
		};

		var typeCarName = new DataGridViewTextBoxColumn
		{
		  DataPropertyName = "Name",
		  HeaderText = "Наименование"
		};

		typeCarGrid.Columns.AddRange(
		  typeCarIdColumn,
		  typeCarName);

		typeCarGrid.AutoGenerateColumns = false;
		var typeCars = _fileService.ReadFile<TypeCar>("typeCar.json").Result;
		var typeCarsSource = new BindingSource();
		typeCarsSource.AllowNew = true;
		typeCarsSource.DataSource = typeCars;
		typeCarGrid.DataSource = typeCarsSource;
		typeCarGrid.EditMode = DataGridViewEditMode.EditOnEnter;
		#endregion
	  }
	  catch (Exception ex)
	  {
		_logger.LogCritical(ex.Message);
	  }
	}

	//События для обновления данных при переходе по табу
	private void customersTab_Selected(object sender, TabControlEventArgs e)
	{
	  this.OnLoad(e);
	}
  }
}
