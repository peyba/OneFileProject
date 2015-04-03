# onefileproject

<b>for test:</b><br>
<ol>
<li>compile ClassLibraryForTest project</li>
<li>add <code>ClassLibraryForTest\bin\Release\ClassLibraryForTest.dll</code><br>
   as content-file to the CompressClassLibrary project at <code>.\lib\</code> path<br>
   and set <b>Copy to Output Directory</b> property on <b>Copy always</b></li>
<li>compile CompressClassLibrary project</li>
<li>run <code>CompressClassLibrary\bin\Release\CompressClassLibrary.exe</code></li>
<li>add ClassLibraryForTest.dll and ClassLibraryForTest.dll.deflated from<br>
   <code>OneFileProject\CompressClassLibrary\bin\Release\lib\</code> to the OneFileProject project<br>
   as content-file at folder Resources</li>
<li>compile OneFileProject rpoject</li>
<li>run <code>OneFileProject\bin\Release\OneFileProject.exe</code></li>
</ol>
