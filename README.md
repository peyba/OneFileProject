# onefileproject
for test:
1. compile ClassLibraryForTest project;
2. add ClassLibraryForTest\bin\Release\ClassLibraryForTest.dll 
   as content-file to the CompressClassLibrary project at .\lib\ path
   and set "Copy to Output Directory" property on "Copy always";
3. compile CompressClassLibrary project;
4. run CompressClassLibrary\bin\Release\CompressClassLibrary.exe;
5. add ClassLibraryForTest.dll and ClassLibraryForTest.dll.deflated from 
   OneFileProject\CompressClassLibrary\bin\Release\lib\ to the OneFileProject project 
   as content-file at folder Resources;
6. compile OneFileProject rpoject;
7. run OneFileProject\bin\Release\OneFileProject.exe
