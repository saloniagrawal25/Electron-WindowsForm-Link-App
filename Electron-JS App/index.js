const { ipcRenderer } = require("electron");

const openForm1 = document.getElementById("openForm1");

openForm1.addEventListener("click", function () {
  ipcRenderer.send("openForm1");
});

const openForm2 = document.getElementById("openForm2");

openForm2.addEventListener("click", function () {
  ipcRenderer.send("openForm2");
});

const openForm3 = document.getElementById("openForm3");

openForm3.addEventListener("click", function () {
  ipcRenderer.send("openForm3");
});
