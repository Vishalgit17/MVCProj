var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "emp",
    pattern: "Employee/delete/{ssn}",
    defaults: new { controller = "Employee", action = "delete" }
 );
 app.MapControllerRoute(
    name: "emp1",
    pattern: "Employee/update/{eid}",
    defaults: new { controller = "Employee", action = "update" }
 );
  app.MapControllerRoute(
    name: "emp11",
    pattern: "Employee/find/{eidd}",
    defaults: new { controller = "Employee", action = "find" }
 );
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Employee}/{action=Index}/{id?}");

app.Run();






// using System;
// using System.IO;
// using System.Runtime.Serialization.Formatters.Binary;

// [Serializable]
// class Person
// {
//     public string Name { get; set; }
//     public int Age { get; set; }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Person person = new Person { Name = "John Doe", Age = 42 };

//         // Serialize the object to a binary file
//         using (Stream stream = File.Open("person.bin", FileMode.Create))
//         {
//             BinaryFormatter formatter = new BinaryFormatter();
//             formatter.Serialize(stream, person);
//         }

//         // Deserialize the object from the binary file
//         using (Stream stream = File.Open("person.bin", FileMode.Open))
//         {
//             BinaryFormatter formatter = new BinaryFormatter();
//             Person deserializedPerson = (Person)formatter.Deserialize(stream);

//             Console.WriteLine("Name: " + deserializedPerson.Name);
//             Console.WriteLine("Age: " + deserializedPerson.Age);
//         }

//         Console.ReadKey();
//     }
// }






// //Deserialization
// Deserialization in C# is the process of recreating an object from a string of bytes that was previously serialized. The method used for deserialization should match the method used for serialization.

// Here's an example of deserializing an object from a binary file using the BinaryFormatter class:

// Copy code
// using (Stream stream = File.Open("person.bin", FileMode.Open))
// {
//     BinaryFormatter formatter = new BinaryFormatter();
//     Person deserializedPerson = (Person)formatter.Deserialize(stream);

//     Console.WriteLine("Name: " + deserializedPerson.Name);
//     Console.WriteLine("Age: " + deserializedPerson.Age);
// }


// Here's an example of deserializing an object from a XML file using the XmlSerializer class:

// Copy code
// using (FileStream stream = File.OpenRead("person.xml"))
// {
//     XmlSerializer serializer = new XmlSerializer(typeof(Person));
//     Person deserializedPerson = (Person)serializer.Deserialize(stream);

//     Console.WriteLine("Name: " + deserializedPerson.Name);
//     Console.WriteLine("Age: " + deserializedPerson.Age);
// }
// Here's an example of deserializing an object from a JSON file using the Newtonsoft.Json library

// Copy code
// string jsonString = File.ReadAllText("person.json");
// Person deserializedPerson = JsonConvert.DeserializeObject<Person>(jsonString);
// Console.WriteLine("Name: " + deserializedPerson.Name);
// Console.WriteLine("Age: " + deserializedPerson.Age);


// Here's an example of deserializing an object from a string of bytes using the DataContractSerializer class

// Copy code
// using (MemoryStream stream = new MemoryStream(bytes))
// {
//     DataContractSerializer serializer = new DataContractSerializer(typeof(Person));
//     Person deserializedPerson = (Person)serializer.ReadObject(stream);
//     Console.WriteLine("Name: " + deserializedPerson.Name);
//     Console.WriteLine("Age: " + deserializedPerson.Age);
// }
// In all the above examples, the deserialized object is casted to the correct type and its properties can be accessed.
