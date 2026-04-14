namespace knightmoves;

public class Person{
   public string FirstName;
   public string LastName;
   public int Age;

   //Add your code here
   public string Person(string FirstName, string LastName, int Age){
      FirstName = firstName;
      LastName = lastName;
      Age = age;

      return $"first name: {firstName}, last name: {lastName}, age: {age}";
   }

   public string Person(string FirstName, string LastName){
      this.FirstName = firstName;
      this.LastName = lastName;

      return $"first name: {firstName}, last name: {lastName}";
   }
}