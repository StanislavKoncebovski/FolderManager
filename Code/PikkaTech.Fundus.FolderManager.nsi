; The name of the installer
Name "PikkaTech.Fundus.FolderManager"

; The file to write
OutFile "PikkaTechFolderManager.exe"

; The default installation directory
InstallDir "$PROFILE\My Programs\PikkaTechFolderManager"

; Request application privileges for Windows Vista
RequestExecutionLevel user

; Pages
Page Directory
Page Instfiles
;--------------------------------
; The stuff to install
Section "Files" 
  ; Set output path to the installation directory.
  CreateDirectory "$INSTDIR\Binary"
  SetOutPath "$INSTDIR\Binary"
  
  ; Put files there
  File /r ".\Binary\Release\*.dll"
  File ".\Binary\Release\PikkaTechFolderManager.exe"
  
  CreateDirectory "$INSTDIR\Binary\Data"
  SetOutPath "$INSTDIR\Binary\Data"
  
  File ".\Binary\Release\Data\remove_junk.bat"
   
SectionEnd ; end the section
