const {remote} = require('electron');
const {Menu, MenuItem} = remote;

module.exports = (template) => {
  const menu = Menu.buildFromTemplate(template);

  window.addEventListener('contextmenu', e => {
    e.preventDefault()
    menu.popup(remote.getCurrentWindow());
  }, false);
};