# Summary

Windows 11 will support STT for mostly languages, this repository is no longer needed.

but, this repository functions work fine

implemented with Microsoft APIs.

I don't delete the repository because want to help people who use it.



# Using Azure API

![frontEnd](https://i.imgur.com/45IK3sr.png)


use [MS cognitive-services](https://azure.microsoft.com/ko-kr/services/cognitive-services/) 

you need to subscribe to the above API (most tests and light usage are available for free) and enter the key into the program

key 1 or key 2 do not matter, just input any key

![key](https://i.imgur.com/662y1v8.png)

resion and Location are the same (it seems to indicate the location of Microsoft cloud server)

Then click init.


# How to Use this Program

This program is designed simply

※ As it uses a global hook, the program receives key input. This program doesn't send it over the Internet, so please be assured.

Press the Speech field and then press any key to enter the key.

The Off field is the same.

1) How to use Speech key?

After setting the Speech key, click where you can enter such as Notepad.exe, Browser.exe, 

press the Speech key you set and 'talk to the microphone' and what you said will be printed out in text.

2) How to use Off key?

Off disables Speech.

If you want to turn on Speech again later, you have to press the ON button yourself.



※ Pressing the Speech key does not accept input continuously. By default, if you say a sentence and take a break, the text conversion ends automatically (press the Speech key again to reactivate).


# Precautions

Only 'default' microphones are recognized.

![default](https://i.imgur.com/SQHsHWg.png)


STT was built in the following environment.

OS : Windows 10 / 21H1

VS : Visual Studio 2019

and

need to unzip the package.zip. (nuget package)


# Etc

I'm very happy that Microsoft supports this feature at the OS (Windows 11).

The repository will not be updated in the future unless there is a special reason.
