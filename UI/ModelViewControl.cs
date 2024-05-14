using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualStudio.Modeling;

namespace YaHZ.modeling_test
{
	/// <summary>
	/// Winform UI control which will represent the Model's Data
	/// </summary>
	public partial class ModelViewControl : UserControl
	{
		#region Constructor(s)
		/// <summary>
		/// Constructor
		/// </summary>
		public ModelViewControl()
		{
			InitializeComponent();
			//Subscribe to KeyDown event to trap the DEL key and handle it.
			this.exampleElementsDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(exampleElementsDataGridView_KeyDown);
		}
		#endregion

		#region Properties
		/// <summary>
		/// Strongly typed access to the Model
		/// </summary>
		ExampleModel Model
		{
			get
			{
				return this.exampleModelBindingSource.DataSource as ExampleModel;
			}
		}
		#endregion

		#region Event handling
		/// <summary>
		/// Adding a new ExampleElement in the Model 
		/// which will be represented by a new row in the Winforms control.
		/// </summary>
		private void addElementButton_Click(object sender, EventArgs e)
		{
			//Adds a new ExampleElement to the Model.
			//Notifications will be fired automatically to update the View.
			Model.ExampleElements.AddNew();
		}

		/// <summary>
		/// Removing the selected rows deletes the selected ExampleElements
		/// from the Model and updates the View
		/// </summary>
		private void removeSelectionButton_Click(object sender, EventArgs e)
		{
			this.DeleteSelectedRows();
		}

		/// <summary>
		/// Handles the "DEL" key event to remove elements from the DataGridView.
		/// 
		/// We need to handle this event and delete ModelElements ourselves because
		/// the underlying collection requires you to open a ModelingTransaction to commit changes.
		/// Databinding, by default if we did not intercept this event, 
		/// will simply call the Remove API on the collection which will 
		/// result in an exception as a transaction will not be active.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void exampleElementsDataGridView_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				this.DeleteSelectedRows();
				e.Handled = true;
			}
		}

		/// <summary>
		/// Handles focus loss event for DataGridView
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void elementsDataGridView_Leave(object sender, EventArgs e)
		{
			// Cancel edits to the special AddNew row in the grid when it loses focus.
			// Stops us being able to add attributes to a temporary class produced using AddNew.
			this.exampleModelBindingSource.CancelEdit();
			this.UpdateFormState();
		}

		/// <summary>
		/// Update the state of non-databound controls when the BindingSource changes
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BindingSource_CurrentChanged(object sender, EventArgs e)
		{
			this.UpdateFormState();
		}
		#endregion

		#region Helpers
		// Update the non-data-bound parts of the form to math the current state of the data
		// This is a good pattern to use on partially databound forms.
		[SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Justification = "Eventually this method will use the \"this\" keyword")]
		partial void UpdateFormState()
		{
			// Update the state of any non-bound controls based on the current state of the 
			// data sources here.
		}

		private void DeleteSelectedRows()
		{
			// Any modification to the model must be done in the context of a ModelingTransaction
			using (Transaction t = this.Model.Store.TransactionManager.BeginTransaction("Deleting Elements"))
			{
				// The last row of the DataGrid is NOT a ModelElement, and the user can select it
				// we must only take into account the ModelElements
				IEnumerable<ModelElement> selection = (from DataGridViewRow row in exampleElementsDataGridView.SelectedRows select row.DataBoundItem).OfType<ModelElement>();
				foreach (ModelElement mel in selection)
				{
					mel.Delete();
				}
				t.Commit();
			}
		}
		#endregion
	}
}
