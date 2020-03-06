#!/bin/sh
mcs -pkg:dotnet Program.cs -lib Form1.cs -lib Form1.Designer.cs -out:control
