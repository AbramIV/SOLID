using DependencyInversion;

Relationships relationships = new();

Person parent = new("Jorge");
relationships.AddParentAndChild(parent, new Person("Gerardo"));
relationships.AddParentAndChild(parent, new Person("Tay"));

_ = new Research(relationships, parent.Name);

Console.ReadLine();