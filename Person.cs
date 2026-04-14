namespace knightmoves;

public class Person{
   public string FirstName;
   public string LastName;
   public int Age;

   //Add your code here
   public Person(string firstName, string lastName, int age){
      FirstName = firstName;
      LastName = lastName;
      Age = age;

      
   }

   public Person(string firstName, string lastName){
      this.FirstName = firstName;
      this.LastName = lastName;

     
   }
}