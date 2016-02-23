# POR-PoC

This is a proof of concept of how to implement CRefSharp to begin a transition from a traditional VB executable 
to a Web/Executable hybrid.  This of course is only the initial steps.  

Alot of this was picked up and stolen from: http://www.codeproject.com/Articles/990346/Using-HTML-as-UI-Elements-in-a-WinForms-Applicatio
this tutorial is alot better than what i could do in any reasonable timeframe.  The one thing worth considering is that in the time
since the release of this tutorial chrome itself has been updated and all local paths need to be prefixed with 'file:///'.  Additionally 
it seems like some of the code it depends on has been deprecated.  

Setup - Database
-----
* Open visual studio 2013
* Restore all nuget packages for the solution.
* open up the package manager console and type 'update-database'
  * if there are any issues see: http://www.asp.net/mvc/overview/getting-started/getting-started-with-ef-using-mvc/migrations-and-deployment-with-the-entity-framework-in-an-asp-net-mvc-application
* This should deploy a local copy of the database.  Create the necessary connection strings add users if you need to i'm running
  my 'macadmin' account locally which you won't have.  This is simply because it exists on my server already and is easier.

Setup - IIS
-----
* Run solution as administrator so that you can bind the IIS endpoints properly
  * Build / execute.
* Make sure the connection strings point to a database, you can get away with using the default sql-lite option, but you'll need
  to change some settings.
* Assuming you're running full IIS locally if you've done this with the default settings you should be able to hit: 
  http://localhost/api/ItemInventory and there should be some pre-populated data in there i believe (at worst http 200 ok).

Setup - PoC executable.
-----
* Make sure that you have the configuration manager set to complie the PoC executable as 'x64' or 'x86' as CRefSharp does not support 'any processor'.
* Compile / Run.  The connection strings here may need to be changed as well.  If you changed them at all.  


