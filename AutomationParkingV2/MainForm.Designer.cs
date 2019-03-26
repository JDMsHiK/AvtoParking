namespace AutomationParkingV2
{
  partial class MainForm
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
	  this.customersTab = new System.Windows.Forms.TabControl();
	  this.tabPage1 = new System.Windows.Forms.TabPage();
	  this.customerGrid = new System.Windows.Forms.DataGridView();
	  this.tabPage2 = new System.Windows.Forms.TabPage();
	  this.employeeGrid = new System.Windows.Forms.DataGridView();
	  this.tabPage3 = new System.Windows.Forms.TabPage();
	  this.arrivalGrid = new System.Windows.Forms.DataGridView();
	  this.tabPage4 = new System.Windows.Forms.TabPage();
	  this.departureGrid = new System.Windows.Forms.DataGridView();
	  this.tabPage5 = new System.Windows.Forms.TabPage();
	  this.typeCarGrid = new System.Windows.Forms.DataGridView();
	  this.customersTab.SuspendLayout();
	  this.tabPage1.SuspendLayout();
	  ((System.ComponentModel.ISupportInitialize)(this.customerGrid)).BeginInit();
	  this.tabPage2.SuspendLayout();
	  ((System.ComponentModel.ISupportInitialize)(this.employeeGrid)).BeginInit();
	  this.tabPage3.SuspendLayout();
	  ((System.ComponentModel.ISupportInitialize)(this.arrivalGrid)).BeginInit();
	  this.tabPage4.SuspendLayout();
	  ((System.ComponentModel.ISupportInitialize)(this.departureGrid)).BeginInit();
	  this.tabPage5.SuspendLayout();
	  ((System.ComponentModel.ISupportInitialize)(this.typeCarGrid)).BeginInit();
	  this.SuspendLayout();
	  // 
	  // customersTab
	  // 
	  this.customersTab.Controls.Add(this.tabPage1);
	  this.customersTab.Controls.Add(this.tabPage2);
	  this.customersTab.Controls.Add(this.tabPage3);
	  this.customersTab.Controls.Add(this.tabPage4);
	  this.customersTab.Controls.Add(this.tabPage5);
	  this.customersTab.Dock = System.Windows.Forms.DockStyle.Fill;
	  this.customersTab.Location = new System.Drawing.Point(0, 0);
	  this.customersTab.Name = "customersTab";
	  this.customersTab.SelectedIndex = 0;
	  this.customersTab.Size = new System.Drawing.Size(721, 363);
	  this.customersTab.TabIndex = 0;
	  this.customersTab.Selected += new System.Windows.Forms.TabControlEventHandler(this.customersTab_Selected);
	  // 
	  // tabPage1
	  // 
	  this.tabPage1.AutoScroll = true;
	  this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
	  this.tabPage1.Controls.Add(this.customerGrid);
	  this.tabPage1.Location = new System.Drawing.Point(4, 22);
	  this.tabPage1.Name = "tabPage1";
	  this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
	  this.tabPage1.Size = new System.Drawing.Size(713, 337);
	  this.tabPage1.TabIndex = 0;
	  this.tabPage1.Text = "Клиенты";
	  this.tabPage1.UseVisualStyleBackColor = true;
	  // 
	  // customerGrid
	  // 
	  this.customerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
	  this.customerGrid.Dock = System.Windows.Forms.DockStyle.Fill;
	  this.customerGrid.Location = new System.Drawing.Point(3, 3);
	  this.customerGrid.Name = "customerGrid";
	  this.customerGrid.Size = new System.Drawing.Size(705, 329);
	  this.customerGrid.TabIndex = 0;
	  this.customerGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerGrid_CellValueChanged);
	  this.customerGrid.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.customerGrid_UserAddedRow);
	  this.customerGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.customerGrid_MouseClick);
	  // 
	  // tabPage2
	  // 
	  this.tabPage2.Controls.Add(this.employeeGrid);
	  this.tabPage2.Location = new System.Drawing.Point(4, 22);
	  this.tabPage2.Name = "tabPage2";
	  this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
	  this.tabPage2.Size = new System.Drawing.Size(713, 337);
	  this.tabPage2.TabIndex = 1;
	  this.tabPage2.Text = "Сотрудники";
	  this.tabPage2.UseVisualStyleBackColor = true;
	  // 
	  // employeeGrid
	  // 
	  this.employeeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
	  this.employeeGrid.Dock = System.Windows.Forms.DockStyle.Fill;
	  this.employeeGrid.Location = new System.Drawing.Point(3, 3);
	  this.employeeGrid.Name = "employeeGrid";
	  this.employeeGrid.Size = new System.Drawing.Size(707, 331);
	  this.employeeGrid.TabIndex = 0;
	  this.employeeGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeGrid_CellValueChanged);
	  this.employeeGrid.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.employeeGrid_UserAddedRow);
	  this.employeeGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.employeeGrid_MouseClick);
	  // 
	  // tabPage3
	  // 
	  this.tabPage3.Controls.Add(this.arrivalGrid);
	  this.tabPage3.Location = new System.Drawing.Point(4, 22);
	  this.tabPage3.Name = "tabPage3";
	  this.tabPage3.Size = new System.Drawing.Size(713, 337);
	  this.tabPage3.TabIndex = 2;
	  this.tabPage3.Text = "Заезд";
	  this.tabPage3.UseVisualStyleBackColor = true;
	  // 
	  // arrivalGrid
	  // 
	  this.arrivalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
	  this.arrivalGrid.Dock = System.Windows.Forms.DockStyle.Fill;
	  this.arrivalGrid.Location = new System.Drawing.Point(0, 0);
	  this.arrivalGrid.Name = "arrivalGrid";
	  this.arrivalGrid.Size = new System.Drawing.Size(713, 337);
	  this.arrivalGrid.TabIndex = 1;
	  this.arrivalGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.arrivalGrid_CellValueChanged);
	  this.arrivalGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.arrivalGrid_DataError);
	  this.arrivalGrid.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.arrivalGrid_UserAddedRow);
	  this.arrivalGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.arrivalGrid_MouseClick);
	  // 
	  // tabPage4
	  // 
	  this.tabPage4.Controls.Add(this.departureGrid);
	  this.tabPage4.Location = new System.Drawing.Point(4, 22);
	  this.tabPage4.Name = "tabPage4";
	  this.tabPage4.Size = new System.Drawing.Size(713, 337);
	  this.tabPage4.TabIndex = 3;
	  this.tabPage4.Text = "Выезд";
	  this.tabPage4.UseVisualStyleBackColor = true;
	  // 
	  // departureGrid
	  // 
	  this.departureGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
	  this.departureGrid.Dock = System.Windows.Forms.DockStyle.Fill;
	  this.departureGrid.Location = new System.Drawing.Point(0, 0);
	  this.departureGrid.Name = "departureGrid";
	  this.departureGrid.Size = new System.Drawing.Size(713, 337);
	  this.departureGrid.TabIndex = 2;
	  this.departureGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.departureGrid_CellValueChanged);
	  this.departureGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.departureGrid_DataError);
	  this.departureGrid.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.departureGrid_UserAddedRow);
	  this.departureGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.departureGrid_MouseClick);
	  // 
	  // tabPage5
	  // 
	  this.tabPage5.Controls.Add(this.typeCarGrid);
	  this.tabPage5.Location = new System.Drawing.Point(4, 22);
	  this.tabPage5.Name = "tabPage5";
	  this.tabPage5.Size = new System.Drawing.Size(713, 337);
	  this.tabPage5.TabIndex = 4;
	  this.tabPage5.Text = "Тип машины";
	  this.tabPage5.UseVisualStyleBackColor = true;
	  // 
	  // typeCarGrid
	  // 
	  this.typeCarGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
	  this.typeCarGrid.Dock = System.Windows.Forms.DockStyle.Fill;
	  this.typeCarGrid.Location = new System.Drawing.Point(0, 0);
	  this.typeCarGrid.Name = "typeCarGrid";
	  this.typeCarGrid.Size = new System.Drawing.Size(713, 337);
	  this.typeCarGrid.TabIndex = 3;
	  this.typeCarGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.typeCarGrid_CellValueChanged);
	  this.typeCarGrid.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.typeCarGrid_UserAddedRow);
	  this.typeCarGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.typeCarGrid_MouseClick);
	  // 
	  // MainForm
	  // 
	  this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
	  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	  this.ClientSize = new System.Drawing.Size(721, 363);
	  this.Controls.Add(this.customersTab);
	  this.Name = "MainForm";
	  this.Text = "Главная";
	  this.Load += new System.EventHandler(this.MainForm_Load);
	  this.customersTab.ResumeLayout(false);
	  this.tabPage1.ResumeLayout(false);
	  ((System.ComponentModel.ISupportInitialize)(this.customerGrid)).EndInit();
	  this.tabPage2.ResumeLayout(false);
	  ((System.ComponentModel.ISupportInitialize)(this.employeeGrid)).EndInit();
	  this.tabPage3.ResumeLayout(false);
	  ((System.ComponentModel.ISupportInitialize)(this.arrivalGrid)).EndInit();
	  this.tabPage4.ResumeLayout(false);
	  ((System.ComponentModel.ISupportInitialize)(this.departureGrid)).EndInit();
	  this.tabPage5.ResumeLayout(false);
	  ((System.ComponentModel.ISupportInitialize)(this.typeCarGrid)).EndInit();
	  this.ResumeLayout(false);

	}

	#endregion

	private System.Windows.Forms.TabControl customersTab;
	public System.Windows.Forms.TabPage tabPage1;
	private System.Windows.Forms.TabPage tabPage2;
	private System.Windows.Forms.DataGridView customerGrid;
	private System.Windows.Forms.TabPage tabPage3;
	private System.Windows.Forms.TabPage tabPage4;
	private System.Windows.Forms.TabPage tabPage5;
	private System.Windows.Forms.DataGridView employeeGrid;
	private System.Windows.Forms.DataGridView arrivalGrid;
	private System.Windows.Forms.DataGridView departureGrid;
	private System.Windows.Forms.DataGridView typeCarGrid;
  }
}