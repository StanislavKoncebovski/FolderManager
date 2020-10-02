; The name of the installer
Name "FlowerPotConfigurator"

; The file to write
OutFile "FlowerPotConfiguratorSetup.exe"

; The default installation directory
InstallDir "$DESKTOP\FlowerPotConfigurator"

; Request application privileges for Windows Vista
RequestExecutionLevel user

; Pages
Page Directory
Page Instfiles
;--------------------------------
; The stuff to install
Section "Files" 
  ; Set output path to the installation directory.
  ; CreateDirectory "$INSTDIR"
  SetOutPath "$INSTDIR"
  
  ; Put files there
  File /r "Binary\Release\*.dll"
  File "Binary\Release\*.exe"
  File "Binary\Release\*.vsix"
  File "Binary\Release\*.pkgdef"
  
SectionEnd ; end the section
