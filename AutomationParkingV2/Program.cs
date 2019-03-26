using Autofac;
using AutomationParkingV2.Services.Abstractions;
using AutomationParkingV2.Services.Implementations;
using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomationParkingV2
{
  static class Program
  {
	/// <summary>
	/// The main entry point for the application.
	/// </summary>
	[STAThread]
	static void Main()
	{
	  //var kernel = new StandardKernel();
	  //kernel.Load(Assembly.GetExecutingAssembly());

	  //var loggerService = kernel.Get<ILogger>();
	  //var fileService = kernel.Get<IFileService>();

	  Application.EnableVisualStyles();
	  Application.SetCompatibleTextRenderingDefault(false);
	  Application.Run(new LoginForm());
	}
  }
}

//public class Bindings : NinjectModule
//{
//  public override void Load()
//  {
//	Bind<ILogger>().To<LoggerService>();
//	Bind<ISerializationService>().To<SerializationService>();
//	Bind<IFileService>().To<FileService>();
//  }
//}
