namespace AutomationParkingV2
{
  partial class RegistrationForm
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
	  this.lastName = new System.Windows.Forms.TextBox();
	  this.firstName = new System.Windows.Forms.TextBox();
	  this.patronymic = new System.Windows.Forms.TextBox();
	  this.label1 = new System.Windows.Forms.Label();
	  this.label2 = new System.Windows.Forms.Label();
	  this.label3 = new System.Windows.Forms.Label();
	  this.label4 = new System.Windows.Forms.Label();
	  this.login = new System.Windows.Forms.TextBox();
	  this.password = new System.Windows.Forms.TextBox();
	  this.label5 = new System.Windows.Forms.Label();
	  this.Registration = new System.Windows.Forms.Button();
	  this.phone = new System.Windows.Forms.TextBox();
	  this.label6 = new System.Windows.Forms.Label();
	  this.message = new System.Windows.Forms.Label();
	  this.SuspendLayout();
	  // 
	  // lastName
	  // 
	  this.lastName.Location = new System.Drawing.Point(75, 55);
	  this.lastName.Name = "lastName";
	  this.lastName.Size = new System.Drawing.Size(159, 20);
	  this.lastName.TabIndex = 0;
	  // 
	  // firstName
	  // 
	  this.firstName.Location = new System.Drawing.Point(75, 103);
	  this.firstName.Name = "firstName";
	  this.firstName.Size = new System.Drawing.Size(159, 20);
	  this.firstName.TabIndex = 1;
	  // 
	  // patronymic
	  // 
	  this.patronymic.Location = new System.Drawing.Point(75, 152);
	  this.patronymic.Name = "patronymic";
	  this.patronymic.Size = new System.Drawing.Size(159, 20);
	  this.patronymic.TabIndex = 2;
	  // 
	  // label1
	  // 
	  this.label1.AutoSize = true;
	  this.label1.Location = new System.Drawing.Point(72, 39);
	  this.label1.Name = "label1";
	  this.label1.Size = new System.Drawing.Size(56, 13);
	  this.label1.TabIndex = 3;
	  this.label1.Text = "Фамилия";
	  // 
	  // label2
	  // 
	  this.label2.AutoSize = true;
	  this.label2.Location = new System.Drawing.Point(72, 87);
	  this.label2.Name = "label2";
	  this.label2.Size = new System.Drawing.Size(29, 13);
	  this.label2.TabIndex = 4;
	  this.label2.Text = "Имя";
	  // 
	  // label3
	  // 
	  this.label3.AutoSize = true;
	  this.label3.Location = new System.Drawing.Point(72, 136);
	  this.label3.Name = "label3";
	  this.label3.Size = new System.Drawing.Size(54, 13);
	  this.label3.TabIndex = 5;
	  this.label3.Text = "Отчество";
	  // 
	  // label4
	  // 
	  this.label4.AutoSize = true;
	  this.label4.Location = new System.Drawing.Point(74, 187);
	  this.label4.Name = "label4";
	  this.label4.Size = new System.Drawing.Size(38, 13);
	  this.label4.TabIndex = 6;
	  this.label4.Text = "Логин";
	  // 
	  // login
	  // 
	  this.login.Location = new System.Drawing.Point(75, 203);
	  this.login.Name = "login";
	  this.login.Size = new System.Drawing.Size(159, 20);
	  this.login.TabIndex = 7;
	  // 
	  // password
	  // 
	  this.password.Location = new System.Drawing.Point(77, 252);
	  this.password.Name = "password";
	  this.password.Size = new System.Drawing.Size(159, 20);
	  this.password.TabIndex = 9;
	  // 
	  // label5
	  // 
	  this.label5.AutoSize = true;
	  this.label5.Location = new System.Drawing.Point(76, 236);
	  this.label5.Name = "label5";
	  this.label5.Size = new System.Drawing.Size(45, 13);
	  this.label5.TabIndex = 8;
	  this.label5.Text = "Пароль";
	  // 
	  // Registration
	  // 
	  this.Registration.Location = new System.Drawing.Point(77, 334);
	  this.Registration.Name = "Registration";
	  this.Registration.Size = new System.Drawing.Size(161, 23);
	  this.Registration.TabIndex = 10;
	  this.Registration.Text = "Регистрация";
	  this.Registration.UseVisualStyleBackColor = true;
	  this.Registration.Click += new System.EventHandler(this.Registration_Click);
	  // 
	  // phone
	  // 
	  this.phone.Location = new System.Drawing.Point(77, 301);
	  this.phone.Name = "phone";
	  this.phone.Size = new System.Drawing.Size(159, 20);
	  this.phone.TabIndex = 12;
	  // 
	  // label6
	  // 
	  this.label6.AutoSize = true;
	  this.label6.Location = new System.Drawing.Point(76, 285);
	  this.label6.Name = "label6";
	  this.label6.Size = new System.Drawing.Size(52, 13);
	  this.label6.TabIndex = 11;
	  this.label6.Text = "Телефон";
	  // 
	  // message
	  // 
	  this.message.AutoSize = true;
	  this.message.Location = new System.Drawing.Point(72, 9);
	  this.message.Name = "message";
	  this.message.Size = new System.Drawing.Size(0, 13);
	  this.message.TabIndex = 13;
	  // 
	  // RegistrationForm
	  // 
	  this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
	  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	  this.ClientSize = new System.Drawing.Size(319, 414);
	  this.Controls.Add(this.message);
	  this.Controls.Add(this.phone);
	  this.Controls.Add(this.label6);
	  this.Controls.Add(this.Registration);
	  this.Controls.Add(this.password);
	  this.Controls.Add(this.label5);
	  this.Controls.Add(this.login);
	  this.Controls.Add(this.label4);
	  this.Controls.Add(this.label3);
	  this.Controls.Add(this.label2);
	  this.Controls.Add(this.label1);
	  this.Controls.Add(this.patronymic);
	  this.Controls.Add(this.firstName);
	  this.Controls.Add(this.lastName);
	  this.Name = "RegistrationForm";
	  this.Text = "Регистрация";
	  this.ResumeLayout(false);
	  this.PerformLayout();

	}

	#endregion

	private System.Windows.Forms.TextBox lastName;
	private System.Windows.Forms.TextBox firstName;
	private System.Windows.Forms.TextBox patronymic;
	private System.Windows.Forms.Label label1;
	private System.Windows.Forms.Label label2;
	private System.Windows.Forms.Label label3;
	private System.Windows.Forms.Label label4;
	private System.Windows.Forms.TextBox login;
	private System.Windows.Forms.TextBox password;
	private System.Windows.Forms.Label label5;
	private System.Windows.Forms.Button Registration;
	private System.Windows.Forms.TextBox phone;
	private System.Windows.Forms.Label label6;
	private System.Windows.Forms.Label message;
  }
}