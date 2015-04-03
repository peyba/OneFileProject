# onefileproject
<b>for test:</b><br>
1. compile ClassLibraryForTest project;<br>
2. add `ClassLibraryForTest\bin\Release\ClassLibraryForTest.dll`<br>
   as content-file to the CompressClassLibrary project at `.\lib\` path<br>
   and set <b>Copy to Output Directory</b> property on <b>Copy always</b>;<br>
3. compile CompressClassLibrary project;<br>
4. run `CompressClassLibrary\bin\Release\CompressClassLibrary.exe`;<br>
5. add ClassLibraryForTest.dll and ClassLibraryForTest.dll.deflated from<br>
   `OneFileProject\CompressClassLibrary\bin\Release\lib\` to the OneFileProject project<br>
   as content-file at folder Resources;<br>
6. compile OneFileProject rpoject;<br>
7. run `OneFileProject\bin\Release\OneFileProject.exe`<br>
