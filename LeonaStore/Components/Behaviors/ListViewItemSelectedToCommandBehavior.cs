using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Behaviors
{
	public class ListViewItemSelectedToCommandBehavior : Behavior<ListView>
	{
		ListView _associatedObject;

		public static readonly BindableProperty CommandProperty =
			BindableProperty.Create("Command",
									typeof(ICommand),
									typeof(ListViewItemSelectedToCommandBehavior),
									null);

		public ICommand Command
		{
			get { return (ICommand)GetValue(CommandProperty); }
			set { SetValue(CommandProperty, value); }
		}

		protected override void OnAttachedTo(ListView bindable)
		{
			base.OnAttachedTo(bindable);

			_associatedObject = bindable;

			_associatedObject.ItemSelected += OnItemSelected;

			if (_associatedObject.BindingContext != null)
				BindingContext = _associatedObject.BindingContext;

			_associatedObject.BindingContextChanged += OnContextChanged;
		}

		void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem == null || Command == null)
				return;

			if (Command.CanExecute(null))
				Command.Execute(e.SelectedItem);
		}

		void OnContextChanged(object sender, EventArgs e)
		{
			BindingContext = _associatedObject.BindingContext;
		}

		protected override void OnDetachingFrom(ListView bindable)
		{
			base.OnDetachingFrom(bindable);

			_associatedObject = bindable;

			_associatedObject.BindingContextChanged -= OnContextChanged;

			_associatedObject.ItemSelected -= OnItemSelected;

			BindingContext = null;
		}
	}
}
