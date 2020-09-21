// Modules to control application life and create native browser window
const { app, BrowserWindow, ipcRenderer } = require("electron");
const net = require("net");
const electron = require("electron");
const ipc = electron.ipcMain;
// Keep a global reference of the window object, if you don't, the window will
// be closed automatically when the JavaScript object is garbage collected.
let mainWindow;
function createWindow() {
  // Create the browser window.
  mainWindow = new BrowserWindow({
    width: 800,
    height: 600,
    webPreferences: {
      nodeIntegration: true,
      enableRemoteModule: true,
    },
  });
  // and load the index.html of the app.
  mainWindow.loadFile("./index.html");
  // Open the DevTools.
  mainWindow.webContents.openDevTools();
  // Emitted when the window is closed.
  mainWindow.on("closed", function () {
    // Dereference the window object, usually you would store windows
    // in an array if your app supports multi windows, this is the time
    // when you should delete the corresponding element.
    mainWindow = null;
  });
}
var HOST = ""; // ip address for the socket
var PORT = 8000; // port number for the socket
var client = new net.Socket();
client.connect(PORT, HOST, function () {
  console.log("CONNECTED TO: " + HOST + ":" + PORT);
  // Write a message to the socket as soon as the client is connected, the server will receive it as message from the client
  client.write("I am Chuck Norris!");
});
// Add a 'data' event handler for the client socket
// data is what the server sent to this socket
client.on("data", function (data) {
  console.log("DATA: " + data);
  //client.write("received: " + data);
  let win = new BrowserWindow({
    width: 400,
    height: 200,
    webPreferences: {
      nodeIntegration: true,
      enableRemoteModule: true,
    },
  });
  win.on("close", function () {
    win = null;
  });
  win.loadFile("add.html");
  // Close the client socket completely
});
// Add a 'close' event handler for the client socket
client.on("close", function () {
  console.log("Connection closed");
});
ipc.on("openForm1", function (event) {
  client.write("openForm1");
});
ipc.on("openForm2", function (event) {
  client.write("openForm2");
});
ipc.on("closeAll", function (event) {
  client.write("closeAll");
});

// This method will be called when Electron has finished
// initialization and is ready to create browser windows.
// Some APIs can only be used after this event occurs.
app.on("ready", createWindow);
// Quit when all windows are closed.
app.on("window-all-closed", function () {
  // On OS X it is common for applications and their menu bar
  // to stay active until the user quits explicitly with Cmd + Q
  if (process.platform !== "darwin") {
    app.quit();
  }
});
app.on("activate", function () {
  // On OS X it's common to re-create a window in the app when the
  // dock icon is clicked and there are no other windows open.
  if (mainWindow === null) {
    createWindow();
  }
});
