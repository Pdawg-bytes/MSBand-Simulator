# MSBand-Simulator
MSBand-Simulator is a fully open source simulator for the Microsoft Band's UI that allows for the user to demo the Microsoft Band products and also test basic functions like the music controller or the notfications. **Disclaimer:** This is NOT an emulator for the Band and it does NOT emulate the firmware. This is a full UI simulation in C# and XAML. This app is built in UWP with WinUI 2.1.

# Building
To build this app, you need the Windows10SDK 19041 installed and UWP support in Visual Studio 2022. That's all to build!

# Installing
Installing this app is quite simple. You need to first install the certificate in the zip folder to Local Machine > Trusted People. Now why do you need to do this, you may ask? Well that's because the UWP container needs the app to be launched by the shell correctly, and the certificate is a code signing measure. Anyway, after installing the certificate, double click the .APPX file, then click "Install". That should let you install and run the app! Enjoy!

# Screenshots
![image](https://user-images.githubusercontent.com/83825746/190881357-85df94f4-6646-4abf-98ae-9dc6c2cb9721.png)
![image](https://user-images.githubusercontent.com/83825746/190881366-20f7bfee-d371-4046-b2ce-301c00f14312.png)
![image](https://user-images.githubusercontent.com/83825746/190881370-f01e140f-16d5-45bf-ba37-28781bd6469e.png)
