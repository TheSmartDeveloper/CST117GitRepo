
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.ScrolledWindow scrolledwindow4;

	private global::Gtk.HBox hbox2;

	private global::Gtk.VBox vbox14;

	private global::Gtk.Label label1;

	private global::Gtk.Fixed fixed9;

	private global::Gtk.Label label2;

	private global::Gtk.VBox vbox13;

	private global::Gtk.Entry entry1;

	private global::Gtk.Button button1;

	private global::Gtk.Entry entry2;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.scrolledwindow4 = new global::Gtk.ScrolledWindow();
		this.scrolledwindow4.CanFocus = true;
		this.scrolledwindow4.Name = "scrolledwindow4";
		this.scrolledwindow4.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child scrolledwindow4.Gtk.Container+ContainerChild
		global::Gtk.Viewport w1 = new global::Gtk.Viewport();
		w1.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child GtkViewport.Gtk.Container+ContainerChild
		this.hbox2 = new global::Gtk.HBox();
		this.hbox2.Name = "hbox2";
		this.hbox2.Homogeneous = true;
		this.hbox2.Spacing = 27;
		this.hbox2.BorderWidth = ((uint)(25));
		// Container child hbox2.Gtk.Box+BoxChild
		this.vbox14 = new global::Gtk.VBox();
		this.vbox14.Name = "vbox14";
		this.vbox14.Homogeneous = true;
		this.vbox14.Spacing = 6;
		// Container child vbox14.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Weight on Earth");
		this.vbox14.Add(this.label1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox14[this.label1]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox14.Gtk.Box+BoxChild
		this.fixed9 = new global::Gtk.Fixed();
		this.fixed9.Name = "fixed9";
		this.fixed9.HasWindow = false;
		this.vbox14.Add(this.fixed9);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox14[this.fixed9]));
		w3.Position = 1;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox14.Gtk.Box+BoxChild
		this.label2 = new global::Gtk.Label();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Weight on Mars");
		this.vbox14.Add(this.label2);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox14[this.label2]));
		w4.Position = 2;
		w4.Expand = false;
		w4.Fill = false;
		this.hbox2.Add(this.vbox14);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vbox14]));
		w5.Position = 0;
		// Container child hbox2.Gtk.Box+BoxChild
		this.vbox13 = new global::Gtk.VBox();
		this.vbox13.Name = "vbox13";
		this.vbox13.Homogeneous = true;
		this.vbox13.Spacing = 6;
		// Container child vbox13.Gtk.Box+BoxChild
		this.entry1 = new global::Gtk.Entry();
		this.entry1.CanFocus = true;
		this.entry1.Name = "entry1";
		this.entry1.IsEditable = true;
		this.entry1.InvisibleChar = '•';
		this.vbox13.Add(this.entry1);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.entry1]));
		w6.Position = 0;
		w6.Expand = false;
		w6.Fill = false;
		// Container child vbox13.Gtk.Box+BoxChild
		this.button1 = new global::Gtk.Button();
		this.button1.CanFocus = true;
		this.button1.Name = "button1";
		this.button1.UseUnderline = true;
		this.button1.Label = global::Mono.Unix.Catalog.GetString("Calculate!!!");
		this.vbox13.Add(this.button1);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.button1]));
		w7.Position = 1;
		w7.Expand = false;
		w7.Fill = false;
		// Container child vbox13.Gtk.Box+BoxChild
		this.entry2 = new global::Gtk.Entry();
		this.entry2.CanFocus = true;
		this.entry2.Name = "entry2";
		this.entry2.IsEditable = true;
		this.entry2.InvisibleChar = '•';
		this.vbox13.Add(this.entry2);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.entry2]));
		w8.Position = 2;
		w8.Expand = false;
		w8.Fill = false;
		this.hbox2.Add(this.vbox13);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vbox13]));
		w9.Position = 1;
		w9.Expand = false;
		w1.Add(this.hbox2);
		this.scrolledwindow4.Add(w1);
		this.Add(this.scrolledwindow4);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 675;
		this.DefaultHeight = 292;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.button1.Clicked += new global::System.EventHandler(this.OnButton1Clicked);
	}
}
