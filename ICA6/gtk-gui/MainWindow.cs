
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.ScrolledWindow scrolledwindow2;

	private global::Gtk.HBox hbox8;

	private global::Gtk.VBox vbox4;

	private global::Gtk.Button button4;

	private global::Gtk.Button button3;

	private global::Gtk.Button restock;

	private global::Gtk.Button search;

	private global::Gtk.Button delete;

	private global::Gtk.VBox vbox2;

	private global::Gtk.Label label1;

	private global::Gtk.Entry entry4;

	private global::Gtk.Label label2;

	private global::Gtk.Entry entry2;

	private global::Gtk.Label label3;

	private global::Gtk.Entry entry3;

	private global::Gtk.Label label5;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.scrolledwindow2 = new global::Gtk.ScrolledWindow();
		this.scrolledwindow2.CanFocus = true;
		this.scrolledwindow2.Name = "scrolledwindow2";
		this.scrolledwindow2.ShadowType = ((global::Gtk.ShadowType)(1));
		this.scrolledwindow2.BorderWidth = ((uint)(15));
		// Container child scrolledwindow2.Gtk.Container+ContainerChild
		global::Gtk.Viewport w1 = new global::Gtk.Viewport();
		w1.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child GtkViewport.Gtk.Container+ContainerChild
		this.hbox8 = new global::Gtk.HBox();
		this.hbox8.Name = "hbox8";
		this.hbox8.Spacing = 6;
		// Container child hbox8.Gtk.Box+BoxChild
		this.vbox4 = new global::Gtk.VBox();
		this.vbox4.Name = "vbox4";
		this.vbox4.Spacing = 6;
		// Container child vbox4.Gtk.Box+BoxChild
		this.button4 = new global::Gtk.Button();
		this.button4.CanFocus = true;
		this.button4.Name = "button4";
		this.button4.UseUnderline = true;
		this.button4.Label = global::Mono.Unix.Catalog.GetString("Display Products");
		this.vbox4.Add(this.button4);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.button4]));
		w2.Position = 0;
		w2.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.button3 = new global::Gtk.Button();
		this.button3.CanFocus = true;
		this.button3.Name = "button3";
		this.button3.UseUnderline = true;
		this.button3.Label = global::Mono.Unix.Catalog.GetString("Add Product");
		this.vbox4.Add(this.button3);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.button3]));
		w3.Position = 1;
		w3.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.restock = new global::Gtk.Button();
		this.restock.CanFocus = true;
		this.restock.Name = "restock";
		this.restock.UseUnderline = true;
		this.restock.Label = global::Mono.Unix.Catalog.GetString("Restock Product");
		this.vbox4.Add(this.restock);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.restock]));
		w4.Position = 2;
		w4.Expand = false;
		w4.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.search = new global::Gtk.Button();
		this.search.CanFocus = true;
		this.search.Name = "search";
		this.search.UseUnderline = true;
		this.search.Label = global::Mono.Unix.Catalog.GetString("Search");
		this.vbox4.Add(this.search);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.search]));
		w5.PackType = ((global::Gtk.PackType)(1));
		w5.Position = 3;
		w5.Expand = false;
		w5.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.delete = new global::Gtk.Button();
		this.delete.CanFocus = true;
		this.delete.Name = "delete";
		this.delete.UseUnderline = true;
		this.delete.Label = global::Mono.Unix.Catalog.GetString("Delete Product");
		this.vbox4.Add(this.delete);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.delete]));
		w6.PackType = ((global::Gtk.PackType)(1));
		w6.Position = 4;
		w6.Expand = false;
		w6.Fill = false;
		this.hbox8.Add(this.vbox4);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.vbox4]));
		w7.Position = 0;
		w7.Expand = false;
		// Container child hbox8.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Product Name");
		this.vbox2.Add(this.label1);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.label1]));
		w8.Position = 0;
		// Container child vbox2.Gtk.Box+BoxChild
		this.entry4 = new global::Gtk.Entry();
		this.entry4.CanFocus = true;
		this.entry4.Name = "entry4";
		this.entry4.IsEditable = true;
		this.entry4.InvisibleChar = '•';
		this.vbox2.Add(this.entry4);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.entry4]));
		w9.Position = 1;
		w9.Expand = false;
		w9.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.label2 = new global::Gtk.Label();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Product Qauntity");
		this.vbox2.Add(this.label2);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.label2]));
		w10.Position = 2;
		// Container child vbox2.Gtk.Box+BoxChild
		this.entry2 = new global::Gtk.Entry();
		this.entry2.CanFocus = true;
		this.entry2.Name = "entry2";
		this.entry2.IsEditable = true;
		this.entry2.InvisibleChar = '•';
		this.vbox2.Add(this.entry2);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.entry2]));
		w11.Position = 3;
		w11.Expand = false;
		w11.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.label3 = new global::Gtk.Label();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Price");
		this.vbox2.Add(this.label3);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.label3]));
		w12.Position = 4;
		// Container child vbox2.Gtk.Box+BoxChild
		this.entry3 = new global::Gtk.Entry();
		this.entry3.CanFocus = true;
		this.entry3.Name = "entry3";
		this.entry3.IsEditable = true;
		this.entry3.InvisibleChar = '•';
		this.vbox2.Add(this.entry3);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.entry3]));
		w13.Position = 5;
		w13.Expand = false;
		w13.Fill = false;
		this.hbox8.Add(this.vbox2);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.vbox2]));
		w14.Position = 1;
		w14.Expand = false;
		w14.Fill = false;
		// Container child hbox8.Gtk.Box+BoxChild
		this.label5 = new global::Gtk.Label();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("label5");
		this.hbox8.Add(this.label5);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.label5]));
		w15.Position = 2;
		w1.Add(this.hbox8);
		this.scrolledwindow2.Add(w1);
		this.Add(this.scrolledwindow2);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 597;
		this.DefaultHeight = 401;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.button4.Clicked += new global::System.EventHandler(this.OnButton4Clicked);
		this.button3.Clicked += new global::System.EventHandler(this.OnButton3Clicked);
		this.restock.Clicked += new global::System.EventHandler(this.OnRestockClicked);
		this.delete.Clicked += new global::System.EventHandler(this.OnDeleteClicked);
		this.search.Clicked += new global::System.EventHandler(this.OnSearchClicked);
	}
}
