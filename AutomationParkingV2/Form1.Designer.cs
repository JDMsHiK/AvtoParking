namespace AutomationParkingV2
{
  partial class LoginForm
  {
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	/// Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing)
	{
	  if (disposing && (components != null))
	  {
		components.Dispose();
	  }
	  base.Dispose(disposing);
	}

	#region Windows Form Designer generated code

	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
	  this.loginLabel = new System.Windows.Forms.Label();
	  this.passwordLabel = new System.Windows.Forms.Label();
	  this.login = new System.Windows.Forms.TextBox();
	  this.password = new System.Windows.Forms.TextBox();
	  this.LoginButton = new System.Windows.Forms.Button();
	  this.ExitButton = new System.Windows.Forms.Button();
	  this.RegistrationButton = new System.Windows.Forms.Button();
	  this.LoginError = new System.Windows.Forms.Label();
	  this.SuspendLayout();
	  // 
	  // loginLabel
	  // 
	  this.loginLabel.AutoSize = true;
	  this.loginLabel.Location = new System.Drawing.Point(62, 59);
	  this.loginLabel.Name = "loginLabel";
	  this.loginLabel.Size = new System.Drawing.Size(38, 13);
	  this.loginLabel.TabIndex = 0;
	  this.loginLabel.Text = "Логин";
	  // 
	  // passwordLabel
	  // 
	  this.passwordLabel.AutoSize = true;
	  this.passwordLabel.Location = new System.Drawing.Point(62, 117);
	  this.passwordLabel.Name = "passwordLabel";
	  this.passwordLabel.Size = new System.Drawing.Size(45, 13);
	  this.passwordLabel.TabIndex = 1;
	  this.passwordLabel.Text = "Пароль";
	  // 
	  // login
	  // 
	  this.login.Location = new System.Drawing.Point(65, 75);
	  this.login.Name = "login";
	  this.login.Size = new System.Drawing.Size(304, 20);
	  this.login.TabIndex = 2;
	  // 
	  // password
	  // 
	  this.password.Location = new System.Drawing.Point(65, 133);
	  this.password.Name = "password";
	  this.password.Size = new System.Drawing.Size(304, 20);
	  this.password.TabIndex = 3;
	  // 
	  // LoginButton
	  // 
	  this.LoginButton.Location = new System.Drawing.Point(65, 169);
	  this.LoginButton.Name = "LoginButton";
	  this.LoginButton.Size = new System.Drawing.Size(145, 23);
	  this.LoginButton.TabIndex = 4;
	  this.LoginButton.Text = "Вход";
	  this.LoginButton.UseVisualStyleBackColor = true;
	  this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
	  // 
	  // ExitButton
	  // 
	  this.ExitButton.Location = new System.Drawing.Point(65, 200);
	  this.ExitButton.Name = "ExitButton";
	  this.ExitButton.Size = new System.Drawing.Size(304, 23);
	  this.ExitButton.TabIndex = 5;
	  this.ExitButton.Text = "Выход";
	  this.ExitButton.UseVisualStyleBackColor = true;
	  this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
	  // 
	  // RegistrationButton
	  // 
	  this.RegistrationButton.Location = new System.Drawing.Point(216, 169);
	  this.RegistrationButton.Name = "RegistrationButton";
	  this.RegistrationButton.Size = new System.Drawing.Size(153, 23);
	  this.RegistrationButton.TabIndex = 6;
	  this.RegistrationButton.Text = "Регистрация";
	  this.RegistrationButton.UseVisualStyleBackColor = true;
	  this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
	  // 
	  // LoginError
	  // 
	  this.LoginError.AutoSize = true;
	  this.LoginError.Location = new System.Drawing.Point(65, 31);
	  this.LoginError.Name = "LoginError";
	  this.LoginError.Size = new System.Drawing.Size(0, 13);
	  this.LoginError.TabIndex = 7;
	  // 
	  // LoginForm
	  // 
	  this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
	  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	  this.ClientSize = new System.Drawing.Size(433, 295);
	  this.Controls.Add(this.LoginError);
	  this.Controls.Add(this.RegistrationButton);
	  this.Controls.Add(this.ExitButton);
	  this.Controls.Add(this.LoginButton);
	  this.Controls.Add(this.password);
	  this.Controls.Add(this.login);
	  this.Controls.Add(this.passwordLabel);
	  this.Controls.Add(this.loginLabel);
	  this.Name = "LoginForm";
	  this.Text = "Вход";
	  this.ResumeLayout(false);
	  this.PerformLayout();

	}

	#endregion

	private System.Windows.Forms.Label loginLabel;
	private System.Windows.Forms.Label passwordLabel;
	private System.Windows.Forms.TextBox login;
	private System.Windows.Forms.TextBox password;
	private System.Windows.Forms.Button LoginButton;
	private System.Windows.Forms.Button ExitButton;
	private System.Windows.Forms.Button RegistrationButton;
	private System.Windows.Forms.Label LoginError;
  }
}

