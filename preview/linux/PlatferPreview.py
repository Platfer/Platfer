# Copyright 2023 Cyril John Magayaga
# Platfer Preview (v2.0-preview2)
# Linux operating system
import gi
gi.require_version('Gtk', '3.0')
gi.require_version('WebKit2', '4.1')
from gi.repository import Gtk, WebKit2

linux = Gtk.Window()
linux.set_title("Platfer Preview")
linux.set_default_size(950,650)

def enter(entry):
    url = entry.get_text()
    if url.startswith("http://") or url.startswith("https://"):
           platfer.load_uri(url)
       
    else: 
       platferurl = "https://" + url
       platferurl.set_text(url)
       platfer.load_uri(platferurl)
       
def change_url(entry, widget, frame):
    uri = platfer.get_uri()
    entry.set_text(uri)
    
def go_back(go_back_button):
    platfer.go_back()
    
def go_forward(go_forward_button):
    platfer.go_forward()
    
def go_refresh(go_refresh_button):
    platfer.reload()

def go_home(go_home_button):
    platfer.load_uri("https://www.google.com")

scrolledWindow = Gtk.ScrolledWindow()

platfer = WebKit2.WebView()
platfer.load_uri("https://www.google.com")
platfer.connect("notify::estimated-load-progress", change_url)

linux.connect("destroy",Gtk.main_quit)

navbar = Gtk.HeaderBar()
navbar.set_show_close_button(True)
linux.set_titlebar(navbar)

entry = Gtk.Entry()
entry.connect("activate", enter)
navbar.set_custom_title(entry)

go_back_button = Gtk.Button()
go_back_arrow = Gtk.Image.new_from_icon_name("go-previous", Gtk.IconSize.SMALL_TOOLBAR)
go_back_button.add(go_back_arrow)
go_back_button.connect("clicked", go_back)
navbar.pack_start(go_back_button)

go_forward_button = Gtk.Button()
go_forward_arrow = Gtk.Image.new_from_icon_name("go-next", Gtk.IconSize.SMALL_TOOLBAR)
go_forward_button.add(go_forward_arrow)
go_forward_button.connect("clicked", go_forward)
navbar.pack_start(go_forward_button)

go_refresh_button = Gtk.Button()
go_refresh_btn = Gtk.Image.new_from_icon_name("view-refresh", Gtk.IconSize.SMALL_TOOLBAR)
go_refresh_button.add(go_refresh_btn)
go_refresh_button.connect("clicked", go_refresh)
navbar.pack_start(go_refresh_button)

go_home_button = Gtk.Button()
go_home_btn = Gtk.Image.new_from_icon_name("go-home", Gtk.IconSize.SMALL_TOOLBAR)
go_home_button.add(go_home_btn)
go_home_button.connect("clicked", go_home)
navbar.pack_start(go_home_button)

scrolledWindow.add(platfer)
linux.add(scrolledWindow)
linux.show_all()
Gtk.main()
