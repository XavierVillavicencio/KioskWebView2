import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})


export class AppComponent {
  title = 'myangularapp3';
  handleClick() {
    const jsonObject = {
      "items": [
        {
          "url": "https://cheap-assist.net/"
        },
        {
          "url": "https://menacing-consulting.com"
        },
        {
          "url": "https://hefty-ivory.org"
        },
        {
          "url": "https://clean-counterpart.name"
        }
      ]
    }
    alert('data send')
    window?.chrome?.webview?.postMessage(jsonObject);
  }
}

// add chrome to the Window context so typescript stops complaining
declare global {
  interface Window {
    chrome: any;
  }
}