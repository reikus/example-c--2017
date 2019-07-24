@echo off

rmdir /S /Q "VCS10StandardApp\obj"
rmdir /S /Q "VCS10StandardApp\bin\Debug"

::del /Q "VCS10StandardApp\bin\Release\*.pdb"
del /Q "VCS10StandardApp\bin\Release\*.vshost.*"
