# Copyright 2023 Cyril John Magayaga
# Platfer Preview (v2.0-preview3)
# Microsoft Windows operating system
import sys
from PyQt5.QtCore import *
from PyQt5.QtWidgets import *
from PyQt5.QtWebEngineWidgets import *

class MainWindow(QMainWindow):
    def __init__(self):

        super(MainWindow, self).__init__()
        self.Platfer = QWebEngineView()
        self.Platfer.setUrl(QUrl('http://google.com'))
        self.setCentralWidget(self.Platfer)
        self.showMaximized()

        # navbar
        navbar = QToolBar()
        self.addToolBar(navbar)

        PlatferBack = QAction('←', self)
        PlatferBack.triggered.connect(self.Platfer.back)
        navbar.addAction(PlatferBack)

        PlatferForward = QAction('→', self)
        PlatferForward.triggered.connect(self.Platfer.forward)
        navbar.addAction(PlatferForward)

        PlatferRefresh = QAction('⟳', self)
        PlatferRefresh.triggered.connect(self.Platfer.reload)
        navbar.addAction(PlatferRefresh)

        PlatferHome = QAction('Home', self)
        PlatferHome.triggered.connect(self.navigate_home)
        navbar.addAction(PlatferHome)

        self.PlatferURLBar = QLineEdit()
        self.PlatferURLBar.returnPressed.connect(self.navigate_to_url)
        navbar.addWidget(self.PlatferURLBar)

        self.Platfer.urlChanged.connect(self.update_url)

    def navigate_home(self):
        self.Platfer.setUrl(QUrl('http://google.com'))

    def navigate_to_url(self):
        url = self.PlatferURLBar.text()
        self.Platfer.setUrl(QUrl(url))

    def update_url(self, q):
        self.PlatferURLBar.setText(q.toString())



app = QApplication(sys.argv)
QApplication.setApplicationName('Platfer Preview')
window = MainWindow()
app.exec_()
