using StudentEncapsulation;

Student student1 = new("Vinu", Grade.C, Group.Group_3);
student1.Upgrade();
student1.Upgrade();
student1.Upgrade();
student1.Upgrade();
Console.WriteLine($"Student {student1.Name} has grade {student1.Grade} and belongs to group {student1.Group}");
