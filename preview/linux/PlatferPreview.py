# Copyright 2023 Cyril John Magayaga
# Platfer Preview (v2.0-preview2)
# Linux operating system
import gi
gi.require_version('Gtk', '3.0')
gi.require_version('WebKit2', '4.0')
from gi.repository import Gtk, WebKit2

linux = Gtk.Window()
linux.set_title("Platfer Preview")
linux.set_default_size(800,650)

scrolledWindow = Gtk.ScrolledWindow()

platfer = WebKit2.WebView()
platfer.load_uri("https://www.google.com")

linux.connect("destroy",Gtk.main_quit)

scrolledWindow.add(platfer)
linux.add(scrolledWindow)
linux.show_all()
Gtk.main()
