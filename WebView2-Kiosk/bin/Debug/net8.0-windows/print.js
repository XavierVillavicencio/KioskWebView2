    // Spawning .exe files on Windows 
    const { spawn } = require('node:child_process'); 
    const exe = spawn('cmd.exe', ['/c', 'WebView2-Kiosk.exe']); 
     
    exe.stdout.on('data', (data) => { 
      console.log(data.toString()); 
    }); 
     
    exe.stderr.on('data', (data) => { 
      console.error(data.toString()); 
    }); 
     
    exe.on('exit', (code) => { 
      console.log(`Child exited with code ${code}`); 
    }); 