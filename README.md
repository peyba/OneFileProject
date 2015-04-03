# onefileproject
<b>for test:</b><br>
<ul>
<li>1. compile ClassLibraryForTest project</li>
<li>2. add ClassLibraryForTest\bin\Release\ClassLibraryForTest.dll<br>
   as content-file to the CompressClassLibrary project at `.\lib\` path<br>
   and set <b>Copy to Output Directory</b> property on <b>Copy always</b></li>
<li>3. compile CompressClassLibrary project</li>
<li>4. run CompressClassLibrary\bin\Release\CompressClassLibrary.exe</li>
<li>5. add ClassLibraryForTest.dll and ClassLibraryForTest.dll.deflated from<br>
   OneFileProject\CompressClassLibrary\bin\Release\lib\ to the OneFileProject project<br>
   as content-file at folder Resources</li>
<li>6. compile OneFileProject rpoject</li>
<li>7. run OneFileProject\bin\Release\OneFileProject.exe</li>
</ul>
