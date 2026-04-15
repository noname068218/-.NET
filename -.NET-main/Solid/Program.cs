// var apple = new Product("Apple", Color.Green, Size.Small);
// var tree = new Product("Tree", Color.Green, Size.Large);
// var house = new Product("House", Color.Blue, Size.Large);

// var products = new List<Product> { apple, tree, house };

// var bf = new BetterFilter();
// Console.WriteLine("Large Products:");
// var largeSpec = new SizeSpecification(Size.Large);
// foreach (var p in bf.Filter(products, largeSpec))
// {
//     Console.WriteLine($"- {p.Name} is large");
// }

// var largeBlueSpec = new AndSpecification<Product>(largeSpec, new ColorSpecification(Color.Blue));
// foreach (var p in bf.Filter(products, largeBlueSpec))
// {
//     Console.WriteLine($"- {p.Name} is large and blue");
// }


var parent = new Person { Name = "John" };
var child = new Person { Name = "Chris" };
var relationships = new Relationships();
relationships.AddParentAndChild(parent, child);

new Research(relationships);