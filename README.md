# summary

Windows 11 will support STT for mostly languages, this repository is no longer needed.

but, this repository functions work fine

although only microsoft, google api are implemented.

I don't delete the repository because want to help people who use it.



# Using MS API

![frontEnd](https://i.imgur.com/45IK3sr.png)


use [MS cognitive-services](https://azure.microsoft.com/ko-kr/services/cognitive-services/) 

you need to subscribe to the above API (most tests and light usage are available for free) and enter the key into the program

key 1 or key 2 do not matter, just input any key

![key](https://i.imgur.com/662y1v8.png)

resion and Location are the same

(It seems to indicate the location of Microsoft cloud server)

Then click init.


# How to Use this Program

The program is designed to be simple

use keyboard global hooks

rest assured, do not send keystrokes over the Internet

in the **Speech field**, press the key to enter 'when you want to activate STT'

and **Off field** is a shortcut to completely turn off STT.

When the set button is pressed, STT enters OFF mode and the Speech key does not work.

***After that***, press ON to activate the program.

then click on any inputable (notebook, website, etc), 

press the key you set in Speech, and micro 'speak' and your words will be converted into text.


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
