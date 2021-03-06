; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{15BB1CE8-29B9-4E79-A902-7B06A45BCAAE}
AppName=FindSerie
AppVersion=2.0
;AppVerName=FindSerie 2.0
AppPublisher=DevIlluSioN
DefaultDirName={pf}\FindSerie
DisableProgramGroupPage=yes
OutputDir=\\Mac\Home\Documents\FindSerie V2\FindSerie\bin
OutputBaseFilename=Setup_FindSerie
Compression=lzma
SolidCompression=yes

[Languages]
Name: "french"; MessagesFile: "compiler:Languages\French.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "\\Mac\Home\Documents\FindSerie V2\FindSerie\bin\Release\FindSerie.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "\\Mac\Home\Documents\FindSerie V2\FindSerie\bin\Release\FindSerie.exe.config"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{commonprograms}\FindSerie"; Filename: "{app}\FindSerie.exe"
Name: "{commondesktop}\FindSerie"; Filename: "{app}\FindSerie.exe"; Tasks: desktopicon

[Run]
Filename: "{app}\FindSerie.exe"; Description: "{cm:LaunchProgram,FindSerie}"; Flags: nowait postinstall skipifsilent

