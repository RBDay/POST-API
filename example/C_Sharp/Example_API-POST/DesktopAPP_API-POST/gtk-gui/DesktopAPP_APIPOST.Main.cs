
// This file has been generated by the GUI designer. Do not modify.
namespace DesktopAPP_APIPOST
{
	public partial class Main
	{
		private global::Gtk.Fixed fixed3;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.NodeView nodeCampaigns;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget DesktopAPP_APIPOST.Main
			this.Name = "DesktopAPP_APIPOST.Main";
			this.Title = global::Mono.Unix.Catalog.GetString ("Main");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child DesktopAPP_APIPOST.Main.Gtk.Container+ContainerChild
			this.fixed3 = new global::Gtk.Fixed ();
			this.fixed3.Name = "fixed3";
			this.fixed3.HasWindow = false;
			// Container child fixed3.Gtk.Fixed+FixedChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.nodeCampaigns = new global::Gtk.NodeView ();
			this.nodeCampaigns.CanFocus = true;
			this.nodeCampaigns.Name = "nodeCampaigns";
			this.GtkScrolledWindow.Add (this.nodeCampaigns);
			this.fixed3.Add (this.GtkScrolledWindow);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed3 [this.GtkScrolledWindow]));
			w2.X = 33;
			w2.Y = 47;
			this.Add (this.fixed3);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 787;
			this.DefaultHeight = 478;
			this.Show ();
		}
	}
}