console.log('scripts.js loaded');

const mode = (window.process === undefined) ? 'browser' : 'electron';

document.title = `Basic ${mode} app`;

if (mode === 'electron') {

    var contextMenu = require('./context-menu')
    const menuTemplate = [{ label: 'File', submenu: [{ label: 'Save' }] }, {
        role: 'toggledevtools'
    }];
    contextMenu(menuTemplate);
}