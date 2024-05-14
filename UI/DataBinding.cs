using System.ComponentModel;
using Microsoft.VisualStudio.Modeling;
using Microsoft.VisualStudio.Modeling.Design;

namespace YaHZ.modeling_test
{
	// 
	/// <summary>
	/// This is a partial implementation of the ModelViewControl
	/// used to setup DataBinding of the DataGridView with the Model's data.
	/// 
	/// It also publishes the Winforms components for the SelectionPusher class to 
	/// synchronize selection between the Winforms controls and Visual Studio.
	/// </summary>
	partial class ModelViewControl
	{
		/// <summary>
		/// Access the set of components exposed by the form.
		/// </summary>
		/// <remarks>
		/// SelectionPusher component in the DocView class requires access to the set of components.
		/// </remarks>
		public IContainer Components
		{
			get
			{
				return this.components;
			}
		}

		/// <summary>
		/// Set up the initial binding to the topmost datasource (the model root)
		/// </summary>
		/// <remarks>
		/// Switches the binding from type-based for design-time to instance-based for runtime.
		/// </remarks>
		/// <param name="root">The top most node in the Data heirarchy to which the controls will bind</param>
		public void DataBind(ModelElement root)
		{
			//Prepare this Winforms for Databinding
			WinFormsDataBindingHelper.PreInitializeDataSources(this);

			//Setup the BindingSource to the root
			this.exampleModelBindingSource.DataSource = root;

			//Do the binding
			WinFormsDataBindingHelper.InitializeDataSources(this);
			this.UpdateFormState();
		}

		/// <summary>
		/// This is a hook to allow non-databound elements in the Winform to update their state
		/// based on current state of Data-bound elements.
		/// </summary>
		partial void UpdateFormState();
	}
}