System.drawing issues
------------------------


Atttemp 1
---------
Copied the following files from .CORE Directo to Plugin of Std

System.Drawing.Common.dll
System.Drawing.dll

Exception
System.IO.FileNotFoundException: Could not load file or assembly 'System.Runtime, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a' or one of its dependencies. 
The system cannot find the file specified.



Attempt 2
----------
Deleted System.drawing.dll and System.drawing.commn.dll
Error
	System.drawing.common.dll is missing
	
	
Attempt 3
---------
Replace System.drawing.common.dll
Same issue with System.Runtime,


	
=== Pre-bind state information ===
LOG: DisplayName = System.Runtime, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
 (Fully-specified)
LOG: Appbase = file:///C:/Users/saurabhd/MyTrials/Apex-Stuff/ClosedXMLMef/Demo.ConsoleEXEFwk/bin/Debug/net461/
LOG: Initial PrivatePath = NULL
Calling assembly : System.Drawing.Common, Version=4.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51.
===
LOG: This bind starts in LoadFrom load context.
WRN: Native image will not be probed in LoadFrom context. Native image will only be probed in default load context, like with Assembly.Load().
LOG: Using application configuration file: C:\Users\saurabhd\MyTrials\Apex-Stuff\ClosedXMLMef\Demo.ConsoleEXEFwk\bin\Debug\net461\Demo.ConsoleEXEFwk.exe.Config
LOG: Using host configuration file: 
LOG: Using machine configuration file from C:\Windows\Microsoft.NET\Framework64\v4.0.30319\config\machine.config.
LOG: Post-policy reference: System.Runtime, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
LOG: Attempting download of new URL file:///C:/Users/saurabhd/MyTrials/Apex-Stuff/ClosedXMLMef/Demo.ConsoleEXEFwk/bin/Debug/net461/System.Runtime.DLL.
WRN: Comparing the assembly name resulted in the mismatch: Minor Version
LOG: Attempting download of new URL file:///C:/Users/saurabhd/MyTrials/Apex-Stuff/ClosedXMLMef/Demo.ConsoleEXEFwk/bin/Debug/net461/System.Runtime/System.Runtime.DLL.
LOG: Attempting download of new URL file:///C:/Users/saurabhd/MyTrials/Apex-Stuff/ClosedXMLMef/Demo.ConsoleEXEFwk/bin/Debug/net461/System.Runtime.EXE.
LOG: Attempting download of new URL file:///C:/Users/saurabhd/MyTrials/Apex-Stuff/ClosedXMLMef/Demo.ConsoleEXEFwk/bin/Debug/net461/System.Runtime/System.Runtime.EXE.
LOG: Attempting download of new URL file:///C:/USERS/SAURABHD/MYTRIALS/APEX-STUFF/CLOSEDXMLMEF/DEMO.CONSOLEEXEFWK/BIN/DEBUG/NET461/PLUGINS/DEMO.PLUGIN.NETSTD/System.Runtime.DLL.
WRN: Comparing the assembly name resulted in the mismatch: Build Number
LOG: Attempting download of new URL file:///C:/USERS/SAURABHD/MYTRIALS/APEX-STUFF/CLOSEDXMLMEF/DEMO.CONSOLEEXEFWK/BIN/DEBUG/NET461/PLUGINS/DEMO.PLUGIN.NETSTD/System.Runtime/System.Runtime.DLL.
LOG: Attempting download of new URL file:///C:/USERS/SAURABHD/MYTRIALS/APEX-STUFF/CLOSEDXMLMEF/DEMO.CONSOLEEXEFWK/BIN/DEBUG/NET461/PLUGINS/DEMO.PLUGIN.NETSTD/System.Runtime.EXE.
LOG: Attempting download of new URL file:///C:/USERS/SAURABHD/MYTRIALS/APEX-STUFF/CLOSEDXMLMEF/DEMO.CONSOLEEXEFWK/BIN/DEBUG/NET461/PLUGINS/DEMO.PLUGIN.NETSTD/System.Runtime/System.Runtime.EXE.
