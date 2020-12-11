# DataAccessRepo
In this project,we use data access tools as an Entity Framework.
<h3>ORM(Object Relational Mapping)<h3>
What is an ORM?
<p>Object-relational-mapping is the idea of being able to write queries , as well as much more complicated ones, using the object-oriented paradigm of your preferred programming language.</p>
  
  
  
  
<img src="https://gblobscdn.gitbook.com/assets%2F-MNrO0PWI5eVuZV2v0d3%2F-MNrO5Gb0R_STPJqJkZL%2F-MNrStUhK7YPK2nwYkEZ%2FEntity-Framework-Architecture.png?alt=media&token=ab476d27-f58f-466f-be2e-45c3a2cae91c" title="ORM Picture Gitbook " width="300" height="300">



<h2>Entity FrameWork<h2>
<h3><p>Entity Framework is a tool for Object Relational Mapping.It is like a bridge between OOP and Relational Data Base.Entity Frame Work works as an assistans by getting data and bound your database object.Entity Framework works with Ado.Net.What is the Ado.Net? 
It contains UnitOfWork design pattern and written by Microsoft.For instance, adding, updating,deleting like this process we should create sentences String type.On the other hand,UnitOfWork doesn't need seperate all String process properly.It can manage these processes just by one source and u don't need to definite more String type.
We can create a project by using 4 different path with EntityFrameWork:</p><h3>

<h4>1)Model First:<h4>
In this pattern, we create an empity modal file on the Visual Studio and add (.edmx) then we may design our database.At the compilation step Script file which is given creates database.
<h4>2)Database First:<h4>
Database First pattern provides automatic class creating by using Entity Framework.In this pattern Database should be created before tie up project as a modal.
<h4>3)Code First:By Code<h4>
In this pattern,All classes are created on the Visual Studio manually.Then Database derives from these classes.At that step Mapping processes can be manage thanks to Attributes.In addition to attributes Fluent Api and Fluent Validation can be used for Mapping process.
<h4>4)Code First:By Use Database<h4>
At this pattern, as wee read before,it is similar.It means,developer created classes and mapping codes.
Database updates in terms of class and models situation.






<img src="https://gblobscdn.gitbook.com/assets%2F-MNrO0PWI5eVuZV2v0d3%2F-MNrO5Gb0R_STPJqJkZL%2F-MNrW5-06-anPuyPSOXt%2F0_piJQgBv6DUDdtx_l%20(1).png?alt=media&token=5f22764f-4244-4471-abcd-94b9e1693425"  title="Entity FrameWork Picture" width="600" height="400">



<h2>What is Eager Loading<h2>
  <h3><p> Eager loading is a technique where EF loads the related entities along with the main entity.All entities are loaded in a single query to database thus saving bandwidth and crucial server CPU time.This is done using "include method", which has two overloads.One of which takes navigation property as a string.the other "include method" is an extension method and far more flexible.In this tutorial,we learn how to make load the entities eagerly.We also show how to Eager Loading from multiple Levels and multiple Tables.  
        One of the ways we can load entities eagerly by using the "include" method.Entity Framework creates a join query,when it sees the "include" method , thus bringing all the records in one single query.
        There are two versions of the include method available. The default method where you need to specify the navigational Property as a string.
         The other one from the System.Data.Entity namespace.It takes a lambda expression,where you need to specify the navigational Property.</p>
Visit me
https://hsnaltan13.gitbook.io/entity-framework-ef-ado-net 
