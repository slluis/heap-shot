
// This file has been generated by the GUI designer. Do not modify.
namespace HeapShot.Gui.Widgets
{
	public partial class ProgressDialog
	{
		private global::Gtk.VBox vbox2;
		private global::Gtk.Label label;
		private global::Gtk.ProgressBar progress;
		private global::Gtk.Button buttonCancel;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget HeapShot.Gui.Widgets.ProgressDialog
			this.Name = "HeapShot.Gui.Widgets.ProgressDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Heap Shot");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			this.AllowShrink = true;
			// Internal child HeapShot.Gui.Widgets.ProgressDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			this.vbox2.BorderWidth = ((uint)(6));
			// Container child vbox2.Gtk.Box+BoxChild
			this.label = new global::Gtk.Label ();
			this.label.Name = "label";
			this.label.Xalign = 0F;
			this.vbox2.Add (this.label);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.progress = new global::Gtk.ProgressBar ();
			this.progress.Name = "progress";
			this.vbox2.Add (this.progress);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.progress]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			w1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox2]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Internal child HeapShot.Gui.Widgets.ProgressDialog.ActionArea
			global::Gtk.HButtonBox w5 = this.ActionArea;
			w5.Name = "dialog1_ActionArea";
			w5.Spacing = 10;
			w5.BorderWidth = ((uint)(5));
			w5.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			w5.Add (this.buttonCancel);
			global::Gtk.ButtonBox.ButtonBoxChild w6 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w5 [this.buttonCancel]));
			w6.Expand = false;
			w6.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 127;
			this.Show ();
			this.buttonCancel.Clicked += new global::System.EventHandler (this.OnButtonCancelClicked);
		}
	}
}
