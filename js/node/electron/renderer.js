// This file is required by the index.html file and will
// be executed in the renderer process for that window.
// All of the Node.js APIs are available in this process.
const spawn = require('child_process').spawn;
function serve() {
    const args = [
        "run",
        "--project",
        "/Users/sanjeevi/CodeFactory/CodeBaseDotNet/Core/Web/Api/"
    ];
    // const streamIn = fs.createReadStream('./path/to/an/image');
    //process.chdir('/Users/sanjeevi/CodeFactory/CodeBaseDotNet/Core/Web/Api/');
    //const proc = spawn('dotnet', args);
    //const proc = spawn('pwd && cd /Users/sanjeevi/CodeFactory/CodeBaseDotNet/Core/Web/Api/ && pwd && dotnet run',{shell:true})
    //streamIn.pipe(proc.stdin);
    //proc.stdout.pipe(resp);

    // proc.stdout.on('data', (data) => {
    //   console.log(`stdout: ${data}`);
    // });
    
    // proc.stderr.on('data', (data) => {
    //   console.log(`stderr: ${data}`);
    // });
    
    // proc.on('close', (code) => {
    //   console.log(`child process exited with code ${code}`);
    // });
    //const proc = spawn('pwd && cd /Users/sanjeevi/CodeFactory/CodeBaseDotNet/Core/Web/Api/ && pwd && dotnet run',{stdio:'inherit', shell:true}) 

    let env = process.env
    env.ASPNETCORE_URLS = 'https://*:5123'
    const proc = spawn('dotnet', ['run'], {stdio: 'inherit', shell: true, cwd: '/Users/sanjeevi/CodeFactory/CodeBaseDotNet/Core/Web/Api/', env: env}) //options: env detached//ASPNETCORE_URLS="https://*:5123"
}

const fs = require('fs')
const pdfPath = '/Users/sanjeevi/wwwroot/node-js-child=processses.pdf'
const {BrowserWindow,shell} = require('electron').remote
function print() {
  let win = new BrowserWindow({width: 1440, height: 900, show:false})
  win.loadURL('https://medium.freecodecamp.org/node-js-child-processes-everything-you-need-to-know-e69498fe970a')
  win.webContents.on('did-finish-load', function() {
    win.webContents.printToPDF({}, (error, data) => {
      if (error) throw error
      fs.writeFile(pdfPath, data, (error) => {
        if (error) throw error
        shell.openExternal(`file://${pdfPath}`)
      })
    })
  })
}

function showEnv() {
  let win = new BrowserWindow({width: 960, height: 600})
  console.log(__dirname)
  win.loadFile('env.html')
}

function db() {
  require('./db.js')
}

// '/Library/Frameworks/Python.framework/Versions/3.6/bin:/Library/Frameworks/Python.framework/Versions/2.7/bin:/usr/local/bin:/usr/bin:/bin:/usr/sbin:/sbin:/usr/local/share/dotnet:~/.dotnet/tools:/usr/local/go/bin:/Library/Frameworks/Mono.framework/Versions/Current/Commands:/Applications/Xamarin Workbooks.app/Contents/SharedSupport/path-bin'
document.getElementById('dotnet-serve').addEventListener('click', serve);
document.getElementById('print-pdf-web-page').addEventListener('click', print);
document.getElementById('show-env').addEventListener('click', showEnv);
document.getElementById('db').addEventListener('click', db);