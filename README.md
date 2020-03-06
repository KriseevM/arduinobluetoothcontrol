# Arduinobluetoothcontrol
Простейший пульт управления устройством на базе arduino при помощи bluetooth с возможностью задания собственных команд для управления.
Устройство подключается к компьютеру по Bluetooth как последовательный порт (COM, Serial Port). 
Для установки программы в Linux нужно в терминале перейти к корневой папке проекта и выполнить команду
<pre>
$ sh build.sh
</pre>
В результате будет получен исполняемый файл <b>control</b>
Для установки в Windows нужно найти программу csc.exe и выполнить компиляцию проекта в командной строке (cmd, powershell не воспринимает @build.rsp как надо):
<pre>
C:\Windows\Microsoft.NET\Framework\version\csc.exe @build.rsp
</pre>
Путь к csc.exe может быть различным в зависимости от установленной версии .Net Framework, поэтому нужно его писать самостоятельно. Как правило, он схож с написанным выше, только вместо version - версия ваша .Net.
