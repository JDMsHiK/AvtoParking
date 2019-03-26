using System;

namespace AutomationParkingV2.Models
{
  /// <summary>
  /// Работники
  /// </summary>
  public class Employee : User
  {
	public string Login { get; set; }

	public string Password { get; set; }

	public string Phone { get; set; }

	public string Position { get; set; }

	public DateTime? LastExit { get; set; }

	public Roles Role { get; set; } = Roles.User;
  }
}