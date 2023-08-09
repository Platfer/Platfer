# Copyright 2023 Cyril John Magayaga
# Platfer Preview (v2.0-preview4)
# Linux operating system
import gi
gi.require_version('Gtk', '3.0')
gi.require_version('WebKit2', '4.1')
from gi.repository import Gtk, WebKit2

class Platfer:
    def __init__(self):
        self.linux = Gtk.Window()
        self.linux.set_title("Platfer Preview")
        self.linux.set_default_size(950, 600)

        self.init_ui()

    def init_ui(self):
        self.notebook_button = Gtk.Button.new_with_label("New Tab")
        self.notebook_button.connect("clicked", self.notebook)

        self.about_button = Gtk.Button.new_with_label("About")
        self.about_button.connect("clicked", self.go_about)

        self.search_button = Gtk.Button.new_with_label("Search")
        self.search_button.connect("clicked", self.on_enter)

        self.navbar = Gtk.HeaderBar()
        self.navbar.set_show_close_button(True)
        self.linux.set_titlebar(self.navbar)

        self.entry = Gtk.Entry()
        self.entry.set_width_chars(40)
        self.entry.connect("activate", self.enter)
        self.navbar.set_custom_title(self.entry)

        self.go_back_button = Gtk.Button.new_from_icon_name("go-previous", Gtk.IconSize.SMALL_TOOLBAR)
        self.go_back_button.connect("clicked", self.go_back)
        self.navbar.pack_start(self.go_back_button)

        self.go_forward_button = Gtk.Button.new_from_icon_name("go-next", Gtk.IconSize.SMALL_TOOLBAR)
        self.go_forward_button.connect("clicked", self.go_forward)
        self.navbar.pack_start(self.go_forward_button)

        self.go_refresh_button = Gtk.Button.new_from_icon_name("view-refresh", Gtk.IconSize.SMALL_TOOLBAR)
        self.go_refresh_button.connect("clicked", self.go_refresh)
        self.navbar.pack_start(self.go_refresh_button)

        self.go_home_button = Gtk.Button.new_from_icon_name("go-home", Gtk.IconSize.SMALL_TOOLBAR)
        self.go_home_button.connect("clicked", self.go_home)
        self.navbar.pack_start(self.go_home_button)

        self.about_btn = Gtk.Image.new_from_icon_name("help-about", Gtk.IconSize.SMALL_TOOLBAR)
        self.about_button = Gtk.Button()
        self.about_button.add(self.about_btn)
        self.about_button.connect("clicked", self.go_about)
        self.navbar.pack_end(self.about_button)

        self.new_tab_btn = Gtk.Image.new_from_icon_name("list-add", Gtk.IconSize.SMALL_TOOLBAR)
        self.new_tab_button = Gtk.Button()
        self.new_tab_button.add(self.new_tab_btn)
        self.new_tab_button.connect("clicked", self.notebook)
        self.navbar.pack_end(self.new_tab_button)

        self.scrolledWindow = Gtk.ScrolledWindow()
        self.platfer = WebKit2.WebView()
        self.platfer.load_uri("https://www.google.com")
        self.platfer.connect("notify::estimated-load-progress", self.change_url)

        self.linux.connect("destroy", Gtk.main_quit)

        self.scrolledWindow.add(self.platfer)
        self.linux.add(self.scrolledWindow)
        self.linux.show_all()
        Gtk.main()

    def notebook(self, new_tab_button):
        window = Gtk.Window()
        window.set_default_size(400, 275)

        label = Gtk.Label()
        window.set_title("Platfer Fixing Errors")
        label.set_markup("<b><big>Platfer Preview</big></b>\nSorry, Fixing new multiple and unlimited tabs.")
        label.set_justify(Gtk.Justification.LEFT)
        label.set_line_wrap(True)
        window.add(label)

        label.show()
        window.show()

    def go_about(self, about_button):
        window = Gtk.Window()
        window.set_default_size(600, 275)

        label = Gtk.Label()
        window.set_title("About")
        label.set_markup("<b><big>Platfer Preview</big></b>\nThe Philippines' first web browser.\nIt was created, designed, and developed by <b>Cyril John Magayaga</b>.\n\n<b>Stable release</b>: (v2.0-preview4) August 9, 2023\nPowered by <b>WebKit</b> browser engine (2.39.5)\n\nCopyright 2022-2023 Cyril John Magayaga. All rights reserved.")
        label.set_justify(Gtk.Justification.LEFT)
        label.set_line_wrap(True)
        window.add(label)

        label.show()
        window.show()

    def on_enter(self, search_button):
        url = self.entry.get_text()
        if url.startswith("http://") or url.startswith("https://"):
            self.platfer.load_uri(url)
        else:
            platferurl = "https://" + url
            self.platferurl.set_text(url)
            self.platfer.load_uri(platferurl)

    def enter(self, entry):
        url = entry.get_text()
        if url.startswith("http://") or url.startswith("https://"):
            self.platfer.load_uri(url)
        else:
            platferurl = "https://" + url
            self.platferurl.set_text(url)
            self.platfer.load_uri(platferurl)

    def change_url(self, entry, widget, frame):
        uri = self.platfer.get_uri()
        self.entry.set_text(uri)

    def go_back(self, go_back_button):
        self.platfer.go_back()

    def go_forward(self, go_forward_button):
        self.platfer.go_forward()

    def go_refresh(self, go_refresh_button):
        self.platfer.reload()

    def go_home(self, go_home_button):
        self.platfer.load_uri("https://www.google.com")

if __name__ == "__main__":
    # All def to one class
    app = Platfer()
