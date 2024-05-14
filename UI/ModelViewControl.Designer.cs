namespace YaHZ.modeling_test
{
	partial class ModelViewControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components;

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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Label elementsLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelViewControl));
			System.Windows.Forms.Label nameLabel;
			this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.removeSelectionButton = new System.Windows.Forms.Button();
			this.addElementButton = new System.Windows.Forms.Button();
			this.exampleModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.exampleElementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.exampleElementsDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			elementsLabel = new System.Windows.Forms.Label();
			nameLabel = new System.Windows.Forms.Label();
			this.flowLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.exampleModelBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.exampleElementsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.exampleElementsDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// elementsLabel
			// 
			elementsLabel.AutoSize = true;
			elementsLabel.Location = new System.Drawing.Point(13, 55);
			elementsLabel.Name = "elementsLabel";
			elementsLabel.Size = new System.Drawing.Size(53, 13);
			elementsLabel.TabIndex = 6;
			elementsLabel.Text = "Elements:";
			// 
			// flowLayoutPanel
			// 
			this.flowLayoutPanel.Controls.Add(this.removeSelectionButton);
			this.flowLayoutPanel.Controls.Add(this.addElementButton);
			this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel.Location = new System.Drawing.Point(69, 49);
			this.flowLayoutPanel.Name = "flowLayoutPanel";
			this.flowLayoutPanel.Size = new System.Drawing.Size(64, 30);
			this.flowLayoutPanel.TabIndex = 5;
			// 
			// removeSelectionButton
			// 
			this.removeSelectionButton.AutoSize = true;
			this.removeSelectionButton.Image = ((System.Drawing.Image)(resources.GetObject("removeSelectionButton.Image")));
			this.removeSelectionButton.Location = new System.Drawing.Point(3, 3);
			this.removeSelectionButton.Name = "removeSelectionButton";
			this.removeSelectionButton.Size = new System.Drawing.Size(24, 24);
			this.removeSelectionButton.TabIndex = 1;
			this.removeSelectionButton.UseVisualStyleBackColor = true;
			this.removeSelectionButton.Click += new System.EventHandler(this.removeSelectionButton_Click);
			// 
			// addElementButton
			// 
			this.addElementButton.AutoSize = true;
			this.addElementButton.Image = ((System.Drawing.Image)(resources.GetObject("addElementButton.Image")));
			this.addElementButton.Location = new System.Drawing.Point(33, 3);
			this.addElementButton.Name = "addElementButton";
			this.addElementButton.Size = new System.Drawing.Size(24, 24);
			this.addElementButton.TabIndex = 0;
			this.addElementButton.UseVisualStyleBackColor = true;
			this.addElementButton.Click += new System.EventHandler(this.addElementButton_Click);
			// 
			// exampleModelBindingSource
			// 
			this.exampleModelBindingSource.DataSource = typeof(YaHZ.modeling_test.ExampleModel);
			this.exampleModelBindingSource.CurrentChanged += this.BindingSource_CurrentChanged;
			// 
			// nameLabel
			// 
			nameLabel.AutoSize = true;
			nameLabel.Location = new System.Drawing.Point(13, 20);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new System.Drawing.Size(38, 13);
			nameLabel.TabIndex = 7;
			nameLabel.Text = "Name:";
			// 
			// nameTextBox
			// 
			this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exampleModelBindingSource, "Name", true));
			this.nameTextBox.Location = new System.Drawing.Point(69, 17);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(497, 20);
			this.nameTextBox.TabIndex = 8;
			// 
			// exampleElementsBindingSource
			// 
			this.exampleElementsBindingSource.DataMember = "ExampleElements";
			this.exampleElementsBindingSource.DataSource = this.exampleModelBindingSource;
			// 
			// exampleElementsDataGridView
			// 
			this.exampleElementsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.exampleElementsDataGridView.AutoGenerateColumns = false;
			this.exampleElementsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.exampleElementsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.dataGridViewTextBoxColumn1,
			this.dataGridViewTextBoxColumn2,
			this.dataGridViewTextBoxColumn3});
			this.exampleElementsDataGridView.DataSource = this.exampleElementsBindingSource;
			this.exampleElementsDataGridView.Location = new System.Drawing.Point(69, 82);
			this.exampleElementsDataGridView.Name = "exampleElementsDataGridView";
			this.exampleElementsDataGridView.Size = new System.Drawing.Size(497, 335);
			this.exampleElementsDataGridView.TabIndex = 8;
			this.exampleElementsDataGridView.Leave += this.elementsDataGridView_Leave;

			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn1.HeaderText = "Name";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Description";
			this.dataGridViewTextBoxColumn2.HeaderText = "Description";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Value";
			this.dataGridViewTextBoxColumn3.HeaderText = "Value";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// UserControl1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.exampleElementsDataGridView);
			this.Controls.Add(nameLabel);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(elementsLabel);
			this.Controls.Add(this.flowLayoutPanel);
			this.Name = "UserControl1";
			this.Size = new System.Drawing.Size(587, 437);
			this.flowLayoutPanel.ResumeLayout(false);
			this.flowLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.exampleModelBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.exampleElementsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.exampleElementsDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
		private System.Windows.Forms.Button removeSelectionButton;
		private System.Windows.Forms.Button addElementButton;
		private System.Windows.Forms.BindingSource exampleModelBindingSource;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.BindingSource exampleElementsBindingSource;
		private System.Windows.Forms.DataGridView exampleElementsDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
	}
}
