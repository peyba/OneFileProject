# onefileproject

<b>for test:</b><br>
<ul>
<li>1. compile ClassLibraryForTest project</li>
<li>2. add <code>ClassLibraryForTest\bin\Release\ClassLibraryForTest.dll</code><br>
   as content-file to the CompressClassLibrary project at <code>.\lib\</code> path<br>
   and set <b>Copy to Output Directory</b> property on <b>Copy always</b></li>
<li>3. compile CompressClassLibrary project</li>
<li>4. run <code>CompressClassLibrary\bin\Release\CompressClassLibrary.exe</code></li>
<li>5. add ClassLibraryForTest.dll and ClassLibraryForTest.dll.deflated from<br>
   <code>OneFileProject\CompressClassLibrary\bin\Release\lib\</code> to the OneFileProject project<br>
   as content-file at folder Resources</li>
<li>6. compile OneFileProject rpoject</li>
<li>7. run <code>OneFileProject\bin\Release\OneFileProject.exe</code></li>
</ul>
